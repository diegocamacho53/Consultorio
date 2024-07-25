using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        // Otras propiedades según sea necesario

        public override string ToString()
        {
            // Sobrescribe el método ToString para mostrar la hora de la cita en el ComboBox
            return HoraCita.ToString();
        }
    }
}
