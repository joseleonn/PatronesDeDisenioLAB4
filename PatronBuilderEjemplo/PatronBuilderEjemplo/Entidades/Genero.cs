using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEjemplo.Entidades
{
    public class Genero
    {
  
            private string descripcionGenero;

        //creamos los constructores para estos objetos

        public Genero(string descripcionGenero)
            {
                this.descripcionGenero = descripcionGenero;
            }
        //funcion para mostrarlos en consola

        public string DescripcionGenero
            {
                get { return descripcionGenero; }
                set { descripcionGenero = value; }
            }
       
    }
}
