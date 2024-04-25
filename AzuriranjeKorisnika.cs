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
    public partial class AzuriranjeKorisnika : Form
    {
        string putanja;
        List<Korisnik> korisnici;
        int index;
        public AzuriranjeKorisnika()
        {
            InitializeComponent();
            putanja = "korisnici.bin";
            korisnici = new List<Korisnik>();
            Stream fs1 = File.OpenRead(putanja);
            BinaryFormatter bf1 = new BinaryFormatter();
            korisnici = bf1.Deserialize(fs1) as List<Korisnik>;
            fs1.Close();
            listBox1.DataSource = korisnici;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Korisnik> korisnici1 = new List<Korisnik>();
            Stream fs1 = File.OpenRead(putanja);
            BinaryFormatter bf1 = new BinaryFormatter();
            korisnici1 = bf1.Deserialize(fs1) as List<Korisnik>;
            fs1.Close();
            if (txtIme.Text.Length != 0 &&
                txtPrezime.Text.Length != 0 &&
                txtKorisnickoIme.Text.Length != 0 &&
                txtLozinka.Text.Length != 0 &&
                cmbTipKorisnika.Text.Length != 0)
            {

                korisnici1.Add(new Korisnik(txtIme.Text, txtPrezime.Text, txtKorisnickoIme.Text, txtLozinka.Text, cmbTipKorisnika.SelectedItem.ToString()));
                Stream fs2 = File.OpenWrite(putanja);
                BinaryFormatter bf2 = new BinaryFormatter();
                bf2.Serialize(fs2, korisnici1);
                fs2.Close();
                MessageBox.Show("Uspesno ste dodali korisnika!");
                txtIme.Text = "";
                txtPrezime.Clear();
                txtKorisnickoIme.Text = null;
                txtLozinka.Clear();
                cmbTipKorisnika.Text = "";
            }
            else { 
                MessageBox.Show("Niste uneli sve podatke!");
            }
            listBox1.DataSource = korisnici1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Korisnik item = null;
            item = listBox1.SelectedItem as Korisnik;
            int index = 0;
            if (item != null)
            {
                List<Korisnik> korisnici1 = new List<Korisnik>();
                Stream fs1 = File.OpenRead(putanja);
                BinaryFormatter bf1 = new BinaryFormatter();
                korisnici1 = bf1.Deserialize(fs1) as List<Korisnik>;
                fs1.Close();

                foreach (Korisnik korisnik in korisnici1)
                {
                    if (item.Ime == korisnik.Ime &&
                        item.Prezime == korisnik.Prezime &&
                        item.Korisnickoime == korisnik.Korisnickoime &&
                        item.Lozinka == korisnik.Lozinka)
                    {
                        break;
                    }
                    else index++;
                }
                korisnici1.RemoveAt(index);
                fs1 = File.OpenWrite(putanja);
                bf1.Serialize(fs1, korisnici1);
                fs1.Close();
                listBox1.DataSource = korisnici1;
                MessageBox.Show("Uspesno ste izbrisali korisnika.");
            }
            else
            {
                MessageBox.Show("Niste izabrali korisnika.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Korisnik korisnik = listBox1.SelectedItem as Korisnik;
            for (int i = 0; i < korisnici.Count; i++)
            {
                if (korisnik.Ime == korisnici[i].Ime && korisnik.Prezime == korisnici[i].Prezime && korisnik.Vrstakorisnika == korisnici[i].Vrstakorisnika)
                {
                    listBox1.SelectedIndex = i;
                    index = i;
                    break;
                }
            }
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtLozinka.Text = korisnik.Lozinka;
            txtKorisnickoIme.Text = korisnik.Korisnickoime;
            cmbTipKorisnika.Text = korisnik.Vrstakorisnika;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            List<Korisnik> korisnici1 = new List<Korisnik>();
            Stream fs1 = File.OpenRead(putanja);
            BinaryFormatter bf1 = new BinaryFormatter();
            korisnici1 = bf1.Deserialize(fs1) as List<Korisnik>;
            fs1.Close();
            Stream fs2 = File.OpenWrite(putanja);
            BinaryFormatter bf2 = new BinaryFormatter();
            korisnici1[index] = (new Korisnik(txtIme.Text, txtPrezime.Text, txtKorisnickoIme.Text, txtLozinka.Text, cmbTipKorisnika.Text));
            bf2.Serialize(fs2, korisnici1);
            fs2.Close();
            listBox1.DataSource = korisnici1;
            MessageBox.Show("Uspesno ste izmenili korisnika!");
        }
    }
}
