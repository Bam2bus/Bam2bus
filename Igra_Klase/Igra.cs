using System;
using System.Collections.Generic;
using System.Text;

namespace Igra_Klase
{
	public class Igra
	{
		private string naziv, opis, vrsta, izdavac;
		private decimal cijena;
		private DateTime datumIzdavanja;
		//1. verzija- unos preko funcije, kasnije zamijenimo sa get/set
		public void UnesiPodatke(string naziv, string opis, string vrsta, string izdavac, decimal cijena, DateTime datumIzdavanja)
		{
            if (string.IsNullOrEmpty(naziv))
            
				throw new ArgumentException("Naziv mora biti upisan");
            
			this.naziv = naziv;
			this.opis = opis;
			if (string.IsNullOrEmpty(vrsta))
				throw new ArgumentException("Vrsta mora biti zadana");
			this.vrsta = vrsta;
			this.izdavac = izdavac;
			if (cijena < 0)
				throw new ArgumentException("Cijena mora biti >0");
			this.cijena = cijena;
			if (datumIzdavanja > DateTime.Now)
				throw new ArgumentException("Datum ne smije biti u budućnosti");
			this.datumIzdavanja = datumIzdavanja;
		}
		//Primjer funkcije za jednu varijablu
		public void UnesiNaziv(string naziv)
        {
			if(string.IsNullOrEmpty(naziv))
			throw new ArgumentException("Naziv mora biti upisan");

			this.naziv = naziv;
		}
		//isto, ali preko propertya
		public string Naziv
		{
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Naziv mora biti upisan");
				this.naziv = value;

			}
			get
			{
				return this.naziv;
			}
		}
        public string Opis { get => opis; set => opis = value; }
        public string Vrsta {
			get => vrsta;
			set {
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Vrsta mora biti zadana");
				vrsta = value;
					
					}
		}
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public decimal Cijena
		{
			get => cijena;
			set
			{
				if (value < 0)
					throw new ArgumentException("Cijena mora biti >0");
				cijena = value;
			}
		}
        public DateTime DatumIzdavanja { 
			get => datumIzdavanja; 
			set {
				if (value > DateTime.Now)
					throw new ArgumentException("Datum ne smije biti u budućnosti");

				datumIzdavanja = value; 
			} 
		}
    }
}
