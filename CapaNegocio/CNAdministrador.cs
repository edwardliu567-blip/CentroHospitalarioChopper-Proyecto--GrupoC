using CapaDatos;
using CapaEntidad;
using System;
using System.Data;

namespace CapaNegocio
{
    public class CNAdministrador
    {
        private CDAdministrador cdAdmin = new CDAdministrador();

        public string EliminarAdministrador(string idAdmin)
        {
            if (string.IsNullOrWhiteSpace(idAdmin))
                return "Debe indicar el ID del administrador.";

            cdAdmin.EliminarAdministrador(idAdmin);
            return "Administrador eliminado correctamente.";
        }

        public DataTable VerAdministradores()
        {
            return cdAdmin.VerAdministradores();
        }

        public DataTable FiltrarAdministradores(string idAdmin, string nombreAdmin)
        {
            return cdAdmin.FiltrarAdministradores(idAdmin, nombreAdmin);
        }

        public string IniciarSesion(string idAdmin, string clave)
        {
            if (string.IsNullOrWhiteSpace(idAdmin) || string.IsNullOrWhiteSpace(clave))
                return "Debe ingresar IdAdmin y contraseña.";

            bool valido = cdAdmin.Login(idAdmin, clave);

            if (!valido)
                return "IdAdmin o contraseña inválidos.";

            return "Acceso concedido.";
        }

        // 🚨 Validación de duplicados antes de agregar
        public string AgregarAdministrador_ConClave(CEAdministrador admin)
        {
            if (string.IsNullOrWhiteSpace(admin.IdAdmin) ||
                string.IsNullOrWhiteSpace(admin.NombreAdmin) ||
                string.IsNullOrWhiteSpace(admin.ApellidoAdmin) ||
                string.IsNullOrWhiteSpace(admin.EmailAdmin) ||
                string.IsNullOrWhiteSpace(admin.clave))
            {
                return "Todos los campos son obligatorios.";
            }

            // Verificar duplicados
            DataTable existentes = cdAdmin.VerAdministradores_ConClave();
            foreach (DataRow row in existentes.Rows)
            {
                string idExistente = row["ID"].ToString();
                string correoExistente = row["Correo"].ToString();

                if (idExistente.Equals(admin.IdAdmin, StringComparison.OrdinalIgnoreCase))
                {
                    return "Ya existe un administrador con el mismo IdAdmin.";
                }

                if (correoExistente.Equals(admin.EmailAdmin, StringComparison.OrdinalIgnoreCase))
                {
                    return "Ya existe un administrador con el mismo correo.";
                }
            }

            cdAdmin.AgregarAdministrador_ConClave(admin);
            return "Administrador agregado correctamente.";
        }

        // 🚨 Validación de existencia antes de actualizar
        public string ActualizarAdministrador_ConClave(CEAdministrador admin)
        {
            if (string.IsNullOrWhiteSpace(admin.IdAdmin))
                return "Debe indicar el ID del administrador.";

            // Verificar que el administrador exista antes de actualizar
            DataTable existentes = cdAdmin.VerAdministradores_ConClave();
            bool existe = false;
            foreach (DataRow row in existentes.Rows)
            {
                if (row["ID"].ToString().Equals(admin.IdAdmin, StringComparison.OrdinalIgnoreCase))
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                return "No existe un administrador con ese IdAdmin.";

            cdAdmin.ActualizarAdministrador_ConClave(admin);
            return "Administrador actualizado correctamente.";
        }

        public DataTable VerAdministradores_ConClave()
        {
            return cdAdmin.VerAdministradores_ConClave();
        }
    }
}