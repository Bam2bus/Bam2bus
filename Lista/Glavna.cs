using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lista
{
    public partial class Glavna : Form
    {
        List<string> rijeci = new List<string>();

        public Glavna()
        {
            InitializeComponent();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var rijec = txtJednarijec.Text;
            if (!string.IsNullOrEmpty(rijec))
            {
                rijeci.Add(rijec);
                txtJednarijec.Text = string.Empty;
                AzurirajListBox();
            }

        }

        private void AzurirajListBox(List<string> lista = null)
        {
            lstPopis.DataSource = null;
            //Verzija 1- ?
            lstPopis.DataSource = lista != null ? lista : rijeci;
            //Verzija 1b - ??
            lstPopis.DataSource = lista ?? rijeci;
            //Verzija 2 - if
            if (lista != null)
            {
                lstPopis.DataSource = lista;
            }
            else
            {
                lstPopis.DataSource = rijeci;
            }
            lstPopis.DataSource = rijeci;
        }

        private void btnDodajNaPos_Click(object sender, EventArgs e)
        {
            var pozicijaText = txtPozicija.Text;
            int pozicija;
            var ispravno = int.TryParse(pozicijaText, out pozicija);
            if (!ispravno)
            {
                MessageBox.Show("Broj nije u dobro formatu");
                return;
            }
            var rijec = txtJednarijec.Text;
            rijeci.Insert(pozicija - 1, rijec);
            txtJednarijec.Text = string.Empty;
            AzurirajListBox();
        }

        private void btnDodajVise_Click(object sender, EventArgs e)
        {
            var poljeRijeci = txtViseRijeci.Text.Split(' ');
            rijeci.AddRange(poljeRijeci);
            txtViseRijeci.Text = string.Empty;
            AzurirajListBox();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var index = lstPopis.SelectedIndex;
            if (index >= 0)
            {
                rijeci.RemoveAt(index);
                AzurirajListBox();
            }

        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            rijeci.Clear();
            AzurirajListBox();
        }
        private void btnSortirajAsc_Click(object sender, EventArgs e)
        {
            var sortLista = rijeci.OrderBy(r => r);
            AzurirajListBox(sortLista.ToList());
        }
        private void btnSortirajDesc_Click(object sender, EventArgs e)
        {
            var sortLista = rijeci.OrderBy(r => r);
            AzurirajListBox(sortLista.ToList());
        }
        private void btnTrazi_Click(object sender, EventArgs e)
        {
            var index = rijeci.FindIndex(r => r.Contains(txtTrazi.Text));
            if (index < 0)
            {
                MessageBox.Show("Pojam nije pronađen");
                return;
            }
            else
            {
                lstPopis.SelectedIndex = index;
            }
         
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filtriranalista = rijeci.Where(r => r.Contains(txtTrazi.Text));
            //opcija 2 - koristiti FindAll koja vraca list<string>
            AzurirajListBox(filtriranalista.ToList());
        }
        private void btnOcistiFilter_Click(object sender, EventArgs e)
        {
            AzurirajListBox();
        }
    }
}
