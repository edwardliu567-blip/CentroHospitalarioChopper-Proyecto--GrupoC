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
    public class CNMenu
    {
        CDMenu cdMenu = new CDMenu();
        public int ObtenerTotalMedicos() => cdMenu.ContarMedicos();
        public int ObtenerTotalPacientes() => cdMenu.ContarPacientes();
        public int ObtenerTotalCitasHoy() => cdMenu.ContarCitasHoy();
        public DataTable VerMedicos()
        {
            return cdMenu.VerMedicos();
        }
        public DataTable VerCitasHoyYManana()
        {
            return cdMenu.VerCitasHoyYManana();
        }
    }
}
