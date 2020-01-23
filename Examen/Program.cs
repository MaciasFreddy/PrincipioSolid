using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesSinReistro clientesSinReistro = new ClientesSinReistro();
            clientesSinReistro.Nombres = "Freddy";
            clientesSinReistro.Apellido = "Macias";
            clientesSinReistro.NumeroCedula = "137256";
            clientesSinReistro.Email = "FM@.com";
            clientesSinReistro.Contrasenia = "00000000";
            clientesSinReistro.CiudadDeFacturacion = "Manta";
            clientesSinReistro.FechaActual = "31/12/2019";

            Impresora listadoClientes = new Impresora();
            listadoClientes.ListaClientes.Add(clientesSinReistro);
            listadoClientes.ImprimirlistadoCliente();

            CrearStockProductos crearStockProductos = new CrearStockProductos();
            crearStockProductos.GeneraProductos();
            crearStockProductos.ImprimirListaProductos();

            Carrito carrito = new Carrito();

            string opcion;
            do
            {
                Console.WriteLine("ingrese el codio de producto");
                int codio = int.Parse(Console.ReadLine());
                DetalleFactura detallecarrito = new DetalleFactura();
                detallecarrito.ProductoCarrito = crearStockProductos.StockProductos[codio - 1];
                Console.WriteLine("ingrese la cantidad de productos elegidos");
                detallecarrito.Cantidad = Convert.ToInt32(Console.ReadLine());
                carrito.Detalle.Add(detallecarrito);
                Console.WriteLine("escriba A para seguir agregando productos y S para salir");
                opcion = Console.ReadLine();
            } while (opcion != "S");


            listadoClientes.ImprimirlistadoCliente();
            Console.WriteLine("Productos En El Carrito De Compras");
            Console.WriteLine("Descripcion\t\tCantidad\tPrecio");

            foreach (var item in carrito.Detalle)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}",
                    item.ProductoCarrito.Codigo, item.ProductoCarrito.Descripcion, item.Cantidad, item.ProductoCarrito.Precio);
            }
            carrito.CalcularSubtotal();
            carrito.CalcularDescuento();
            carrito.CalcularSubtotal2();
            carrito.CalcularIva();
            carrito.CalcularTotal();

            Console.WriteLine("SUBTOTAL");
            Console.WriteLine(carrito.SubTotal);

            Console.WriteLine("DESCUENTO");
            Console.WriteLine(carrito.Descuento);

            Console.WriteLine("SUBTOTAL-DESCUENTO");
            Console.WriteLine(carrito.SubTotal2);

            Console.WriteLine("IVA");
            Console.WriteLine(carrito.Iva);

            Console.WriteLine("TOTAL");
            Console.WriteLine(carrito.Total);
        }
         
    }
}

