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
    public partial class ProveriRezRec : Form
    {
        string putanja;
        List<Rezervacija> rezervacije;

        public ProveriRezRec()
        {
            InitializeComponent();
            putanja = "rezervacije.bin";
            rezervacije = new List<Rezervacija>();
            if (File.Exists(putanja))
            {
                Stream fs1 = File.OpenRead(putanja);
                BinaryFormatter bf1 = new BinaryFormatter();
                rezervacije = bf1.Deserialize(fs1) as List<Rezervacija>;
                fs1.Close();
                listBox1.DataSource = rezervacije;
            }

        }
    }
}
