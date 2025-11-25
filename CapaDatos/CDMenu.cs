using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDMenu
    {
        private readonly string conexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CHChopper;Integrated Security=True";
        public int ContarMedicos()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_ContarMedicos", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int ContarPacientes()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_ContarPacientes", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int ContarCitasHoy()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_ContarCitasHoy", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                return (int)cmd.ExecuteScalar();
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
        public DataTable VerCitasHoyYManana()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand("sp_VerCitasHoyYManana", cn))
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
