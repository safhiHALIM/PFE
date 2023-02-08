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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form

    {
    //    private assuranceEntities a1;
    //    connexion c = new connexion();
        public Form1()
        {
            InitializeComponent();
            //a1 = new assuranceEntities();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=assurance;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            cn.Open();
            //  cmd = new SqlCommand("select * from utilisateur  where username = '" + gunaTextBox1 + "' and password = '" + gunaTextBox2 + "'", cn);
           string query = "select * from Utilisateur  where Usermane = '" + gunaTextBox1.Text.Trim() + "' and password = '" + gunaTextBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1 )
            {
                Form2 f = new Form2();
                f.Show();
                cn.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("vérifier l'identifiant ou le mot de passe " ,"échec de la connexion" ,MessageBoxButtons.OK,MessageBoxIcon.None);
                cn.Close();
            }

       
        }

        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
