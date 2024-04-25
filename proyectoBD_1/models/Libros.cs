using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBD_1.models
{
    class Libros
    {
        private int idLibro;
        private string titulo;
        private string portada;
        private string isbn;
        private int ejemplar;
        private int idEditorialL;
        private int idCategoriaL;

        public int IdLibro { get => idLibro; set => idLibro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Portada { get => portada; set => portada = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Ejemplar { get => ejemplar; set => ejemplar = value; }
        public int IdEditorialL { get => idEditorialL; set => idEditorialL = value; }
        public int IdCategoriaL { get => idCategoriaL; set => idCategoriaL = value; }

        public Libros(int idLibro, string titulo, string portada, string isbn, int ejemplar, int idEditorialL, int idCategoriaL)
        {
            this.idLibro = idLibro;
            this.titulo = titulo;
            this.portada = portada;
            this.isbn = isbn;
            this.ejemplar = ejemplar;
            this.idEditorialL = idEditorialL;
            this.idCategoriaL = idCategoriaL;
        }

        public Libros()
        {
        }
    }
}
