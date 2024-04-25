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
    public partial class AzuriranjeSobe : Form
    {
        string putanja;
        List<Soba> sobe;
        int index;
        public AzuriranjeSobe()
        {
            InitializeComponent();
            putanja = "sobe.bin";
            sobe = new List<Soba>();
            if (File.Exists(putanja))
            {
                Stream fs1 = File.OpenRead(putanja);
                BinaryFormatter bf = new BinaryFormatter();
                sobe = bf.Deserialize(fs1) as List<Soba>;
                fs1.Close();
                listBox1.DataSource = sobe;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Soba> sobe1 = new List<Soba>();
            if (File.Exists(putanja))
            {
                Stream fs1 = File.OpenRead(putanja);
                BinaryFormatter bf1 = new BinaryFormatter();
                sobe1 = bf1.Deserialize(fs1) as List<Soba>;
                fs1.Close();
                Stream fs2 = File.OpenWrite(putanja);
                BinaryFormatter bf2 = new BinaryFormatter();
                sobe1.Add(new Soba(sobe1[sobe1.Count - 1].Id + 1 ,Int32.Parse(txtBrSobe.Text), Int32.Parse(cbBrojKreveta.Text), cbTipSobe.Text.ToString(), Double.Parse(txtCena.Text), Int32.Parse(txtPopust.Text), Int32.Parse(txtMinDana.Text)));
                bf2.Serialize(fs2, sobe1);
                fs2.Close();
                listBox1.DataSource = sobe1;
            }
            else
            {
                if (txtBrSobe.Text.Length != 0 &&
                    txtCena.Text.Length != 0 &&
                    txtMinDana.Text.Length != 0 &&
                    txtPopust.Text.Length != 0 &&
                    cbBrojKreveta.Text.Length != 0 &&
                    cbTipSobe.Text.Length != 0)
                {
                    Stream fs2 = new FileStream(putanja, FileMode.Create);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    sobe1.Add(new Soba(1, Int32.Parse(txtBrSobe.Text), Int32.Parse(cbBrojKreveta.Text), cbTipSobe.Text.ToString(), Double.Parse(txtCena.Text), Int32.Parse(txtPopust.Text), Int32.Parse(txtMinDana.Text)));
                    bf2.Serialize(fs2 , sobe1);
                    fs2.Close();
                    MessageBox.Show("Uspesno ste dodali sobu!");
                    txtBrSobe.Focus();
                }
                else
                {
                    MessageBox.Show("Niste uneli sve podatke!");
                }
                
            }
            listBox1.DataSource = sobe1;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            Soba item = null;
            item = listBox1.SelectedItem as Soba;

            for (int i = 0; i < sobe.Count; i++)
            {
                if (item.Id == sobe[i].Id)
                {
                    listBox1.SelectedIndex = i;
                    index = i;
                    break;
                }
            }

            
            txtBrSobe.Text = item.Brojsobe.ToString();
            cbBrojKreveta.Text = item.Brojkreveta.ToString();
            cbTipSobe.Text = item.Tipsobe.ToString();
            txtCena.Text = item.Cena.ToString();
            txtPopust.Text = item.Popust.ToString();
            txtMinDana.Text = item.Mindanazarez.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Soba item = null;
            item = listBox1.SelectedItem as Soba;
            int index1 = 0;
            if (item != null)
            {
                List<Soba> sobe1 = new List<Soba>();
                Stream fs1 = File.OpenRead(putanja);
                BinaryFormatter bf1 = new BinaryFormatter();
                sobe1 = bf1.Deserialize(fs1) as List<Soba>;
                fs1.Close();

                foreach (Soba soba in sobe1)
                {
                    if (item.Cena == soba.Cena &&
                        item.Brojkreveta == soba.Brojkreveta &&
                        item.Mindanazarez == soba.Mindanazarez &&
                        item.Brojsobe == soba.Brojsobe &&
                        item.Tipsobe == soba.Tipsobe)
                    {
                        break;
                    }
                    else index1++;
                }
                fs1 = File.OpenWrite(putanja);
                sobe1.RemoveAt(index1);
                bf1.Serialize(fs1, sobe1);
                fs1.Close();
                listBox1.DataSource = sobe1;
                MessageBox.Show("Uspesno ste uklonili sobu.");
            }
            else
            {
                MessageBox.Show("Niste izabrali sobu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Soba> sobe1 = new List<Soba>();
            Stream fs1 = File.OpenRead(putanja);
            BinaryFormatter bf1 = new BinaryFormatter();
            sobe1 = bf1.Deserialize(fs1) as List<Soba>;
            fs1.Close();
            Stream fs2 = File.OpenWrite(putanja);
            BinaryFormatter bf2 = new BinaryFormatter();
            sobe1[index] = (new Soba(sobe1[index].Id, Int32.Parse(txtBrSobe.Text), Int32.Parse(cbBrojKreveta.Text), cbTipSobe.Text.ToString(), Double.Parse(txtCena.Text), Int32.Parse(txtPopust.Text), Int32.Parse(txtMinDana.Text)));
            bf2.Serialize(fs2, sobe1);
            fs2.Close();
            listBox1.DataSource = sobe1;
            MessageBox.Show("Uspesno ste izmenili sobu!");
        }

        
    }
}
