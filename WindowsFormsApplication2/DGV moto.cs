using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class DGV_moto : Form
    {
        //private object form;

        public DGV_moto()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void DGV_moto_Load(object sender, EventArgs e)
        {
            assuranceEntities1 a = new assuranceEntities1();
            dataGridView1.Show();
            dataGridView1.DataSource = a.Moto.Select(P => new { Immatriculation = P.Immatriculation, CIN = P.CIN, Type_de_véhicule = P.type_de_véhicule, Cylindrée_de_moto = P.cylindrée_de_moto, Assurance_concerne_à = P.Concerne, La_carte_Grise = P.La_carte_grise, Typde_de_permis = P.type_de_permis, Nombre_de_sinistre = P.Nombre_de_sinistre, Nombre_de_mois = P.Nombre_de_mois, Date_début = P.date_début }).ToList();

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                assuranceEntities1 a = new assuranceEntities1();
                string id = gunaTextBox1.Text;
                dataGridView1.DataSource = a.Moto.Where(c => c.Immatriculation == id).Select(P => new { Immatriculation = P.Immatriculation, CIN = P.CIN, Type_de_véhicule = P.type_de_véhicule, Cylindrée_de_moto = P.cylindrée_de_moto, Assurance_concerne_à = P.Concerne, La_carte_Grise = P.La_carte_grise, Typde_de_permis = P.type_de_permis, Nombre_de_sinistre = P.Nombre_de_sinistre, Nombre_de_mois = P.Nombre_de_mois, Date_début = P.date_début }).ToList();

            }
            catch (Exception X)
            {

                MessageBox.Show(X.Message);
            }


        }

        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=assurance;Integrated Security=True");
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Moto where Immatriculation = '" + gunaTextBox2.Text + "'", con);
                sda.Fill(dt);
                byte[] mydata = new byte[0];
                mydata = (byte[])dt.Rows[0][5];
                MemoryStream str = new MemoryStream(mydata);
                pictureBox1.Image = Image.FromStream(str);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                throw;
            }
            //var st =  (form s in db.BinaryImageTabs where s.Immatriculation == gunaTextBox1.Text select s).first();

        }
    }
}
