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
    public partial class Expert_form : Form
    {
        public Expert_form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=assurance;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader lect = null;

        public void afficher()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Expert";
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dataGridView1.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString());
            }
            lect.Close();
            con.Close();

        }
        public void afficher2()
        {
            dataGridView2.Rows.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from [Risque diver]";
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dataGridView2.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString());
            }
            lect.Close();
            con.Close();

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Expert values('" + gunaTextBox1.Text + "', '" + gunaTextBox2.Text + "','" + gunaTextBox3.Text + "','" + gunaTextBox4.Text + "','" + gunaTextBox5.Text + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                afficher();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                throw;
            }
            gunaTextBox1.Text = "";
            gunaTextBox2.Text = "";
            gunaTextBox3.Text = "";
            gunaTextBox4.Text = "";
            gunaTextBox5.Text = "";
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous vraiment supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                try
                {
                    string teq = "delete  from Expert where [Code expert]='" + gunaTextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(teq, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();
                    
                    afficher();
                }
                catch
                {
                    MessageBox.Show("le Client n'existe pas");
                }
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Expert_form_Load(object sender, EventArgs e)
        {
            tableLayoutPanel5.Enabled = false;
            tableLayoutPanel6.Enabled = false;
            tableLayoutPanel7.Enabled = false;
            tableLayoutPanel2.Enabled = false;

         
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into [Risque diver] values('" + gunaTextBox6.Text + "', '" + gunaTextBox7.Text + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                afficher2();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                throw;
            }
            gunaTextBox6.Text = "";
            gunaTextBox7.Text = "";

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous vraiment supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                try
                {
                    string teq = "delete  from [Risque diver] where [ID risques]='" + gunaTextBox6.Text + "'";
                    SqlCommand cmd = new SqlCommand(teq, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();
                    afficher();
                }
                catch
                {
                    MessageBox.Show("Id n'existe pas");
                }
            }
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            afficher2();
        }

        private void gunaImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel5.Enabled = true;
            tableLayoutPanel6.Enabled = true;
            tableLayoutPanel2.Enabled = false;
            tableLayoutPanel7.Enabled = false;
            dataGridView2.Rows.Clear();
        }

        private void gunaImageRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel2.Enabled = true;
            tableLayoutPanel7.Enabled = true;
            tableLayoutPanel5.Enabled = false;
            tableLayoutPanel6.Enabled = false;
            dataGridView1.Rows.Clear();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            afficher();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            afficher2();
        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
