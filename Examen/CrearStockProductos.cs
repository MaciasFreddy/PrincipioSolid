using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class CrearStockProductos
    {
        public CrearStockProductos()
        {
            StockProductos = new List<Producto>();
        }

        public List<Producto> StockProductos { get; set; }

        public void GeneraProductos()
        {
            for (int i = 1; i <= 10; i++)
            {
                Producto producto = new Producto();
                producto.Codigo = i;
                Random random = new Random();
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "Producto " + letra;
                producto.Precio = Decimal.Parse(random.Next(200).ToString());
                StockProductos.Add(producto);
            }
        }

        public void ImprimirListaProductos()
        {
            Console.WriteLine("PRODUCTOS EN LA TIENDA");
            Console.WriteLine("{0}\t{1}\t\t{2}", "CODIGO", "DETALLE", "PRECIO");
            foreach (var item in StockProductos)
            {
                Console.WriteLine("{0}\t{1}\t{2}", item.Codigo, item.Descripcion, item.Precio);
            }
        }
    }

}


