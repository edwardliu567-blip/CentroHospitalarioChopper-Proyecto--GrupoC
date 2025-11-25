using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Text.RegularExpressions;

namespace CapaNegocio
{
    public class CNMedico
    {
        private CDMedico cdMedico = new CDMedico();

        public string AgregarMedico(CEMedico medico)
        {
            if (string.IsNullOrWhiteSpace(medico.ced_medico) ||
                string.IsNullOrWhiteSpace(medico.nombre_medico) ||
                string.IsNullOrWhiteSpace(medico.apellido_medico) ||
                string.IsNullOrWhiteSpace(medico.especialidad) ||
                string.IsNullOrWhiteSpace(medico.email_medico) ||
                string.IsNullOrWhiteSpace(medico.tel_medico))
            {
                return "Todos los campos son obligatorios.";
            }

            if (!Regex.IsMatch(medico.tel_medico, @"^\d{3,4}-\d{4}$"))
            {
                return "El teléfono debe tener formato válido (ej: 6898-9854 o 245-6846).";
            }


            if (!Regex.IsMatch(medico.email_medico, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return "El correo electrónico no tiene un formato válido.";
            }
            DataTable dt = cdMedico.VerMedicos();
            foreach (DataRow row in dt.Rows)
            {
                if (row["ced_medico"].ToString() == medico.ced_medico)
                {
                    return "Ya existe un médico con esa cédula.";
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                if (row["email_medico"].ToString().Equals(medico.email_medico, StringComparison.OrdinalIgnoreCase))
                {
                    return "Ya existe un médico con ese correo.";
                }
            }

            cdMedico.AgregarMedico(medico);
            return "Médico agregado correctamente.";
        }

        public string ActualizarMedico(CEMedico medico)
        {
            if (string.IsNullOrWhiteSpace(medico.ced_medico))
                return "Debe indicar la cédula del médico.";

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(medico.nombre_medico) ||
                string.IsNullOrWhiteSpace(medico.apellido_medico) ||
                string.IsNullOrWhiteSpace(medico.especialidad) ||
                string.IsNullOrWhiteSpace(medico.email_medico) ||
                string.IsNullOrWhiteSpace(medico.tel_medico))
            {
                return "Todos los campos son obligatorios.";
            }
            if (!Regex.IsMatch(medico.tel_medico, @"^\d{3,4}-\d{4}$"))
            {
                return "El teléfono debe tener formato válido (ej: 6898-9854 o 245-6846).";
            }

            // Validar correo
            if (!Regex.IsMatch(medico.email_medico, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "El correo electrónico no tiene un formato válido.";

            // Validar que la cédula sí exista (solo en actualizar)
            DataTable dt = cdMedico.VerMedicos();
            bool existe = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["ced_medico"].ToString() == medico.ced_medico)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                return "No existe un médico con esa cédula.";
            foreach (DataRow row in dt.Rows)
            {
                if (row["email_medico"].ToString().Equals(medico.email_medico, StringComparison.OrdinalIgnoreCase) &&
                    row["ced_medico"].ToString() != medico.ced_medico)
                {
                    return "El correo ya está registrado por otro médico.";
                }
            }


            cdMedico.ActualizarMedico(medico);
            return "Médico actualizado correctamente.";
        }

        public string EliminarMedico(string cedMedico)
        {
            if (string.IsNullOrWhiteSpace(cedMedico))
                return "Debe indicar la cédula del médico.";

            // Validar que la cédula exista en la tabla
            DataTable dt = cdMedico.VerMedicos();
            bool existe = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["ced_medico"].ToString() == cedMedico)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                return "No existe un médico con esa cédula.";

            cdMedico.EliminarMedico(cedMedico);
            return "Médico eliminado correctamente.";
        }
        public DataTable VerMedicos()
        {
            return cdMedico.VerMedicos();
        }

        public DataTable FiltrarCitasPorMedico(string cedMedico, string nombreMedico)
        {
            return cdMedico.FiltrarCitasPorMedico(cedMedico, nombreMedico);
        }

    }

}
