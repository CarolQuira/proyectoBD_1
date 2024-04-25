using System;

namespace proyectoBD_1.models
{
    class Multas 
    {
        private int idMulta_Pagada;
        private bool pagada;
        private double valorMulta;
        private string fechaPago;
        private int idLectorMs; //FOREING KEY


        public int IdMulta_Pagada { get => idMulta_Pagada; set => idMulta_Pagada = value; }
        public bool Pagada { get => pagada; set => pagada = value; }
        public double ValorMulta { get => valorMulta; set => valorMulta = value; }
        public string FechaPago { get => fechaPago; set => fechaPago = value; }
        public int IdLectorMs { get => idLectorMs; set => idLectorMs = value; }

        
        //constructor completo
        public Multas(int idMulta_Pagada, bool pagada, double valorMulta, string fechaPago, int idLectorMs)
        {
            this.idMulta_Pagada = idMulta_Pagada;
            this.pagada = pagada;
            this.valorMulta = valorMulta;
            this.fechaPago = fechaPago;
            this.idLectorMs = idLectorMs;
        }

        //constructor Vacío
        public Multas()
        {
        }
    }
}