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
    public class CNTratamiento
    {
        private CDTratamiento cdTratamiento = new CDTratamiento();

        public string AgregarTratamiento(CETratamiento t)
        {
            if (string.IsNullOrWhiteSpace(t.NombreTratamiento) ||
                string.IsNullOrWhiteSpace(t.Descripcion) ||
                t.Costo <= 0)
            {
                return "Todos los campos son obligatorios y el costo debe ser mayor a 0.";
            }

            cdTratamiento.AgregarTratamiento(t);
            return "Tratamiento agregado correctamente.";
        }

        public string ActualizarTratamiento(CETratamiento t)
        {
            if (t.IdTratamiento <= 0)
                return "Debe indicar el ID del tratamiento.";

            cdTratamiento.ActualizarTratamiento(t);
            return "Tratamiento actualizado correctamente.";
        }

        public string EliminarTratamiento(int idTratamiento)
        {
            if (idTratamiento <= 0)
                return "Debe indicar el ID del tratamiento.";

            cdTratamiento.EliminarTratamiento(idTratamiento);
            return "Tratamiento eliminado correctamente.";
        }

        public DataTable VerTratamientos()
        {
            return cdTratamiento.VerTratamientos();
        }
        public DataTable FiltrarTratamientos(int? idTratamiento, string nombreTratamiento)
        {
            return cdTratamiento.FiltrarTratamientos(idTratamiento, nombreTratamiento);
        }

    }
}
