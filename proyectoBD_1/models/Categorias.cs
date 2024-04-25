using System;

namespace proyectoBD_1.models
{
    class Categorias
    {
        public int idCategoria;
        private string nombre;
        private string fechaCreacion;

        public int idCategoria { get => idCategoria; set => idCategoria = value; }
        public string nombre { get => nombre; set => nombre = value; }
        public string fechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}
