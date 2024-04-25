using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veljkonrt8020
{
    public partial class FormaRec1 : Form
    {
        public FormaRec1()
        {
            InitializeComponent();
        }

        private void FormaRec1_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma2 form = new forma2();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AzuriranjeRezervacije form = new AzuriranjeRezervacije();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveriRezRec form = new ProveriRezRec();
            form.Show();
        }
    }
}
