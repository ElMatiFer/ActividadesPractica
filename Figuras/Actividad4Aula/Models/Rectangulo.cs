using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4Aula.Models
{
    internal class Rectangulo : IFigura, IComparable
    {
        public double Lado1 { get; protected set; }
        public double Lado2 { get; protected set; }
        public Rectangulo(double lado1, double lado2) 
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        } 
        public double CalcularArea()
        {
            return Lado1 * Lado2;
        }
        public double CalcularPerimetro()
        {
            return Lado1 + Lado2;
        }
        public override string ToString()
        {
            return $"Rectangulo: {CalcularArea()}"; 
        }
        public int CompareTo(object obj)
        {
            int result = 0;

            if (obj != null && obj is IFigura)
            {
                IFigura obj1 = (IFigura)obj;
                double area = CalcularArea();   
                result = area.CompareTo(obj1.CalcularArea());
            }
            return result;


        }
    }
}
