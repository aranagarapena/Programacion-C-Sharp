using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Coche
    {
        private Modelo modelo;

        public Coche()
        {
            this.modelo = new Modelo("Mustang");
        }

        public string DevolverModelo() {

            return this.modelo.ModeloCoche;
        }

    }
}
