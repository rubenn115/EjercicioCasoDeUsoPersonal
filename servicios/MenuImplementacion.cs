//Alumno: Ruben Bernal Ramos
//Clase: CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCasoDeUsoPersonal.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método que mostrará el menú por consola
        /// rbr - 031023
        /// </summary>
        public int mostrarMenu()
        {
            int opcion;
            Console.WriteLine("###########################");
            Console.WriteLine("     MENU DEL MAZEBANK     ");
            Console.WriteLine("###########################");
            Console.WriteLine("0. Cerrar menú");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar Dinero");
            Console.WriteLine("###########################");
            Console.WriteLine("                           ");
            Console.WriteLine("Seleccione la opción que desee");

            opcion = Console.ReadKey(true).KeyChar - '0';
            return opcion;
        }

        /// <summary>
        /// Método que mostrará el mensaje de bienvenida por consola
        /// rbr - 031023
        /// </summary>
        public void mostrarMensajeBienvenida()
        {
            string mensajeBienvenida;
            mensajeBienvenida = "Bienvenido al menú principal del Mazebank Los Santos";
            Console.WriteLine(mensajeBienvenida);
        }
    }
}
