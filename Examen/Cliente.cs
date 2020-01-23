using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public  abstract class Cliente 
    {
        public string NumeroCedula { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public string CiudadDeFacturacion { get; set; }
        public string FechaActual { get; set; }
    }
}


