using PatronBuilderEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEjemplo.Builder
{
    public interface IMaterialdDiscograficoBuilder
    {
       //En esta intefaz vamos a declarar los metodos que funcionen como Setters para los atributos de la clase que se desea construir. en este caso es MaterialDiscografico

        MaterialDiscograficoBuilder conNombre(string nombre);
        MaterialDiscograficoBuilder TienePrecio(double precio);

        MaterialDiscograficoBuilder EnStock(int Stock);
        MaterialDiscograficoBuilder ComoGenero(Genero genero);

        MaterialDiscograficoBuilder ComoAutor(Autor autor);

        MaterialDiscograficoBuilder ComoCanciones(List<Cancion> canciones);

    }
}
