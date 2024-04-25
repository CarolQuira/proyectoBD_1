using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBD_1.models
{
	class Paises()
	{
        private int idPais;
        private string nombrePais;

        public int IdPais { get => idPais; set => idPais = value;}
        public string NombrePais { get => nombrePais; set => nombrePais = value; }

        public Paises (int idPais, string nombrePais)
        {
            this.idPais = idPais;
            this.nombrePais = nombrePais;
        }
        public Paises()
        {

        }
    }
}
