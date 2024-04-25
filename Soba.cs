using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veljkonrt8020
{
    [Serializable]
    class Soba
    {
        

        int id;
        private int brojsobe;
        private int brojkreveta;
        private string tipsobe; //standard/lux
        private double cena;
        private int popust;
        private int mindanazarez;

        public Soba(int id ,int brojsobe, int brojkreveta, string tipsobe, double cena, int popust, int mindanazarez)
        {
            this.id = id;
            this.brojsobe = brojsobe;
            this.brojkreveta = brojkreveta;
            this.tipsobe = tipsobe;
            this.cena = cena;
            this.popust = popust;
            this.mindanazarez = mindanazarez;
        }

        public int Id { get => id; set => id = value; }
        public int Brojsobe { get => brojsobe; set => brojsobe = value; }
        public int Brojkreveta { get => brojkreveta; set => brojkreveta = value; }
        public string Tipsobe { get => tipsobe; set => tipsobe = value; }
        public double Cena { get => cena; set => cena = value; }
        public int Popust { get => popust; set => popust = value; }
        public int Mindanazarez { get => mindanazarez; set => mindanazarez = value; }
        public override string ToString()
        {
            return $"Id: {id}, Broj sobe: {brojsobe}, Broj kreveta: {brojkreveta}, Tip some: {tipsobe},Cena: {cena}&, Popust: {popust},Min dana za rez: {mindanazarez}";
        }
    }
}
