using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AportacionesIMSS
    {
        public AportacionesIMSS() { }

        public AportacionesIMSS(decimal EnfermedadMaternidad, decimal InvalidezVida, decimal Retiro, decimal Cesantía, decimal Infonavit)
        {
            this.EnfermedadMaternidad = EnfermedadMaternidad;
            this.InvalidezVida = InvalidezVida;
            this.Retiro = Retiro;
            this.Cesantía = Cesantía;
            this.Infonavit = Infonavit;
        }

        public decimal EnfermedadMaternidad { get; set; }
        public decimal InvalidezVida { get; set; }
        public decimal Retiro { get; set; }
        public decimal Cesantía { get; set; }
        public decimal Infonavit { get; set; }
       
        }
}
