using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDMedico
    {
        private readonly string conexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CHChopper;Integrated Security=True";

        public void AgregarMedico(CEMedico medico)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Agregar_Medico", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ced_medico", medico.ced_medico);
                cmd.Parameters.AddWithValue("@nombre_medico", medico.nombre_medico);
                cmd.Parameters.AddWithValue("@apellido_medico", medico.apellido_medico);
                cmd.Parameters.AddWithValue("@especialidad", medico.especialidad);
                cmd.Parameters.AddWithValue("@email_medico", medico.email_medico);
                cmd.Parameters.AddWithValue("@tel_medico", medico.tel_medico);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarMedico(CEMedico medico)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Actualizar_Medico", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ced_medico", medico.ced_medico);
                cmd.Parameters.AddWithValue("@nombre_medico", medico.nombre_medico);
                cmd.Parameters.AddWithValue("@apellido_medico", medico.apellido_medico);
                cmd.Parameters.AddWithValue("@especialidad", medico.especialidad);
                cmd.Parameters.AddWithValue("@email_medico", medico.email_medico);
                cmd.Parameters.AddWithValue("@tel_medico", medico.tel_medico);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarMedico(string cedMedico)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Eliminar_Medico", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ced_medico", cedMedico);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable VerMedicos()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Ver_Medico", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public DataTable FiltrarCitasPorMedico(string cedMedico, string nombreMedico)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Filtrar_Citas_Medico", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Si no se pasa parámetro, enviamos DBNull
                cmd.Parameters.AddWithValue("@ced_medico", string.IsNullOrEmpty(cedMedico) ? (object)DBNull.Value : cedMedico);
                cmd.Parameters.AddWithValue("@nombre_medico", string.IsNullOrEmpty(nombreMedico) ? (object)DBNull.Value : nombreMedico);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }

}
