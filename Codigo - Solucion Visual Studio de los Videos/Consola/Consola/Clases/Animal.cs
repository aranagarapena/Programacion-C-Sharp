using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Clases
{
    abstract class Animal
    {
        public abstract string sonidoAnimal();
    }

    class Perro : Animal
    {
        public override string sonidoAnimal()
        {
            return "Guau-guau";
        }
    }

    class Pajaro : Animal
    {
        public override string sonidoAnimal()
        {
            return "pio-pio";
        }
    }
}
