using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veljkonrt8020
{
    public partial class forma2 : Form
    {
        public forma2()
        {
            InitializeComponent();
        }
        string putanja;
        private void button1_Click(object sender, EventArgs e)
        {
            putanja = "korisnici.bin";
            List<Korisnik> korisnici = new List<Korisnik>();
            if (!File.Exists(putanja))
            {
                Stream fs = File.Open(putanja, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                Korisnik korisnik = new Korisnik("admin", "admin", "admin", "admin", "admin");
                Korisnik korisnik1 = new Korisnik("recepcioner", "recepcioner", "recepcioner", "recepcioner", "recepcioner");
                korisnici.Add(korisnik);
                korisnici.Add(korisnik1);
                bf.Serialize(fs, korisnici);
                fs.Close();
            }
            Stream fs1 = File.OpenRead(putanja);
            BinaryFormatter bf1 = new BinaryFormatter();
            korisnici.Clear();
            korisnici = bf1.Deserialize(fs1) as List<Korisnik>;
            int flag = 0;
            foreach (Korisnik korisnik1 in korisnici)
            {
                if (korisnik1.Vrstakorisnika.ToLower()=="recepcioner")
                {
                    if (korisnik1.Korisnickoime.ToLower() == txtKorisnickoImeRec.Text && korisnik1.Lozinka == txtKorisnickoImeRec.Text)
                    {
                        FormaRec1 forma = new FormaRec1();
                        forma.Show();
                        this.Hide();
                        fs1.Close();
                        flag = 1;
                        break;
                    }

                }
            }
            if (flag == 0)
            {
                MessageBox.Show("Nemate pravo pristupa.");
            }
        }

        private void forma2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
