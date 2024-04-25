using System;

namespace proyectoBD_1.models
{
    class Prestamos
    {
        private int idPrestamo;
        private bool activo;
        private string fechaPrestamo;
        private string fechaVencimiento
        private int idLector; //FOREING KEY

        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public bool Activo { get => activo; set => activo = value; }
        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public int IdLector { get => idLector; set => idLector = value; }



        //constructor Completo
        public Prestamos(int idPrestamo, bool activo, string fechaPrestamo, string fechaVencimiento, int idLector)
        {
            this.idPrestamo = idPrestamo;
            this.activo = activo;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaVencimiento = fechaVencimiento;
            this.idLector = idLector;
        }

        //constructor Vacío
        public Prestamos()
        {
        }
    }
}
