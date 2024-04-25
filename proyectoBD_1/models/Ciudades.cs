using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace proyectoBD_1.models
{
    class Ciudades()
	{
        private int idCiudad;
        private string nombreCiudad;
        private int idPaisC;

        public Ciudades(int idCiudad, string nombreCiudad, int idPaisC)
        {
            this.idCiudad = idCiudad;
            this.nombreCiudad = nombreCiudad;   
            this.idPaisC = idPaisC;
        }

        public Ciudades()
        {

        }

    }
}
