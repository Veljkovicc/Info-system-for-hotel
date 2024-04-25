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
{
    public partial class AzuriranjeRezervacije : Form
    {
        string putanja1;
        string putanja2;
        string putanja3;
        List<Gost> gosti;
        List<Soba> sobe;
        List<Rezervacija> rezervacije;
        int index;
        public AzuriranjeRezervacije()
        {
            InitializeComponent();
            putanja1 = "gosti.bin";
            putanja2 = "sobe.bin";
            putanja3 = "rezervacije.bin";
            if (File.Exists(putanja1))
            {
                Stream fs1 = File.OpenRead(putanja1);
                BinaryFormatter bf1 = new BinaryFormatter();
                gosti = bf1.Deserialize(fs1) as List<Gost>;
                fs1.Close();
                listBox1.DataSource = gosti;
            }
            if (File.Exists(putanja2))
            {
                Stream fs1 = File.OpenRead(putanja2);
                BinaryFormatter bf1 = new BinaryFormatter();
                sobe = bf1.Deserialize(fs1) as List<Soba>;
                fs1.Close();
                listBox2.DataSource = sobe;
            }
            if (File.Exists(putanja3))
            {
                Stream fs1 = File.OpenRead(putanja3);
                BinaryFormatter bf1 = new BinaryFormatter();
                rezervacije = bf1.Deserialize(fs1) as List<Rezervacija>;
                fs1.Close();
                listBox3.DataSource = rezervacije;
            }

        }
        double ukcena;

        private void button1_Click(object sender, EventArgs e)
        {
            List<Gost> gosti1 = new List<Gost>();
            List<Soba> sobe1 = new List<Soba>();
            List<Rezervacija> rezervacije1 = new List<Rezervacija>();
            BinaryFormatter bf = new BinaryFormatter();
            if (listBox1.SelectedItem != null)
            {
                Stream fs = File.OpenRead(putanja1);
                gosti1 = bf.Deserialize(fs) as List<Gost>;
                fs.Close();
                fs = File.OpenRead(putanja2);
                sobe1 = bf.Deserialize(fs) as List<Soba>;
                fs.Close();


            }
            Gost item = null;
            Soba item1 = null;
            item = listBox1.SelectedItem as Gost;
            item1 = listBox2.SelectedItem as Soba;
            ukcena = item1.Cena;
  

            if (item != null && item1 != null && !File.Exists(putanja3))
            {
                
            
                FileStream fs2 = new FileStream(putanja3, FileMode.Create);
                BinaryFormatter bf2 = new BinaryFormatter();
                rezervacije1.Add(new Rezervacija(1, item1.Id, item.Id, dateTimePicker1.Value, dateTimePicker2.Value, ukcena, comboBox1.Text.ToString()));
                bf2.Serialize(fs2, rezervacije1);
                fs2.Close();
                Stream fs1 = File.OpenRead(putanja3);
                BinaryFormatter bf1 = new BinaryFormatter();
                rezervacije1 = bf1.Deserialize(fs1) as List<Rezervacija>;
                fs1.Close();
                listBox3.DataSource = rezervacije1;
                MessageBox.Show("uspesno ste dodali rezervaciju!");
            }
            else
            {
                if (item != null && item1 != null)
                {
                    rezervacije1.Clear();
                    Stream fs1 = File.OpenRead(putanja3);
                    BinaryFormatter bf1 = new BinaryFormatter();
                    rezervacije1 = bf1.Deserialize(fs1) as List<Rezervacija>;
                    fs1.Close();
                    Stream fs2 = File.OpenWrite(putanja3);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    Rezervacija rez = new Rezervacija((rezervacije1[rezervacije1.Count - 1].Id) + 1, item1.Id, item.Id, dateTimePicker1.Value, dateTimePicker2.Value, ukcena, comboBox1.Text.ToString());
                    rezervacije1.Add(rez);
                    bf2.Serialize(fs2, rezervacije1);
                    fs2.Close();
                    listBox3.DataSource = rezervacije1;
                    MessageBox.Show("uspesno ste dodali rezervaciju!");
                    
                }
                
               
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervacija item = null;
            item = listBox3.SelectedItem as Rezervacija;
            int index1 = 0;
            if (item != null)
            {
                List<Rezervacija> rezervacije1 = new List<Rezervacija>();
                Stream fs1 = File.OpenRead(putanja3);
                BinaryFormatter bf1 = new BinaryFormatter();
                rezervacije1 = bf1.Deserialize(fs1) as List<Rezervacija>;
                fs1.Close();

                foreach (Rezervacija rezervacija in rezervacije1)
                {
                    if (item.Ukupnacena == rezervacija.Ukupnacena &&
                    item.Id == rezervacija.Id &&
                    item.Datumod == rezervacija.Datumod &&
                    item.Datumdo == rezervacija.Datumdo &&
                    item.Tiprezervacije == rezervacija.Tiprezervacije)
                    {
                        break;
                    }
                    else index1++;
                }
                rezervacije1.RemoveAt(index1);
                fs1 = File.OpenWrite(putanja3);
                bf1.Serialize(fs1, rezervacije1);
                fs1.Close();
                listBox3.DataSource = rezervacije1;
                MessageBox.Show("Uspesno ste izbrisali rezervaciju.");
            }
            else
            {
                MessageBox.Show("Niste izabrali rezervaciju.");
            }
        }
    }
}


