using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peaje.Models
{
    internal class Envio
    {
        private List<Costo> costoLista = new List<Costo>();

        public double ValorTotal { get; }

        public string VerDetalle()
        { 
            string detalle = "";
            double total = 0;
            for (int i = 0; i < costoLista.Count; i++)
            {
                detalle += "\r\n" + costoLista[i].VerDetalle();
                total += costoLista[i].ValorFinal; 
            }
            detalle += "\r\n\r\n" + $"Total: ${total.ToString("0.00")} \r\n";
            return detalle;
        }

        public void AgregarCosto(Costo costo)
        {
            costoLista.Add(costo);
        }
    }
}
