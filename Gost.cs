using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veljkonrt8020
{
    [Serializable]
    class Gost
    {
        

        //private static int ID = 0;

        int id;
        string ime;
        string prezime;
        DateTime datumrodjenja;
        string telefon;

        public Gost(int id, string ime, string prezime, DateTime datumrodjenja, string telefon)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.datumrodjenja = datumrodjenja;
            this.telefon = telefon;
        }
        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime Datumrodjenja { get => datumrodjenja; set => datumrodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return $"{id}, {ime}, {prezime}, {Datumrodjenja}, {telefon}";
        }
    }
}
