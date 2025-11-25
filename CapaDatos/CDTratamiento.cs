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
    public class CDTratamiento
    {
        private SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CHChopper;Integrated Security=True");

        public void AgregarTratamiento(CETratamiento t)
        {
            SqlCommand cmd = new SqlCommand("sp_Agregar_Tratamiento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_tratamiento", t.NombreTratamiento);
            cmd.Parameters.AddWithValue("@descripcion", t.Descripcion);
            cmd.Parameters.AddWithValue("@costo", t.Costo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void ActualizarTratamiento(CETratamiento t)
        {
            SqlCommand cmd = new SqlCommand("sp_Actualizar_Tratamiento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_tratamiento", t.IdTratamiento);
            cmd.Parameters.AddWithValue("@nombre_tratamiento", t.NombreTratamiento);
            cmd.Parameters.AddWithValue("@descripcion", t.Descripcion);
            cmd.Parameters.AddWithValue("@costo", t.Costo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void EliminarTratamiento(int idTratamiento)
        {
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Tratamiento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_tratamiento", idTratamiento);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable VerTratamientos()
        {
            SqlCommand cmd = new SqlCommand("sp_Ver_Tratamiento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable FiltrarTratamientos(int? idTratamiento, string nombreTratamiento)
        {
             SqlCommand cmd = new SqlCommand("sp_Filtrar_Tratamientos", cn);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@id_tratamiento", idTratamiento.HasValue ? (object)idTratamiento.Value : DBNull.Value);
             cmd.Parameters.AddWithValue("@nombre_tratamiento", string.IsNullOrEmpty(nombreTratamiento) ? (object)DBNull.Value : nombreTratamiento);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             return dt;
        }

    }

}
