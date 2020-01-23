using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface IAlmacenar
    {
        /*
        Aqui se aplica el QUINTO principio de SOLID (PRINCIPIO DE INVERSION DE DEPENDENCIAS) se Crea la 
        Interfaz (IAlmacenar) y se hereda a la clase (GuardarCompra).
        Este principio dice que para asignarle comportamientos a un modulo se debe hacer mediante dependencias
        una de ellas es mediante constructor o mediante setters(funcion que asigna un valor)
        */

        public void Save(Carrito carrito);  //Este es un Metodo que almacena.
    }
}
