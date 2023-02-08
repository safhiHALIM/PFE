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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=assurance;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader lect = null;
       bool ok1 = true; 
        
        public void afficher()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Contrat";
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dataGridView1.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString(),lect.GetValue(5).ToString(),lect.GetValue(6).ToString());
            }
            lect.Close();
            con.Close();

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string rq = " select [Code de produit] from Produit1";
            SqlDataAdapter daE = new SqlDataAdapter(rq, con);
            DataTable te = new DataTable();
            daE.Fill(te);
            ok1 = false;
            gunaComboBox1.DataSource = te;
            gunaComboBox1.ValueMember = "Code de produit";
            gunaComboBox1.DisplayMember = "Nom de produit";
            ok1 = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Contrat values('" + gunaTextBox1.Text + "', '" + gunaComboBox1.Text + "'," + int.Parse(gunaTextBox3.Text) + ",'" + gunaTextBox4.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + gunaTextBox7.Text + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                afficher();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
               // throw;
            }
            gunaTextBox1.Text = "";
            gunaTextBox3.Text = "";
            gunaTextBox4.Text = "";

            gunaTextBox7.Text = "";


        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            afficher();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            con.Close();
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Contrat where [N contrat] ='" + gunaTextBox5.Text + "'";
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dataGridView1.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString(), lect.GetValue(5).ToString(), lect.GetValue(6).ToString());
            }
            lect.Close();
            con.Close();
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("contrat n'existe pas");

            }
            gunaTextBox5.Text = "";
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous vraiment supprimer cette contrat ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
           
                try
                {
                    string teq = "delete  from Contrat where [N contrat]='" + gunaTextBox5.Text + "'";
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

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
