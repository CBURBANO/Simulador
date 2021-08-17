using System;
using System.ComponentModel.DataAnnotations;

namespace Simulador.Web.Models
{
    public class Creditofor
    {

        [Display(Name = "abono")]
        public double abono = 0;

        [Display(Name = "abono")]
        public double abonoCapital = 0;

        [Display(Name = "abono")]
        public double saldo = 0;

        [Display(Name = "abono")]
        public int cuotaconSeguro = 0;





        [Display(Name = "ValorPrestamo")]
        public int ValorPrestamo { get; set; }


        [Display(Name = "Cuotas")]
        //Required campo requerido 
        [Required(ErrorMessage = "El campo Plazo es requerido.")]
        public int Cuotas { get; set; }


        // public Double CuotaTasa { get; set; }
        [Display(Name = "CuotaTasa")]
        public double CuotaTasa { get; set; }



        [Display(Name = "ValorSeguro")]
        public int ValorSeguro { get; set; }

    }


}