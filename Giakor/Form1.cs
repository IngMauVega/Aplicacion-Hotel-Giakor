using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giakor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nueva_Reservacion nueva = new Nueva_Reservacion();
            nueva.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Disponibilidad nueva = new Disponibilidad();
            nueva.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pagos nueva = new Pagos();
            nueva.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cotizaciones nueva = new Cotizaciones();
            nueva.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buscar nueva = new Buscar();
            nueva.Show();
        }
    }
}
