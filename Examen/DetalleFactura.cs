using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class DetalleFactura
    {
        public DetalleFactura()
        {
        }
        public Producto ProductoCarrito { get; set; }
        public int Cantidad { get; set; }

        /*
       Aqui en el QUINTO principio de SOLID (PRINCIPIO DE INVERSION DE DEPENDENCIAS) se invierten
       las Dependencias para que los objetos pasen por un constructor y la clase sera de forma aislada
       es decir que el codigo se organizara de manera distinta.
       */
        private IAlmacenar interface2;

        public void Comprar(Carrito carrito)
        {
            GuardarCompra gc = new GuardarCompra();
            gc.Save(carrito);
        }
        public DetalleFactura(IAlmacenar interface2)
        {
            this.interface2 = interface2;
        }
        public void Compra(Carrito carrito)
        {
            this.interface2.Save(carrito);
        }

    }
}
