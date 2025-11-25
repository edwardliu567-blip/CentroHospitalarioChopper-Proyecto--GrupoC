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

    public class CDPaciente
    {
        private SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CHChopper;Integrated Security=True");

        public void AgregarPaciente(CEPaciente paciente)
        {
            SqlCommand cmd = new SqlCommand("sp_Agregar_Paciente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ced_paciente", paciente.CedPaciente);
            cmd.Parameters.AddWithValue("@nombre_paciente", paciente.NombrePaciente);
            cmd.Parameters.AddWithValue("@apellido_paciente", paciente.ApellidoPaciente);
            cmd.Parameters.AddWithValue("@email_paciente", paciente.EmailPaciente);
            cmd.Parameters.AddWithValue("@telefono_paciente", paciente.TelefonoPaciente);
            cmd.Parameters.AddWithValue("@id_admin", paciente.IdAdmin);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void ActualizarPaciente(CEPaciente paciente)
        {
                SqlCommand cmd = new SqlCommand("sp_Actualizar_Paciente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ced_paciente", paciente.CedPaciente);
                cmd.Parameters.AddWithValue("@nombre_paciente", paciente.NombrePaciente);
                cmd.Parameters.AddWithValue("@apellido_paciente", paciente.ApellidoPaciente);
                cmd.Parameters.AddWithValue("@email_paciente", paciente.EmailPaciente);
                cmd.Parameters.AddWithValue("@telefono_paciente", paciente.TelefonoPaciente);
                cmd.Parameters.AddWithValue("@id_admin", paciente.IdAdmin);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
        }

        public void EliminarPaciente(string cedPaciente)
        {
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Paciente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ced_paciente", cedPaciente);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable VerPacientes()
        {
            SqlCommand cmd = new SqlCommand("sp_Ver_Paciente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable HistorialCitasPaciente(string cedPaciente, string NombrePaciente)
        {
            SqlCommand cmd = new SqlCommand("sp_Historial_Citas_Paciente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ced_paciente", string.IsNullOrEmpty(cedPaciente) ? (object)DBNull.Value : cedPaciente);
            cmd.Parameters.AddWithValue("@nombre_paciente", string.IsNullOrEmpty(NombrePaciente) ? (object)DBNull.Value : NombrePaciente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

    }
}
