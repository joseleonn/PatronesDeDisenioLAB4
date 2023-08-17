using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEjemplo.Entidades
{
    public class Autor
    {
        private string nombreArtista;
        private string descripcionArtista;

        //creamos los constructores para estos objetos

        public Autor(string nombreArtista, string descripcionArtista)
        {
            this.nombreArtista = nombreArtista;
            this.descripcionArtista = descripcionArtista;
        }

        //funcion para mostrarlos en consola

        public string NombreArtista
        {
            get { return nombreArtista; }
            set { nombreArtista = value; }
        }
        public string DescripcionArtista
        {
            get { return descripcionArtista; }
            set { descripcionArtista = value; }
        }
    }
}
