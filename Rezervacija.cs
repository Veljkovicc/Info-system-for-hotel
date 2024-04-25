using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veljkonrt8020
{
    [Serializable]
    class Rezervacija
    {
        //AKO NE RADI PROVERI OVO
        

        int id;
        private int idsobe;
        private int idgosta;
        private DateTime datumod;
        private DateTime datumdo;
        private double ukupnacena;
        private string tiprezervacije;

        public Rezervacija(int id, int idsobe, int idgosta, DateTime datumod, DateTime datumdo, double ukupnacena, string tiprezervacije)
        {
            this.id = id;
            this.idsobe = idsobe;
            this.idgosta = idgosta;
            this.datumod = datumod;
            this.datumdo = datumdo;
            this.ukupnacena = ukupnacena;
            this.tiprezervacije = tiprezervacije;
        }
        public int Id { get => id; set => id = value; }
        public DateTime Datumod { get => datumod; set => datumod = value; }
        public DateTime Datumdo { get => datumdo; set => datumdo = value; }
        public double Ukupnacena { get => ukupnacena; set => ukupnacena = value; }
        public string Tiprezervacije { get => tiprezervacije; set => tiprezervacije = value; }

        public override string ToString()
        {
            return $"ID: {id}, id sobe: {idsobe}, id gosta: {idgosta}, rezervisano od: {datumod}, do: {datumdo}, ukupna cena: {ukupnacena}$, tip rezervacije: {tiprezervacije}";
        }
    }
}
