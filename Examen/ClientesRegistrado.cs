using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class ClientesRegistrado : Cliente, ICliente
    {
        /*
         Aqui esta aplicado el CUARTO principio de SOLID (principio de Segregacion De Interfaces) 
         porque se esta heredando de la Interfaz (ICliente)
        */
        // Aqui se esta implementando la interfaz ICliente
        int ICliente.Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Carrito carrito = new Carrito();
        public decimal Total { get; set; }
        public decimal CalcularTotal()
        {
            Total = (carrito.SubTotal2 + carrito.Iva);
            return Total;
        }
    }
}
