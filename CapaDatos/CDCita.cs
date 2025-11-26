using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCita
    {
        private readonly string conexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CHChopper;Integrated Security=True";

        public void AgregarCita(CECita cita)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Agregar_Cita", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_cita", cita.FechaCita);
                cmd.Parameters.AddWithValue("@hora_cita", cita.HoraCita);
                cmd.Parameters.AddWithValue("@estado_cita", cita.EstadoCita);
                cmd.Parameters.AddWithValue("@motivo_cita", cita.MotivoCita);
                cmd.Parameters.AddWithValue("@ced_medico", cita.CedMedico);
                cmd.Parameters.AddWithValue("@ced_paciente", cita.CedPaciente);
                cmd.Parameters.AddWithValue("@id_clinica", cita.IdClinica);
                cmd.Parameters.AddWithValue("@id_tratamiento", cita.IdTratamiento);
                cmd.Parameters.AddWithValue("@id_admin", cita.IdAdmin);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarCita(CECita cita)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Actualizar_Cita", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cita", cita.IdCita);
                cmd.Parameters.AddWithValue("@fecha_cita", cita.FechaCita);
                cmd.Parameters.AddWithValue("@hora_cita", cita.HoraCita);
                cmd.Parameters.AddWithValue("@estado_cita", cita.EstadoCita);
                cmd.Parameters.AddWithValue("@motivo_cita", cita.MotivoCita);
                cmd.Parameters.AddWithValue("@ced_medico", cita.CedMedico);
                cmd.Parameters.AddWithValue("@ced_paciente", cita.CedPaciente);
                cmd.Parameters.AddWithValue("@id_clinica", cita.IdClinica);
                cmd.Parameters.AddWithValue("@id_tratamiento", cita.IdTratamiento);
                cmd.Parameters.AddWithValue("@id_admin", cita.IdAdmin);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCita(int idCita)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Eliminar_Cita", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cita", idCita);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable VerCitas()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Ver_Cita", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable FiltrarCitas(DateTime? fechaInicio, DateTime? fechaFinal, string nombrePaciente, string cedulaPaciente)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Filtrar_Citas", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio.HasValue ? (object)fechaInicio.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@fecha_final", fechaFinal.HasValue ? (object)fechaFinal.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@nombre_paciente", string.IsNullOrEmpty(nombrePaciente) ? (object)DBNull.Value : nombrePaciente);
                cmd.Parameters.AddWithValue("@cedula_paciente", string.IsNullOrEmpty(cedulaPaciente) ? (object)DBNull.Value : cedulaPaciente);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void ActualizarEstadoCita(int idCita, string nuevoEstado)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_ActualizarEstadoCita", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cita", idCita);
                cmd.Parameters.AddWithValue("@nuevo_estado", nuevoEstado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable VerCitasMenu()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_Ver_Cita_Menu", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}