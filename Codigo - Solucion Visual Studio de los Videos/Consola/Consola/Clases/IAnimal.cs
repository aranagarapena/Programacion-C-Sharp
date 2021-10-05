using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Clases
{
    interface IAnimal
    {
        string sonidoAnimal();

        string correr();
    }

    public class Gato : IAnimal
    {
        public string correr()
        {
            return "Gato corriendo";
        }

        public string sonidoAnimal()
        {
            return "miau-miau"; ;
        }
    }

}
