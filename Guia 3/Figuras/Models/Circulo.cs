using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Models
{
    internal class Circulo : IFigura, ISuperficie
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double CalcularPerimetro()
        {
            return (Radio * 2) * Math.PI;
        }

        public override string ToString()
        {
            return $"Circulo: Radio: {Radio:F2}, Area: {CalcularArea():F2}, Volumen: {CalcularPerimetro():F2}";
        }
    }
}
