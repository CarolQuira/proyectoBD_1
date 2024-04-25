using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBD_1.models
{
    class LibroAutor
    {
        private int idLibro_Autor;
        private int idLibroL;
        private int idAutorL;

        public int IdLibro_Autor { get => idLibro_Autor; set => idLibro_Autor = value; }
        public int IdLibroL { get => idLibroL; set => idLibroL = value; }
        public int IdAutorL { get => idAutorL; set => idAutorL = value; }

        public LibroAutor(int idLibro_Autor, int idLibroL, int idAutorL)
        {
            this.idLibro_Autor = idLibro_Autor;
            this.idLibroL = idLibroL;
            this.idAutorL = idAutorL;
        }

        public LibroAutor()
        {
        }
    }
}
