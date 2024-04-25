using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veljkonrt8020
{//clasa dodat id i dodato id u goste
    public partial class AzuriranjeGosta : Form
    {
        string putanja;
        List<Gost> gosti;
        int index;
        public AzuriranjeGosta()
        {
            InitializeComponent();
            putanja = "gosti.bin";
            gosti = new List<Gost>();
            if (File.Exists(putanja))
            {
                Stream fs1 = File.OpenRead(putanja);
                BinaryFormatter bf1 = new BinaryFormatter();
                gosti = bf1.Deserialize(fs1) as List<Gost>;
                fs1.Close();
                listBox1.DataSource = gosti;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Gost> gosti1 = new List<Gost>();
            if (File.Exists(putanja))
            {
                Stream fs1 = File.OpenRead(putanja);
                BinaryFormatter bf1 = new BinaryFormatter();
                gosti1 = bf1.Deserialize(fs1) as List<Gost>;
                fs1.Close();
                Stream fs2 = File.OpenWrite(putanja);
                BinaryFormatter bf2 = new BinaryFormatter();
                gosti1.Add(new Gost((gosti1[gosti1.Count - 1].Id + 1),txtIme.Text, txtPrezime.Text, dtpDatum.Value, txtTelefon.Text));
                bf2.Serialize(fs2, gosti1);
                fs2.Close();
                listBox1.DataSource = gosti1;
            }
            else
            {
                if (txtIme.Text.Length != 0 &&
                txtPrezime.Text.Length != 0 &&
                txtTelefon.Text.Length != 0)
                {
                    FileStream fs2 = new FileStream(putanja, FileMode.Create);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    gosti1.Add(new Gost(1,txtIme.Text, txtPrezime.Text, dtpDatum.Value, txtTelefon.Text));
                    bf2.Serialize(fs2, gosti1);
                    fs2.Close();
                    MessageBox.Show("Uspesno ste dodali gosta!");
                    txtIme.Text = "";
                    txtPrezime.Clear();
                    txtTelefon.Clear();

                }
                else
                {
                    MessageBox.Show("Niste uneli sve podatke!");
                }
            }
            listBox1.DataSource = gosti1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gost item = null;
            item = listBox1.SelectedItem as Gost;
            int index = 0;
            if (item != null)
            {
                List<Gost> gosti1 = new List<Gost>();
                Stream fs1 = File.OpenRead(putanja);
                BinaryFormatter bf1 = new BinaryFormatter();
                gosti1 = bf1.Deserialize(fs1) as List<Gost>;
                fs1.Close();

                foreach (Gost gost in gosti1)
                {
                    if (item.Ime == gost.Ime &&
                        item.Prezime == gost.Prezime &&
                        item.Datumrodjenja == gost.Datumrodjenja &&
                        item.Telefon == gost.Telefon)
                    {
                        break;
                    }
                    else index++;
                }
                gosti1.RemoveAt(index);
                fs1 = File.OpenWrite(putanja);
                bf1.Serialize(fs1, gosti1);
                fs1.Close();
                listBox1.DataSource = gosti1;
                MessageBox.Show("Uspesno ste izbrisali gosta.");
            }
            else
            {
                MessageBox.Show("Niste izabrali gosta.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gost gost = listBox1.SelectedItem as Gost;
            for (int i = 0; i < gosti.Count; i++)
            {
                if (gost.Id == gosti[i].Id)
                {
                    listBox1.SelectedIndex = i;
                    index = i;
                    break;
                }
            }
            txtIme.Text = gost.Ime;
            txtPrezime.Text = gost.Prezime;
            txtTelefon.Text = gost.Telefon;
            dtpDatum.Value = gost.Datumrodjenja;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            List<Gost> gosti1 = new List<Gost>();
            Stream fs1 = File.OpenRead(putanja);
            BinaryFormatter bf1 = new BinaryFormatter();
            gosti1 = bf1.Deserialize(fs1) as List<Gost>;
            fs1.Close();
            Stream fs2 = File.OpenWrite(putanja);
            BinaryFormatter bf2 = new BinaryFormatter();
            gosti1[index]=(new Gost(gosti1[index].Id, txtIme.Text, txtPrezime.Text, dtpDatum.Value, txtTelefon.Text));
            bf2.Serialize(fs2, gosti1);
            fs2.Close();
            listBox1.DataSource = gosti1;
            MessageBox.Show("Uspesno ste izmenili gosta!");
        }
    }

    }


