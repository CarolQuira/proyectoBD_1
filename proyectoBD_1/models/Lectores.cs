using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBD_1.models
{
    class Lectores
    {

        private int idLector;
        private string nombreL1;
        private string nombreL2;
        private string apellidoL1;
        private string apellidoL2;
        private string telefonoL1;
        private string telefonoL2;
        private string telefonoL3;
        private string direccionResidencia;
        private string fotoLector;
        private string fechaNacimiento;
        private string contrasena;

        public int IdLector { get => idLector; set => idLector = value; }
        public string NombreL1 { get => nombreL1; set => nombreL1 = value; }
        public string NombreL2 { get => nombreL2; set => nombreL2 = value; }
        public string ApellidoL1 { get => apellidoL1; set => apellidoL1 = value; }
        public string ApellidoL2 { get => apellidoL2; set => apellidoL2 = value; }
        public string TelefonoL1 { get => telefonoL1; set => telefonoL1 = value; }
        public string TelefonoL2 { get => telefonoL2; set => telefonoL2 = value; }
        public string TelefonoL3 { get => telefonoL3; set => telefonoL3 = value; }
        public string DireccionResidencia { get => direccionResidencia; set => direccionResidencia = value; }
        public string FotoLector { get => fotoLector; set => fotoLector = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        public Lectores(int idLector, string nombreL1, string nombreL2, string apellidoL1, string apellidoL2, string telefonoL1, string telefonoL2, string telefonoL3, string direccionResidencia, string fotoLector, string fechaNacimiento, string contrasena)
        {
            this.idLector = idLector;
            this.nombreL1 = nombreL1;
            this.nombreL2 = nombreL2;
            this.apellidoL1 = apellidoL1;
            this.apellidoL2 = apellidoL2;
            this.telefonoL1 = telefonoL1;
            this.telefonoL2 = telefonoL2;
            this.telefonoL3 = telefonoL3;
            this.direccionResidencia = direccionResidencia;
            this.fotoLector = fotoLector;
            this.fechaNacimiento = fechaNacimiento;
            this.contrasena = contrasena;
        }

        public Lectores()
        {
        }

        public Lectores(string nombreL1)
        {
            this.nombreL1 = nombreL1;
        }

        public Lectores(int idLector, string nombreL1)
        {
            this.idLector = idLector;
            this.nombreL1 = nombreL1;
        }
    }
}
