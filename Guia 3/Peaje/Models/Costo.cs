using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peaje.Models
{
    abstract class Costo
    {
        public string Concepto {  get; }
        public virtual double ValorFinal {  get; }

        public Costo(string concep)
        {
            Concepto = concep;
        }
        public abstract string VerDetalle();

    }
}
