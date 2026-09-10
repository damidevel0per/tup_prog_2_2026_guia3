using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peaje.Models
{
    internal class Variable : Costo
    {
        public double PrecioPorUnidad { get; }
        public double Unidades { get; }
        public override double ValorFinal { get; }

        public Variable(string concep, double unidades, double precioPorunid): base(concep)
        {
            PrecioPorUnidad = precioPorunid;
            Unidades = unidades;
            ValorFinal = precioPorunid * unidades;
        }

        public override string VerDetalle()
        {
            return $"Tipo: Variable - Concepto: {Concepto} - Precio por unidad: ${PrecioPorUnidad:f2} - Unidades: {Unidades} - Valor final: ${ValorFinal:f2}";
        }
    }
}
