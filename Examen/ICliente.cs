using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface ICliente
    {
        /*
        Aqui se aplica el Cuarto principio de SOLID (principio de Principio de Segregacion de Interfaces) 
        se Crea la Interfaz (ICliente) y se hereda a los diferentes tipos de clientes.      
        Es conveniente tener interfaces mas pequeñas porque ayuda a desacoplar modulos entre ello.
        
        */

        public int Total { get; set; }    //Este Metodo se comportara diferente en clases que implementen las interfaces
        // en este caso en cliente premium,cliente registrado,clientesinregistro.
        decimal CalcularTotal();   //Este es un Metodo POLIFORMICO  porque para todos los clientes se debe calcular.
    }
}
