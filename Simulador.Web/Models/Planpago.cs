using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simulador.Web.Models
{
    public class Planpago
    {
        private int NroCuota { get; set; }
        private double AbonoIntereses { get; set; }
        private double AbonoCapital { get; set; }
        private double CuotaMensual { get; set; }
        private double Saldo { get; set; }

        public Planpago() { }

        public Planpago(int NroCuota, double AbonoIntereses, double AbonoCapital, double CuotaMensual, double Saldo)
        {
            this.NroCuota = NroCuota;
            this.AbonoIntereses = AbonoIntereses;
            this.AbonoCapital = AbonoCapital;
            this.CuotaMensual = CuotaMensual;
            this.Saldo = Saldo;
        }


    }
}