using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CECita
    {
        public int IdCita { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public string EstadoCita { get; set; }
        public string MotivoCita { get; set; }

        public string CedMedico { get; set; }
        public string CedPaciente { get; set; }
        public int IdClinica { get; set; }
        public int IdTratamiento { get; set; }
        public string IdAdmin { get; set; }

        public CEMedico Medico { get; set; }
        public CEPaciente Paciente { get; set; }
        public CEClinica Clinica { get; set; }
        public CETratamiento Tratamiento { get; set; }
        public CEAdministrador Administrador { get; set; }
    }
}
