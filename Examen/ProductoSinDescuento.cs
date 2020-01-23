using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class ProductoSinDescuento : Producto
    {


        public DateTime FechaInicioDescuento { get; set; }

        //Se sobre escribe el metodo calcular descuento
        // y se implementa una funcionalidad en la clase hija
        public  decimal CalcularDescuento()
        {
            return 100;
        }

    }
}

