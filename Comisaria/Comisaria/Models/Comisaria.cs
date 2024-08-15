using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaria.Models
{
    internal class Comisaria
    {
        ArrayList agentes = new ArrayList();
        Guardia[] guardias = new Guardia[2];
        ArrayList incidentes = new ArrayList();
        public int CantidadIncidentes { get; private set; }
        public bool AsignarPolicia(Policia policia)
        {
            if (agentes.Count < 2)
            {
                agentes.Add(agentes);
                return true;
            }
            return false;
        }
    }
}
