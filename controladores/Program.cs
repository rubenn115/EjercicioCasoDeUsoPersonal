//Alumno: Ruben Bernal Ramos
//Clase: CSI1

using EjercicioCasoDeUsoPersonal.servicios;
using System.Dynamic;

namespace EjercicioCasoDeUsoPersonal.controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 031023
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// rbr - 031023
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Instancio la interfaz y el menu implementacion
            MenuInterfaz mi = new MenuImplementacion();

            //Llamo al metodo para mostrar el mensaje de bienvenida
            mi.mostrarMensajeBienvenida();

            //Declaro las variables
            bool cerrarMenu=false;
            int opcion;

            while (!cerrarMenu)
            {
                //Muestro el menu por consola
                opcion = mi.mostrarMenu();
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Has seleccionado la opcion de cerrar menu");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Has seleccionado la opcion para darse de alta");
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado la opcion para ingresar dinero");
                        break;
                    case 3:
                        Console.WriteLine("Has seleccionado la opcion 3");
                        break;
                    case 4:
                        Console.WriteLine("Has seleccionado la opcion 4");
                        break;
                    case 5:
                        Console.WriteLine("Has seleccionado la opcion 5");
                        break;
                    default:
                        Console.WriteLine("Has seleccionado la opcion default");
                        break;
                }
            }
        }
    }

}