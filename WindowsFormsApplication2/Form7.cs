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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=assurance;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader lect;

        public void afficher()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Utilisateur";
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dataGridView1.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString());
            }
            lect.Close();
            con.Close();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            afficher();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Utilisateur values('" + gunaTextBox1.Text + "', '" + gunaButton2.Text + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                afficher();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                // throw;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous vraiment supprimer cette contrat ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    string teq = "delete  from Utilisateur where Usermane='" + gunaTextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(teq, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();

                    afficher();
                }
                catch
                {
                    MessageBox.Show("Contrat n'existe pas");
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
