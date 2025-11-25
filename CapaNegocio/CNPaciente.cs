using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNPaciente
    {
        private CDPaciente cdPaciente = new CDPaciente();

        public string AgregarPaciente(CEPaciente paciente)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(paciente.CedPaciente) ||
                    string.IsNullOrWhiteSpace(paciente.NombrePaciente) ||
                    string.IsNullOrWhiteSpace(paciente.ApellidoPaciente) ||
                    string.IsNullOrWhiteSpace(paciente.EmailPaciente) ||
                    string.IsNullOrWhiteSpace(paciente.TelefonoPaciente) ||
                    string.IsNullOrWhiteSpace(paciente.IdAdmin)) // validación de admin
                {
                    return "Todos los campos son obligatorios, incluyendo el administrador.";
                }

                if (!Regex.IsMatch(paciente.TelefonoPaciente, @"^\d{3,4}-\d{4}$"))
                    return "El teléfono debe tener formato válido (ej: 6898-9854 o 245-6846).";

                if (!Regex.IsMatch(paciente.EmailPaciente, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    return "El correo electrónico no tiene un formato válido.";

                DataTable dt = cdPaciente.VerPacientes();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["ced_paciente"].ToString() == paciente.CedPaciente)
                        return "Ya existe un paciente con esa cédula.";
                }

                bool correoExiste = dt.AsEnumerable()
                    .Any(r => r["email_paciente"].ToString().Equals(paciente.EmailPaciente, StringComparison.OrdinalIgnoreCase));

                if (correoExiste)
                {
                    return "El correo ya está registrado. Ingrese uno diferente.";
                }

                cdPaciente.AgregarPaciente(paciente);
                return "Paciente agregado correctamente.";
            }
            catch (Exception ex)
            {
                if (ex.InnerException is SqlException sqlEx)
                {
                    if (sqlEx.Message.Contains("UNIQUE KEY"))
                    {
                        return "El correo ya está registrado. Ingrese un correo diferente.";
                    }
                }
                return "Error al agregar paciente: " + ex.Message;
            }
        }

        public string ActualizarPaciente(CEPaciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.CedPaciente))
                return "Debe indicar la cédula del paciente.";

            if (string.IsNullOrWhiteSpace(paciente.IdAdmin)) // validación de admin
                return "Debe seleccionar un administrador.";

            if (!Regex.IsMatch(paciente.TelefonoPaciente, @"^\d{3,4}-\d{4}$"))
                return "El teléfono debe tener formato válido (ej: 6898-9854 o 245-6846).";

            if (!Regex.IsMatch(paciente.EmailPaciente, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "El correo electrónico no tiene un formato válido.";

            DataTable dt = cdPaciente.VerPacientes();

            // Validar existencia del paciente por cédula
            bool existe = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["ced_paciente"].ToString() == paciente.CedPaciente)
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
                return "No existe un paciente con esa cédula.";

            // Validar que el correo no esté duplicado en otro paciente
            foreach (DataRow row in dt.Rows)
            {
                if (row["email_paciente"].ToString().Equals(paciente.EmailPaciente, StringComparison.OrdinalIgnoreCase) &&
                    row["ced_paciente"].ToString() != paciente.CedPaciente)
                {
                    return "El correo ya está registrado por otro paciente.";
                }
            }

            cdPaciente.ActualizarPaciente(paciente);
            return "Paciente actualizado correctamente.";
        }

        public string EliminarPaciente(string cedPaciente)
        {
            if (string.IsNullOrWhiteSpace(cedPaciente))
                return "Debe indicar la cédula del paciente.";

            DataTable dt = cdPaciente.VerPacientes();
            bool existe = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["ced_paciente"].ToString() == cedPaciente)
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
                return "No existe un paciente con esa cédula.";

            cdPaciente.EliminarPaciente(cedPaciente);
            return "Paciente eliminado correctamente.";
        }

        public DataTable VerPacientes()
        {
            return cdPaciente.VerPacientes();
        }
        public DataTable HistorialCitasPaciente(string cedPaciente, string NombrePaciente)
        {
            return cdPaciente.HistorialCitasPaciente(cedPaciente, NombrePaciente);
        }
    }

}