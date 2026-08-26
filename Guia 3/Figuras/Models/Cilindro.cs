using System;

namespace Figuras.Models
{
    internal class Cilindro : IFigura, IVolumetrica
    {
        public double Radio { get; set; }
        public double Altura { get; set; }

        public Cilindro(double radio, double altura)
        {
            
            Radio = radio;
            Altura = altura;

        }

        public double CalcularArea()
        {
            return (2 * Math.PI * Math.Pow(Radio, 2)) + (2 * Math.PI * Radio * Altura);
        }

        public double CalcularVolumen()
        {
            return Math.PI * Math.Pow(Radio,2) * Altura;
        }
        public override string ToString()
        {
            return $"Cilindro: Radio: {Radio:F2}, Altura: {Altura:F2}, Area: {CalcularArea().ToString("0.00")}, Volumen: {CalcularVolumen().ToString("0.00")}";
        }

    }
}
