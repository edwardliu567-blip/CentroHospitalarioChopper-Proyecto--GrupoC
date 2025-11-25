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
    public class CDClinica
    {
        private SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CHChopper;Integrated Security=True");

        public void AgregarClinica(CEClinica clinica)
        {
            SqlCommand cmd = new SqlCommand("sp_Agregar_Clinica", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_clinica", clinica.NombreClinica);
            cmd.Parameters.AddWithValue("@direccion", clinica.Direccion);
            cmd.Parameters.AddWithValue("@telefono", clinica.Telefono);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void ActualizarClinica(CEClinica clinica)
        {
            SqlCommand cmd = new SqlCommand("sp_Actualizar_Clinica", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_clinica", clinica.IdClinica);
            cmd.Parameters.AddWithValue("@nombre_clinica", clinica.NombreClinica);
            cmd.Parameters.AddWithValue("@direccion", clinica.Direccion);
            cmd.Parameters.AddWithValue("@telefono", clinica.Telefono);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void EliminarClinica(int idClinica)
        {
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Clinica", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_clinica", idClinica);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable VerClinicas()
        {
            SqlCommand cmd = new SqlCommand("sp_Ver_Clinica", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable FiltrarClinicas(string nombreClinica, int? idClinica)
        {
            SqlCommand cmd = new SqlCommand("sp_Filtrar_Clinicas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_clinica", idClinica.HasValue ? (object)idClinica.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@nombre_clinica", string.IsNullOrEmpty(nombreClinica) ? (object)DBNull.Value : nombreClinica);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

}
