using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDAdministrador
    {
        // Cadena de conexión
        private readonly string conexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CHChopper;Integrated Security=True";

        public void AgregarAdministrador(CEAdministrador admin)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Agregar_Administrador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_admin", admin.IdAdmin);
                cmd.Parameters.AddWithValue("@nombre_admin", admin.NombreAdmin);
                cmd.Parameters.AddWithValue("@apellido_admin", admin.ApellidoAdmin);
                cmd.Parameters.AddWithValue("@email_admin", admin.EmailAdmin);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarAdministrador(CEAdministrador admin)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Actualizar_Administrador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_admin", admin.IdAdmin);
                cmd.Parameters.AddWithValue("@nombre_admin", admin.NombreAdmin);
                cmd.Parameters.AddWithValue("@apellido_admin", admin.ApellidoAdmin);
                cmd.Parameters.AddWithValue("@email_admin", admin.EmailAdmin);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAdministrador(string idAdmin)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Eliminar_Administrador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_admin", idAdmin);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable VerAdministradores()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Ver_Administrador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable FiltrarAdministradores(string idAdmin, string nombreAdmin)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Filtrar_Administradores", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_admin", string.IsNullOrEmpty(idAdmin) ? (object)DBNull.Value : idAdmin);
                cmd.Parameters.AddWithValue("@nombre_admin", string.IsNullOrEmpty(nombreAdmin) ? (object)DBNull.Value : nombreAdmin);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Login(string idAdmin, string clave)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_LoginAdmin", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_admin", idAdmin);
                cmd.Parameters.AddWithValue("@clave", clave);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr.HasRows; 
            }

        }


    }
}