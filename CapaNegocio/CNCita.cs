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
    public class CNCita
    {
        private CDCita cdCita = new CDCita();

        public string ActualizarCita(CECita cita)
        {
            // Validaciones de negocio
            if (cita.IdCita <= 0)
                return "Debe indicar un ID de cita válido.";

            if (string.IsNullOrWhiteSpace(cita.MotivoCita))
                return "Debe ingresar el motivo de la cita.";

            if (string.IsNullOrWhiteSpace(cita.CedMedico))
                return "Debe seleccionar un médico.";

            if (string.IsNullOrWhiteSpace(cita.CedPaciente))
                return "Debe ingresar la cédula del paciente.";

            if (cita.IdClinica <= 0)
                return "Debe seleccionar una clínica.";

            if (cita.IdTratamiento <= 0)
                return "Debe seleccionar un tratamiento.";

            if (string.IsNullOrWhiteSpace(cita.IdAdmin))
                return "Debe seleccionar un administrador.";
            if (cita.FechaCita < DateTime.Today)
                return "La fecha de la cita no puede ser anterior a la fecha de hoy.";


            cdCita.ActualizarCita(cita);
            return "La cita fue actualizada correctamente.";
        }

        public string AgregarCita(CECita cita)
        {
            // Validaciones similares para agregar
            if (string.IsNullOrWhiteSpace(cita.MotivoCita))
                return "Debe ingresar el motivo de la cita.";

            if (string.IsNullOrWhiteSpace(cita.CedMedico))
                return "Debe seleccionar un médico.";

            if (string.IsNullOrWhiteSpace(cita.CedPaciente))
                return "Debe ingresar la cédula del paciente.";

            if (cita.IdClinica <= 0)
                return "Debe seleccionar una clínica.";

            if (cita.IdTratamiento <= 0)
                return "Debe seleccionar un tratamiento.";

            if (string.IsNullOrWhiteSpace(cita.IdAdmin))
                return "Debe seleccionar un administrador.";
            if (cita.FechaCita < DateTime.Today)
                return "La fecha de la cita no puede ser anterior a la fecha de hoy.";
            cdCita.AgregarCita(cita);
            return "La cita fue registrada correctamente.";
        }


        public string EliminarCita(int idCita)
        {
            if (idCita <= 0)
                return "Debe indicar el ID de la cita.";

            DataTable dt = cdCita.VerCitas();
            bool existe = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["id_cita"].ToString() == idCita.ToString())
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
                return "No existe una cita con ese ID.";

            cdCita.EliminarCita(idCita);
            return "Cita eliminada correctamente.";
        }

        public DataTable VerCitas()
        {
            return cdCita.VerCitas();
        }
        public DataTable FiltrarCitas(DateTime? fechaInicio, DateTime? fechaFinal, string nombrePaciente, string cedulaPaciente)
        {
            return cdCita.FiltrarCitas(fechaInicio, fechaFinal, nombrePaciente, cedulaPaciente);
        }
        public void ActualizarEstadoCita(int idCita, string nuevoEstado)
        {
            cdCita.ActualizarEstadoCita(idCita, nuevoEstado);
        }



    }

}
