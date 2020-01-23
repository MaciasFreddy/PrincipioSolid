using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Impresora
    {

        public Impresora()
        {
            ListaClientes = new List<Cliente>();
        }


        public List<Cliente> ListaClientes { get; set; }

        /*Aqui se esta aplicando el PRIMER  Principio de SOLID (Principio de Responsabilidad Unica) 
         en donde se realiza una sola cosa en este caso se esta imprimiendo detalladamente la 
         informacion del cliente.
         */

        public void ImprimirlistadoCliente()
        {
            Console.WriteLine("Lista de cliente");
            Console.WriteLine("Nombre\tApellido\tCedula\tEmail\tContraseña\tCiudad \tFecha A");
            foreach (var item in this.ListaClientes)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t{6}",
                item.Nombres, item.Apellido, item.NumeroCedula, item.Email, item.Contrasenia, item.CiudadDeFacturacion, item.FechaActual);
            }
        }
    }
}
