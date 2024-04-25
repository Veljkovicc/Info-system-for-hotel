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
    public partial class FormaAdmin1 : Form
    {
        public FormaAdmin1()
        {
            InitializeComponent();
        }

        private void btnAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            AzuriranjeKorisnika form = new AzuriranjeKorisnika();
            form.Show();
            
        }

        private void FormaAdmin1_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma1 form = new forma1();
            form.Show();
        }

        private void btnAzurirajGosta_Click(object sender, EventArgs e)
        {
            AzuriranjeGosta form = new AzuriranjeGosta();
            form.Show();
        }

        private void btnAzurirajSobe_Click(object sender, EventArgs e)
        {
            AzuriranjeSobe form = new AzuriranjeSobe();
            form.Show();
        }

        private void btnAzurirajRez_Click(object sender, EventArgs e)
        {
            AzuriranjeRezervacije form = new AzuriranjeRezervacije();
            form.Show();
        }
    }
}
