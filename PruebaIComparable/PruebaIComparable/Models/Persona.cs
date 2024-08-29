using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIComparable.Models
{
    internal class Persona : IComparable
    {
        public string Nombre { get; private set; }
        public int Dni { get; private set; }
        public Persona(int dni) 
        {
            Dni = dni;
            
        }
        public int CompareTo(object persona)
        {
            Persona persona1 = persona as Persona;
            if (persona != null && persona is Persona)
            {
                return Dni.CompareTo(persona1.Dni);
            }
            return 1;
        }
        public override string ToString()
        {
            return $"Dni: {Dni} Nombre: {Nombre}";
        }
    }
}
