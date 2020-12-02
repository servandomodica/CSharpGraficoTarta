using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto134graphicsTarta
{
    public partial class Form1 : Form
    {
        public bool estado = false;
        private int partido1, partido2, partido3;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                Graphics lienzo = CreateGraphics();
                int totalVotos = partido1 + partido2 + partido3;
                int grados1 = partido1 * 360 / totalVotos;
                int grados2 = partido2 * 360 / totalVotos;
                int grados3 = partido3 * 360 / totalVotos;
                lienzo.FillPie(new SolidBrush(Color.Red), 10, 10, 400, 400, 0, grados1);
                lienzo.FillPie(new SolidBrush(Color.Blue), 10, 10, 400, 400, grados1, grados2);
                lienzo.FillPie(new SolidBrush(Color.Yellow), 10, 10, 400, 400, grados1+grados2, grados3);

                lienzo.FillRectangle(new SolidBrush(Color.Red), 100, 500, 20, 20);
                lienzo.DrawString(partido1.ToString(), new Font("Arial", 15), new SolidBrush(Color.Red), 150, 500);
                lienzo.FillRectangle(new SolidBrush(Color.Blue), 100, 530, 20, 20);
                lienzo.DrawString(partido2.ToString(), new Font("Arial", 15), new SolidBrush(Color.Blue), 150, 530);
                lienzo.FillRectangle(new SolidBrush(Color.Yellow), 100, 560, 20, 20);
                lienzo.DrawString(partido3.ToString(), new Font("Arial", 15), new SolidBrush(Color.Yellow), 150, 560);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            partido1 = int.Parse(textBox1.Text);
            partido2 = int.Parse(textBox2.Text);
            partido3 = int.Parse(textBox3.Text);
            estado = true;
            Refresh(); //llama a redibujar
        }
    }
}
