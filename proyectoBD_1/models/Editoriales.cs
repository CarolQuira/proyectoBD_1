using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBD_1.models
{
    class Editoriales
    {
        private int idEditorial;
        private string nombreEditorial;

        public int IdEditorial { get => idEditorial; set => idEditorial = value; }
        public string NombreEditorial { get => nombreEditorial; set => nombreEditorial = value; }

        public Editoriales(int idEditorial, string nombreEditorial)
        {
            this.idEditorial = idEditorial;
            this.nombreEditorial = nombreEditorial;
        }

        public Editoriales()
        {
        }
    }
}
