using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            assuranceEntities1 a = new assuranceEntities1();
            dataGridView1.Show();
            dataGridView1.DataSource = a.Auto.Select(P => new { Immatriculation = P.Immatriculation, CIN = P.CIN, Usage_de_véhicule = P.usage_de_véhicule, kilométrage_annuel = P.kilométrage_annuel, Marque_de_véhicule = P.Marque_de_véhicule, Modéle_de_véhicule = P.Modéle_de_véhicule, puissance_fiscale = P.Puissance_fiscale, Nombre_de_sinistre = P.Nombre_de_sinistre, Nombre_de_mois = P.Nombre_de_mois, Date_début = P.date_début }).ToList();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                assuranceEntities1 a = new assuranceEntities1();
                string id = gunaTextBox1.Text;
                dataGridView1.DataSource = a.Auto.Where(c => c.Immatriculation == id).Select(P => new { Immatriculation = P.Immatriculation, CIN = P.CIN, Usage_de_véhicule = P.usage_de_véhicule, kilométrage_annuel = P.kilométrage_annuel, Marque_de_véhicule = P.Marque_de_véhicule, Modéle_de_véhicule = P.Modéle_de_véhicule, puissance_fiscale = P.Puissance_fiscale, Nombre_de_sinistre = P.Nombre_de_sinistre, Nombre_de_mois = P.Nombre_de_mois, Date_début = P.date_début }).ToList();

            }
            catch (Exception X)
            {

                MessageBox.Show(X.Message);
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
