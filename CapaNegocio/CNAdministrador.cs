using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNAdministrador
    {
        private CDAdministrador cdAdmin = new CDAdministrador();

        public string AgregarAdministrador(CEAdministrador admin)
        {
            if (string.IsNullOrWhiteSpace(admin.IdAdmin) ||
                string.IsNullOrWhiteSpace(admin.NombreAdmin) ||
                string.IsNullOrWhiteSpace(admin.ApellidoAdmin) ||
                string.IsNullOrWhiteSpace(admin.EmailAdmin))
            {
                return "Todos los campos son obligatorios.";
            }

            cdAdmin.AgregarAdministrador(admin);
            return "Administrador agregado correctamente.";
        }

        public string ActualizarAdministrador(CEAdministrador admin)
        {
            if (string.IsNullOrWhiteSpace(admin.IdAdmin))
                return "Debe indicar el ID del administrador.";

            cdAdmin.ActualizarAdministrador(admin);
            return "Administrador actualizado correctamente.";
        }

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



    }
}
