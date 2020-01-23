using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface IDescuentoCSR
    { /*
        Aqui se aplica el Tercer Principio de SOLID (Principio de Sustitucion De Liskov)
        se Crea la Interfaz (IDescuentoCSR) y se hereda a ClienteSinRegistro (CSR) porque este cliente 
        se le debe realizar un descuento.
        Este principio dice que las clases hijas deben de comportarse igual que las clases padres
        porque son clases extendidas (modelado de clases) y el programa debe seguir siendo valido.
        */

        public decimal Descuento { get; set; }

        decimal CalcularDescuento();   //Este es un Metodo que se le debe realizar a ClienteSinRegistro
    }
}
