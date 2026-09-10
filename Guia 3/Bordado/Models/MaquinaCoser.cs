using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordado.Models
{
    internal class MaquinaCoser
    {
        IMotivoBordado motivo;
        public MaquinaCoser(IMotivoBordado motivo)
        {
            this.motivo = motivo;
        }

        public void AgregarMotivo(IMotivoBordado mot)
        {
            this.motivo = mot;
        }

        public string[] DarPuntada()
        {
            char[][] patron = this.motivo.GetPatron();


            string[] bordado = new string[patron.GetLength(0)];

            for (int n = 0; n < patron.GetLength(0); n++)
            {
                bordado[n] = new string(patron[n]);
            }
            return bordado;
        }
    }
}
