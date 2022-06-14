using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemTablaISR
    {
        public ItemTablaISR() { }

        public ItemTablaISR(decimal LimiteInferior, decimal LimiteSuperior, decimal CuotaFija, decimal Excedente, decimal Subsidio, decimal ISR)
        {
            this.LimiteInferior = LimiteInferior;
            this.LimiteSuperior = LimiteSuperior;
            this.CuotaFija = CuotaFija;
            this.Excedente = Excedente;
            this.Subsidio = Subsidio;
            this.ISR = ISR;
        }

        public decimal LimiteInferior { get; set; }
        public decimal LimiteSuperior { get; set; }
        public decimal CuotaFija { get; set; }
        public decimal Excedente { get; set; }
        public decimal Subsidio { get; set; }
        public decimal ISR { get; set; }



    }
}
