using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Form1 : Form
    {
        Catal c = new Catal();
        Producto p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = new Producto(c.getCuantos(), Convert.ToInt32(textCod.Text), Convert.ToInt32(textCan.Text), textNom.Text, Convert.ToDouble(textCos.Text));
            c.agregarP(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textMost.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p = new Producto(c.getCuantos(), Convert.ToInt32(textCod.Text), Convert.ToInt32(textCan.Text), textNom.Text, Convert.ToDouble(textCos.Text));
            c.insertarP(p,Convert.ToInt16(textPos.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textMost.Text=c.buscarP(Convert.ToInt16(textPos.Text)-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.eliminarP(Convert.ToInt16(textPos.Text) - 1);
        }
    }
}
