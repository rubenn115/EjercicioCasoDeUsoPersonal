//Alumno: Ruben Bernal Ramos
//Clase: CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCasoDeUsoPersonal.servicios
{
    /// <summary>
    /// Esta es la interfaz donde estarán los métodos enunciados
    /// rbr - 031023
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Llamada al método que mostrará el menú por consola
        /// rbr - 031023
        /// </summary>
        public int mostrarMenu();

        /// <summary>
        /// Llamada al método que mostrará por consola el mensaje de bienvenida
        /// rbr - 031023
        /// </summary>
        public void mostrarMensajeBienvenida();
    }
}
