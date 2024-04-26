using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_1_parcial_2.clases_parcial_2
{
    internal class albumes_rock : tienda_de_discos
    {
        //public override string genero { get => base.genero; set => base.genero = "rock"; }

        private string genero = "rock";
        private string artista;
        private string discografica;
        
        public string artista_pub
        {
            get { return artista; }
            set { artista = value; }
        }

        public string discografica_pub
        {
            get { return discografica; }
            set { discografica = value; }
        }

        public override void mostrardatos()
        {
            
            Console.WriteLine("tipo de producto: album musical");
            Console.WriteLine($"album:{titulo_pub} ");
            Console.WriteLine($"artista: {artista_pub}");
            Console.WriteLine($"estudio discografico: {discografica_pub}");
            Console.WriteLine($"duracion: {duracion_pub / 60} min. {duracion_pub % 60} seg.");
            Console.WriteLine($"genero: {genero}");
        }

    }

    internal class peliculas : tienda_de_discos
    {
        private string director;
        private int anio;

        public int anio_pub
        {
            get { return anio; } set { anio = value; }
        }
        public string director_pub
        {
            get { return director; } set { director = value; }
        }

        public override void mostrardatos()
        {
            Console.WriteLine("tipo de producto: pelicula");
            Console.WriteLine($"pelicula: {titulo_pub}");
            Console.WriteLine($"director: {director_pub}");
            Console.WriteLine($"duracion: {duracion_pub / 60} min. {duracion_pub % 60} seg.");
            Console.WriteLine($"anio de estreno: {anio_pub}");
        }
    }
}
