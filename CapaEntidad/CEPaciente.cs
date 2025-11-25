namespace CapaEntidad
{
    public class CEPaciente
    {
        public string CedPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public string EmailPaciente { get; set; }
        public string TelefonoPaciente { get; set; }
        public string IdAdmin { get; set; }

        public CEAdministrador Administrador { get; set; }
    }
}
