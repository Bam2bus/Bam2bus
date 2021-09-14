using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarada
{
    public partial class Glavni: Form

    {
        public double Zarada(double sati, double cijenaSata=40, double porez = 0.2)
        {

            if (sati < 0)
            {
                throw new ArgumentException("Broj sati mora biti >=0");
            }

            if (cijenaSata < 10)
            {
                throw new ArgumentException("Cijena sata mora biti >=10");

            }
            if(porez<0.1 || porez > 0.4)
            {
                throw new ArgumentOutOfRangeException("Porez mora biti izmedu 10% i 40%");

            }
            return sati * cijenaSata * (1 - porez);

        }


        public Glavni()
        {

            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            try
            {
                var ok = double.TryParse(txtSati.Text, out double sati);
                if (!ok)
                {
                    MessageBox.Show("Pogrešan format sati");
                    return;
                }
                ok = double.TryParse(txtCijena.Text, out double cijena);
                if (!ok)
                {
                    MessageBox.Show("Pogrešan format cijene");
                    return;
                }

                ok = double.TryParse(txtPorez.Text, out double porez);
                if (!ok)
                {
                    MessageBox.Show("Pogrešan format poreza");
                    return;
                }
                porez /= 100;
                lblZarada1.Text = Zarada(sati, cijena, porez).ToString("N2");
                lblZarada2.Text = Zarada(sati, porez: porez).ToString("N2");
                lblZarada3.Text = Zarada(sati, cijena).ToString("N2");
                lblZarada4.Text = Zarada(sati).ToString("N2");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message} ");
            }


        }
    }
}
