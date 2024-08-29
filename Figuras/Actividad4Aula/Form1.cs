using Actividad4Aula.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4Aula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList figuras = new ArrayList();
        private void btPrueba_Click(object sender, EventArgs e)
        {
            
            IFigura cuadrado = new Cuadrado(3.5);
            IFigura rectangulo = new Rectangulo(3,4);
            IFigura circulo = new Circulo(2);
            figuras.Add(cuadrado);
            figuras.Add(rectangulo);
            figuras.Add(circulo);
            figuras.Sort();
            
            foreach (IFigura a in figuras)
            {     
                lbPrueba.Items.Add(a.ToString());
            }
        }
    }
}
