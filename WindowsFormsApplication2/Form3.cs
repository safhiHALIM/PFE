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
    public partial class Form3 : Form
    {
        public Form3()
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
            cmd.CommandText = "select * from Accident";
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dataGridView1.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString(), lect.GetValue(5).ToString());
            }
            lect.Close();
            con.Close();

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Accident values('" + gunaTextBox1.Text + "', '" + gunaTextBox2.Text+ "','"+dateTimePicker1.Value + "','" + gunaTextBox3.Text + "','" + gunaTextBox4.Text + "','" + gunaTextBox5.Text + "');", con);
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
            if (MessageBox.Show("voulez-vous vraiment supprimer les info de cette Accident ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    string teq = "delete  from Accident where [Code Accident]='" + gunaTextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(teq, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();

                    afficher();
                }
                catch
                {
                    MessageBox.Show("Accident n'existe pas");
                }
            }
        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
