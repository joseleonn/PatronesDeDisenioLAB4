using PatronBuilderEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEjemplo.Builder
{
    public class MaterialDiscograficoBuilder : IMaterialdDiscograficoBuilder
    {
        //en la implementacion de la interfaz, debera tener los atributos de la clase que se le esta aplicando el patron builder

        private string nombre;
        private double precio;
        private int stock;
        private Genero genero;
        private Autor autor;
        private List<Cancion> canciones;



        //Ademas tiene como implementacion metodos que Settean los atributos de la clase a ser creada y a su vez retornan los atributos modificados


        public MaterialDiscograficoBuilder conNombre(string nombre)
        {
            this.nombre = nombre;   
            return this;
        }

        public MaterialDiscograficoBuilder TienePrecio(double precio)
        {
            this.precio = precio;
            return this;
        }

        public MaterialDiscograficoBuilder EnStock(int stock)
        {
            this.stock = stock;
            return this;
        }

        public MaterialDiscograficoBuilder ComoGenero(Genero genero)
        {
            this.genero = genero;
            return this;
        }

        public MaterialDiscograficoBuilder ComoAutor(Autor autor)
        {
            this.autor = autor;
            return this;
        }

        public MaterialDiscograficoBuilder ComoCanciones(List<Cancion> canciones)
        {
            this.canciones = canciones;
            return this;
        }

        public MaterialDiscografico BuildMaterialDiscografico()
        {


            //Luego de obtener todos los atributos de MaterialDiscografico gracias a los methodos instanciados en el builder. se crea el objeto con los datos ingresados
            return new MaterialDiscografico()
            {

                Nombre = this.nombre,
                Precio = this.precio,
                Stock = this.stock,
                Genero = this.genero,
                Autor = this.autor,
                Canciones = this.canciones

            };
        }
    }
}
