using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Clases
{
    /// <summary>
    /// Esta es la clase coche
    /// </summary>
    public class Coche
    {
        #region Atributos

        /// <summary>
        /// Atributo que define el modelo del coche
        /// </summary>
        private string modeloCoche;

        


        #endregion

        #region Constructor

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="modeloCoche">Modelo del coche</param>
        public Coche(string modeloCoche)
        {
            this.modeloCoche = modeloCoche;
        }

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Coche()
        {
            this.modeloCoche = string.Empty;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad para modificar o acceder al valor del modelo del coche
        /// </summary>
        public string ModeloCoche { get => modeloCoche; set => modeloCoche = value; }


        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que devuelve la velocidad a la que circula el coche
        /// </summary>
        /// <returns>Velocidad del coche</returns>
        public double VelocidadCoche() {

            return CalcularVelocidad(3.5, 6.7);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        private double CalcularVelocidad(double v1, double v2)
        {
            return v1 * v2; ;
        }


        #endregion

        #region Eventos




        #endregion

    }
}
