using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veljkonrt8020
{
    [Serializable]
    class Korisnik
    {
        private static int ID = 0;

        private int id;
        private string ime;
        private string prezime;
        private string korisnickoime;
        private string lozinka;
        private string vrstakorisnika;

        public Korisnik(string ime, string prezime, string korisnickoime, string lozinka, string vrstakorisnika)
        {
            this.id = ID++;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoime = korisnickoime;
            this.lozinka = lozinka;
            this.vrstakorisnika = vrstakorisnika;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Korisnickoime { get => korisnickoime; set => korisnickoime = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Vrstakorisnika { get => vrstakorisnika; set => vrstakorisnika = value; }

        public override string ToString()
        {
            return $"{ime}, {prezime}, {korisnickoime}, {vrstakorisnika}";
        }
    }
}
