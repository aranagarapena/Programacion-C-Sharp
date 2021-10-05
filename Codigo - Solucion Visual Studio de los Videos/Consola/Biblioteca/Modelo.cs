using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Modelo
    {
        private string modeloCoche;

        internal Modelo(string modeloCoche)
        {
            this.modeloCoche = modeloCoche;
        }

        internal Modelo()
        {
            this.modeloCoche = "Audi";
        }

        internal string ModeloCoche { get => modeloCoche; set => modeloCoche = value; }
    }
}
