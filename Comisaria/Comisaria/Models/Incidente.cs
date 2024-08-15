using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaria.Models
{
    internal class Incidente
    {
        public string Motivo
        {
            get; private set;
        }
        public int Hora
        {
            get;private set;
        }
        public int Minuto
        {
            get; private set;
        }
        public int TipoIncidente
        {
            get; private set;
        }
        public Persona Sujeto
        {
            get; private set;
        }
        public Policia OficialACargo 
        {
            get; private set; 
        }
        public Incidente(Policia oficial, Persona sujeto, int tipoIncidente)
        {
            TipoIncidente = tipoIncidente;
            Sujeto = sujeto;
            OficialACargo = oficial;
        }
    }
}
