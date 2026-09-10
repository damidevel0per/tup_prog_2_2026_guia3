using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peaje.Models
{
    internal class Fijo : Costo
    {
        public override double ValorFinal {get;}

        public Fijo(string concepto, double valorFinal) : base(concepto)
        {
            ValorFinal = valorFinal;
        }

        public override string VerDetalle()
        {
            return $"Tipo: Fijo - Concepto: {Concepto} - Valor final: ${ValorFinal}";
        }

    }
}
