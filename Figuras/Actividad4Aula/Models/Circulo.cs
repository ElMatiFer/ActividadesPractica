﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4Aula.Models
{
    internal class Circulo : IFigura, IComparable
    {
        public double Radio { get; private set; }

        public Circulo(double radio) 
        {
            this.Radio = radio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio,2);
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
        public override string ToString()
        {
            return $"Circulo: {CalcularArea()}";
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
