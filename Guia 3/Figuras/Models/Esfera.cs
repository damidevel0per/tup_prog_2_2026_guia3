using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Models
{
    internal class Esfera : IFigura, IVolumetrica
    {
        public double Radio { get; set; }

        public Esfera(double radio)
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            return 4 * Math.PI * (Math.Pow(Radio,2));
        }

        public double CalcularVolumen()
        {
            return (4 * Math.PI * Math.Pow(Radio, 3)) / 3;
        }

        public override string ToString()
        {
            return $"Cilindro: Radio: {Radio:F2}, Area: {CalcularArea():F2}, Volumen: {CalcularVolumen():F2}";
        }


    }
}
