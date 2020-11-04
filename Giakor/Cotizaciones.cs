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
    public partial class Cotizaciones : Form
    {
        public Cotizaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string habitacion = txthab.Text;         
                        
            DateTime llego = llegada.Value.Date;
            DateTime sefue = Salida.Value.Date;
            TimeSpan tiempo = llego - sefue;
            int noches = tiempo.Days;

            lblnoches.Text = Convert.ToString(noches);


            // lblnoches.Text=llegada.


            if (habitacion == "101" || habitacion == "102")
            {
                txtmonto.Text = Convert.ToString(noches * 980);
            }
            if (habitacion == "103" || habitacion == "105")
            {
                txtmonto.Text = Convert.ToString(noches * 1080);
            }
            if (habitacion == "106" || habitacion == "107" || habitacion == "107")
            {
                txtmonto.Text = Convert.ToString(noches * 1540);
            }
            if (habitacion == "201" || habitacion == "301")
            {
                txtmonto.Text = Convert.ToString(noches * 1370);
            }
            if (habitacion == "202" || habitacion == "202")
            {
                txtmonto.Text = Convert.ToString(noches * 1270);
            }
            if (habitacion == "303" || habitacion == "602")
            {
                txtmonto.Text = Convert.ToString(noches * 1600);
            }
            if (habitacion == "304" || habitacion == "503")
            {
                txtmonto.Text = Convert.ToString(noches * 900);
            }
            if (habitacion == "401" || habitacion == "402")
            {
                txtmonto.Text = Convert.ToString(noches * 1180);
            }
            if (habitacion == "501" || habitacion == "502" || habitacion == "601" || habitacion == "603")
            {
                txtmonto.Text = Convert.ToString(noches * 980);
            }
            if (rdaltasi.Checked = true)
            {
                Double monto = 500;
                    monto= Convert.ToDouble(txtmonto.Text);
            }
            if (rdaltano.Checked=true)
            {
                Double monto = Convert.ToDouble(txtmonto.Text);
            }
        }
    }
}
