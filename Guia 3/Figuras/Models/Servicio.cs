using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Models
{
    internal class Servicio
    {
        private ArrayList figuras = new ArrayList();

        public IFigura VerFigura(int idx)
        { 
        
            if (idx >= 0 && figuras.Count > 0)
            {
                return (IFigura)figuras[idx];
            }
            
            return null;
        }

        public int VerCantidad()
        {
            return figuras.Count;
        }

        public void AgregarFigura(IFigura figura)
        {
            figuras.Add(figura);
        }

        public void EliminarFigura(int idx)
        {
            if (idx >= 0 && figuras.Count < 0)
            {
                figuras.RemoveAt(idx);
            }
        }
    }
}
