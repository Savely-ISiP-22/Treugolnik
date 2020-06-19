using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Треугольник
{
    public partial class Треугольник : Form
    {
        public Треугольник()
        {
            InitializeComponent();
        }
        double poluper;
        double ploshad;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked == true && rBtn2.Checked == false)
            {
                poluper = ((double)num1.Value + (double)num2.Value + (double)num3.Value) / 2;

                ploshad = Math.Sqrt(poluper * (poluper - (double)num1.Value) * ((poluper - (double)num2.Value) * (poluper - (double)num3.Value)));
                Math.Truncate(ploshad);
                txtRes.Text = Convert.ToString(Math.Truncate(ploshad));
            }
            else { };
                
            double perimetr;
            if (rBtn2.Checked == true && rBtn1.Checked == false)
             {
                perimetr = (double)num1.Value + (double)num2.Value + (double)num3.Value;
                txtRes.Text = Convert.ToString(perimetr);
             }
            else { };
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Tomato;
            menuSt.BackColor = Color.Tomato;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DeepSkyBlue;
            menuSt.BackColor = Color.DeepSkyBlue;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
            menuSt.BackColor = Color.LightGreen;
        }

        private void вернутьСтандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
            menuSt.BackColor = Color.WhiteSmoke;
        }
    }
}
