using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Models
{
    internal class Rectangulo : ISuperficie, IFigura
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Rectangulo(double ancho, double largo)
        {
            Ancho = ancho;
            Largo = largo;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        public double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override string ToString()
        {
            return $"Rectangulo: Ancho: {Ancho:F2}, Largo: {Largo:F2}, Area: {CalcularArea():F2}, Perimetro: {CalcularPerimetro():F2}";
        }
    }
}
