using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class ClientesSinReistro : Cliente, ICliente, IDescuentoCSR
    {
        // Aqui se esta implementando la interfaz ICliente
        int ICliente.Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Total { get; set; }
        Carrito carrito = new Carrito();
        public decimal CalcularTotal()
        {
            Total = (carrito.SubTotal2 + carrito.Iva);
            return Total;
        }


        /*TERCER PRINCIPIO DE SOLID  SUSTITUCION DE LISKOV
           EL DESCUENTO VARIA SEGUN EL CASO DEL CLIENTE
       */
        // Aqui se esta implementando la interfaz IDescuentoCSR
        public decimal Descuento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public decimal CalcularDescuento()
        {
            if (carrito.SubTotal > 100)
            {
                this.Descuento = carrito.SubTotal * 0.05M;
            }
            else
            {
                this.Descuento = 0;
            }
            return carrito.Descuento;
        }

    }
}
