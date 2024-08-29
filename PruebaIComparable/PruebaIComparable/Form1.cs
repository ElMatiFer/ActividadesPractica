using PruebaIComparable.Models;
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

namespace PruebaIComparable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList personitas = new ArrayList();
        private void btCrearPersonas_Click(object sender, EventArgs e)
        {
            Persona nuevo1 = new Persona(1000);
            Persona nuevo2 = new Persona(2000);
            Persona nuevo3 = new Persona(3000);
            
            personitas.Add(nuevo2);
            personitas.Add(nuevo3);
            personitas.Add(nuevo1);

            personitas.Sort();

            foreach (Persona a in personitas)
            {
                lbPrueba.Items.Add(a.ToString());
            }

            

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Persona p = null;

            int dni = Convert.ToInt32(btBuscar.Text);
            personitas.Sort();

            int i = personitas.BinarySearch(new Persona(dni));


        }
    }
}
