using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEjemplo.Entidades
{
    public class MaterialDiscografico
    {
        public string nombre { get; set; }
        public double precio { get; set; }

        public int stock { get; set; }
        public Genero genero { get; set; }

        public Autor autor { get; set; }
        public List<Cancion> canciones { get; set; }


        //creamos los constructores para este objeto 

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

    

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public Autor Autor
        {
            get { return autor; }
            set { autor = value; }
        }

      

        public List<Cancion> Canciones
        {
            get { return canciones; }
            set { canciones = value; }
        }

        //mostrar datos en consola
        public string datosCanciones()
        {
            int numeroDeCancion = 1;
            String datos = "\nCANCIONES";

            foreach (Cancion cancion in canciones)
            {
                datos +=
                    "\nNº " + numeroDeCancion.ToString() +
                    "\nNombre: " + cancion.NombreCancion +

                numeroDeCancion++;
            }

            return datos;
        }

        public String reportarDatos()
        {
            return "REPORTE DE MATERIAL" +
                   "\nNombre: " + nombre +
            "\nPrecio: " + precio +
                   "\nStock: " + stock +
                   "\n--------------------" +
                   "\nAUTOR" +
                   "\nNombre: " + autor.NombreArtista +
                   "\nDescripcion: " + autor.DescripcionArtista +
                   "\n--------------------" +
                   "\nGENERO" +
                   "\nNombre: " + genero.DescripcionGenero +
                   "\n--------------------" +
                   datosCanciones();
        }

    }
}
