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
    public partial class Disponibilidad : Form
    {
        public Disponibilidad()
        {
            InitializeComponent();
        }

        private void btn102_MouseHover(object sender, EventArgs e)
        {
            btn102.BackColor = Color.Yellow;

        }

        private void btn101_MouseEnter(object sender, EventArgs e)
        {
            btn101.BackColor = Color.Red;
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Habitacion reservada con fecha: 02/12/2020    Por: Bob     Estado: Sin pagar");
        }
    }
}
