using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Igra_ListeObjekata_Datoteke
{
	public partial class Glavna : Form
	{
		public Glavna()
		{
			InitializeComponent();
		}

		//TODO:Definirati listu objekata Igra
		List<Igra> igre = new List<Igra>();

		private void btnUnesi_Click(object sender, EventArgs e)
		{
			try
			{
				var ok = decimal.TryParse(txtCijena.Text, out decimal cijena);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format cijene");
					return;
				}
				ok = DateTime.TryParse(txtDatumIzdavanja.Text, out DateTime datum);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format datuma");
					return;
				}
				
				var igra = new Igra
				{
					Naziv = txtNaziv.Text,
					Opis = txtOpis.Text,
					Vrsta = txtVrsta.Text,
					Izdavac = txtIzdavac.Text,
					Cijena = cijena,
					DatumIzdavanja = datum
				};

				//TODO: Dodati igru u listu
				igre.Add(igra);
				AzurirajListBox();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
			}
		}

		//TODO: Napisati funkciju AzurirajListBox
		void AzurirajListBox()
        {
			lstIgre.DataSource = null;
			lstIgre.DataSource = igre;
			lstIgre.DisplayMember = "Naziv";
        }

 //TODO: Napisati funkciju Ukloni_click

        private void btnUkloni_Click(object sender, EventArgs e)
        {
			var index = lstIgre.SelectedIndex;
            if (index >= 0)
            {
					igre.RemoveAt(index);
				AzurirajListBox();
            }
			

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
			var datoteka = new StreamWriter("igre.txt");
            foreach (var igra in igre)
            {
				datoteka.WriteLine($"{igra.Naziv}|{igra.Opis}|{igra.Vrsta}|{igra.DatumIzdavanja}|{igra.Cijena}|{igra.Izdavac}");

            }
			datoteka.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
			var redovi = File.ReadAllLines("igre.txt");
            foreach (var red in redovi)
            {
				var stupci = red.Split('|');
				var ok = decimal.TryParse(stupci[4], out decimal cijena);
                if (!ok)
                {
					MessageBox.Show("pogrešan format cijene !");
					continue;
                }
				ok = DateTime.TryParse(stupci[5], out DateTime datum);
				if (!ok)
				{
					MessageBox.Show("pogrešan format datuma !");
					continue;
				}
				var igra = new Igra
				{
					Naziv = stupci[0],
					Opis = stupci[1],
					Vrsta = stupci[2],
					Izdavac = stupci[3],
					Cijena = cijena,
					DatumIzdavanja = datum
				};
				igre.Add(igra);
			}
			AzurirajListBox();
        }
    }
}
