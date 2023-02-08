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
    public partial class DGV_habitation : Form
    {
        public DGV_habitation()
        {
            InitializeComponent();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_habitation_Load(object sender, EventArgs e)
        {
            assuranceEntities1 a = new assuranceEntities1();
            dataGridView1.Show();
            dataGridView1.DataSource = a.habitation1.Select(P => new { Code_habitation= P.Code_habitation, CIN = P.CIN, Genre = P.Genre, Résidence = P.Résidence, Estimation_de_biens = P.Estimation_de_biens, Nombre_de_sinistre = P.Nombre_de_sinistre, Durée = P.Durée, date_début = P.Date_début }).ToList();

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

            try
            {
                assuranceEntities1 a = new assuranceEntities1();
                string id = gunaTextBox1.Text;
                dataGridView1.DataSource = a.habitation1.Where(c => c.Code_habitation == id).Select(P => new { Code_habitation = P.Code_habitation, CIN = P.CIN, Genre = P.Genre, Résidence = P.Résidence, Estimation_de_biens = P.Estimation_de_biens, Nombre_de_sinistre = P.Nombre_de_sinistre, Durée = P.Durée, date_début = P.Date_début }).ToList();

            }
            catch (Exception X)
            {

                MessageBox.Show(X.Message);
            }
        }
    }
}
