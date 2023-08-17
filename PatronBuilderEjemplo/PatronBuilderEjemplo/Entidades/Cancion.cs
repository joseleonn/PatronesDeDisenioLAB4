using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEjemplo.Entidades
{
    public class Cancion
    {
        private string nombreCancion;

        //creamos los constructores para estos objetos
        public Cancion(string nombreCancion)
        {
            this.nombreCancion = nombreCancion;
        }
        

        //funcion para mostrarlos en consola
        public string NombreCancion
        {
            get { return nombreCancion; }
            set { nombreCancion = value; }
        }

    }
}
