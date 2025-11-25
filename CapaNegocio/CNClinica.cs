using CapaDatos;
using CapaEntidad;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace CapaNegocio
{
    public class CNClinica
    {
        private CDClinica cdClinica = new CDClinica();

        public string AgregarClinica(CEClinica clinica)
        {
            if (string.IsNullOrWhiteSpace(clinica.NombreClinica) ||
                string.IsNullOrWhiteSpace(clinica.Direccion) ||
                string.IsNullOrWhiteSpace(clinica.Telefono))
            {
                return "Todos los campos son obligatorios.";
            }

            if (!Regex.IsMatch(clinica.Telefono, @"^\d{3,4}-\d{4}$"))
                return "El teléfono debe tener formato válido (ej: 6898-9854 o 245-6846).";

            DataTable dt = cdClinica.VerClinicas();

            // Validar nombre duplicado
            foreach (DataRow row in dt.Rows)
            {
                if (row["nombre_clinica"].ToString().Equals(clinica.NombreClinica, StringComparison.OrdinalIgnoreCase))
                {
                    return "Ya existe una clínica con ese nombre.";
                }
            }

            // Validar teléfono duplicado
            foreach (DataRow row in dt.Rows)
            {
                if (row["telefono"].ToString().Equals(clinica.Telefono, StringComparison.OrdinalIgnoreCase))
                {
                    return "Ya existe una clínica con ese teléfono.";
                }
            }

            cdClinica.AgregarClinica(clinica);
            return "Clínica agregada correctamente.";
        }

        public string ActualizarClinica(CEClinica clinica)
        {
            if (clinica.IdClinica <= 0)
                return "Debe indicar el ID de la clínica.";

            if (!Regex.IsMatch(clinica.Telefono, @"^\d{3,4}-\d{4}$"))
                return "El teléfono debe tener formato válido (ej: 6898-9854 o 245-6846).";

            DataTable dt = cdClinica.VerClinicas();
            bool existe = false;

            foreach (DataRow row in dt.Rows)
            {
                if (row["id_clinica"].ToString() == clinica.IdClinica.ToString())
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                return "No existe una clínica con ese ID.";

            // Validar nombre duplicado en otra clínica
            foreach (DataRow row in dt.Rows)
            {
                if (row["nombre_clinica"].ToString().Equals(clinica.NombreClinica, StringComparison.OrdinalIgnoreCase) &&
                    row["id_clinica"].ToString() != clinica.IdClinica.ToString())
                {
                    return "Ya existe otra clínica con ese nombre.";
                }
            }

            // Validar teléfono duplicado en otra clínica
            foreach (DataRow row in dt.Rows)
            {
                if (row["telefono"].ToString().Equals(clinica.Telefono, StringComparison.OrdinalIgnoreCase) &&
                    row["id_clinica"].ToString() != clinica.IdClinica.ToString())
                {
                    return "Ya existe otra clínica con ese teléfono.";
                }
            }

            cdClinica.ActualizarClinica(clinica);
            return "Clínica actualizada correctamente.";
        }

        public string EliminarClinica(int idClinica)
        {
            if (idClinica <= 0)
                return "Debe indicar el ID de la clínica.";

            DataTable dt = cdClinica.VerClinicas();
            bool existe = false;

            foreach (DataRow row in dt.Rows)
            {
                if (row["id_clinica"].ToString() == idClinica.ToString())
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                return "No existe una clínica con ese ID.";

            cdClinica.EliminarClinica(idClinica);
            return "Clínica eliminada correctamente.";
        }

        public DataTable VerClinicas()
        {
            return cdClinica.VerClinicas();
        }
        public DataTable FiltrarClinicas(string nombreClinica, int? idClinica)
        {
            return cdClinica.FiltrarClinicas(nombreClinica, idClinica);
        }
    }
}