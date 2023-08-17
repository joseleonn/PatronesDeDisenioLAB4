// See https://aka.ms/new-console-template for more information
using PatronBuilderEjemplo.Builder;
using PatronBuilderEjemplo.Entidades;

Console.WriteLine("Hello, World!");

int numeroDeCancion = 1;

// MATERIAL DISCOGRAFICO
string nombre;
double precio;
int stock;

// AUTOR
Autor autor;
string nombreArtista;
string descripcionArtista;

// GENERO
Genero genero;
string descripcionGenero;



// CANCIONES
List<Cancion> canciones = new List<Cancion>();
Cancion cancion;
string nombreCancion;

char respuesta;

// MATERIAL DISCOGRAFICO
Console.Write("Ingrese el nombre del nuevo material: ");
nombre = Console.ReadLine();
Console.Write("Ingrese el precio del nuevo material: ");
precio = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el stock del nuevo material: ");
stock = Convert.ToInt32(Console.ReadLine());

// AUTOR
Console.Write("Ingrese el nombre del artista: ");
nombreArtista = Console.ReadLine();
Console.Write("Ingrese descripcion del artista: ");
descripcionArtista = Console.ReadLine();
autor = new Autor(nombreArtista, descripcionArtista);

// GENERO
Console.Write("Ingrese el nombre del genero: ");
descripcionGenero = Console.ReadLine();
genero = new Genero(descripcionGenero);


do
{
    // CANCIONES
    Console.WriteLine("\nCancion " + numeroDeCancion.ToString());
    Console.Write("Ingrese el nombre de la canción: ");
    nombreCancion = Console.ReadLine();
    cancion = new Cancion(nombreCancion);
    canciones.Add(cancion);

    numeroDeCancion++;

    Console.Write("Desea seguir agregando canciones? (S/N): ");
    respuesta = Console.ReadKey().KeyChar;
    Console.ReadKey();

} while (respuesta == 'S');

Console.Clear();


// BUILDER MATERIAL DISCOGRAFICO
MaterialDiscograficoBuilder builderMaterialDiscografico = new MaterialDiscograficoBuilder();
MaterialDiscografico materialDiscografico = builderMaterialDiscografico
    .conNombre(nombre)
    .TienePrecio(precio)
    .EnStock(stock)
    .ComoAutor(autor)
    .ComoCanciones(canciones)
    .ComoGenero(genero)
    .BuildMaterialDiscografico();

// REPORTAR
Console.Write(materialDiscografico.reportarDatos());

Console.ReadKey();