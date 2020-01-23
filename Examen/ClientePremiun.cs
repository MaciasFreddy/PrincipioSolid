using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class ClientePremiun : Cliente, ICliente
    {
        public decimal Total { get; set; }
        int ICliente.Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Aqui se esta implementando la interfaz ICliente
        /*
        Aqui esta aplicado el  CUARTO principio de SOLID (principio de Segregacion De Interfaces) 
        porque se esta heredando de la Interfaz (ICliente)
        */
        Carrito carrito = new Carrito();

        public decimal CalcularTotal()
        {
            this.Total = (carrito.SubTotal2 + carrito.Iva);
            return Total;
        }
    }
}

