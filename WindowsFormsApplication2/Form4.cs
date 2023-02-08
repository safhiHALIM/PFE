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
    public partial class Form4 : Form
    {
        string text;

        static string c = "Data Source=.;Initial Catalog=assurance;Integrated Security=True";
        SqlConnection con = new SqlConnection(c);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader lect = null;
       
        public void afficher()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Client";
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dataGridView1.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString(), lect.GetValue(5).ToString(), lect.GetValue(6).ToString(), lect.GetValue(7).ToString(), lect.GetValue(8).ToString(), lect.GetValue(9).ToString());
            }
            lect.Close();
            con.Close();
        }


        public Form4()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                if (gunaImageRadioButton1.Checked)
                {
                    text = "female";
                }
                else if (gunaImageRadioButton2.Checked)
                {
                    text = "male";
                }
                con.Open();
                cmd = new SqlCommand("insert into Client values('" + gunaTextBox1.Text + "', '" + gunaTextBox2.Text + "','" + gunaTextBox3.Text + "'," + int.Parse(gunaTextBox4.Text) + ",'" + gunaTextBox5.Text + "','" + text + "'," + int.Parse(gunaTextBox6.Text) + ",'" + gunaTextBox7.Text + "','" + gunaTextBox8.Text + "','" + gunaComboBox1.Text + "');",con);
                cmd.ExecuteNonQuery();
                con.Close();
                afficher();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
          
            if (gunaComboBox1.Text=="Auto")
            {
                tableLayoutPanel6.Show();
                tableLayoutPanel6.Dock = DockStyle.Fill;
                tableLayoutPanel7.Hide();
                tableLayoutPanel8.Hide();
            }
            else if (gunaComboBox1.Text == "Moto")

            {
                tableLayoutPanel7.Show();
                tableLayoutPanel7.Dock = DockStyle.Fill;
                tableLayoutPanel8.Hide();
                tableLayoutPanel6.Hide();
            }
            else if(gunaComboBox1.Text=="Habitation")
            {
                tableLayoutPanel8.Show();
                tableLayoutPanel8.Dock = DockStyle.Fill;
                tableLayoutPanel7.Hide();
                tableLayoutPanel6.Hide();
            }
            else { MessageBox.Show("aucun Genre"); }

            if (gunaComboBox1.Text == "Auto")
            {
                label37.Text = "Auto";

            }
            else if (gunaComboBox1.Text == "Moto")

            {
                label37.Text = "Moto";

            }
            else if (gunaComboBox1.Text == "Habitation")
            {
                label37.Text = "Habitation";

            }

            gunaTextBox1.Text = "";
            gunaTextBox2.Text = "";
            gunaTextBox3.Text = "";
            gunaTextBox4.Text = "";
            gunaTextBox5.Text = "";
            gunaImageRadioButton1.Checked = false;
            gunaImageRadioButton2.Checked = false;
            gunaTextBox6.Text = "";
            gunaTextBox7.Text = "";
            gunaTextBox8.Text = "";
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tableLayoutPanel6.Hide();
            tableLayoutPanel7.Hide();
            tableLayoutPanel8.Hide();
            gunaAdvenceButton3.Enabled = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {
            afficher();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Client where CIN ='" + gunaTextBox9.Text + "'";
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dataGridView1.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString(), lect.GetValue(5).ToString(), lect.GetValue(6).ToString(), lect.GetValue(7).ToString(), lect.GetValue(8).ToString(), lect.GetValue(9).ToString());
                gunaAdvenceButton3.Enabled = true;
            }
            lect.Close();
            con.Close();
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("le Client n'existe pas");
                gunaAdvenceButton3.Enabled = false;

            }


        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("voulez-vous vraiment supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
               
                try
                {
                    string teq = "delete  from client where CIN='" + gunaTextBox9.Text + "'";
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

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (label37.Text=="Auto")
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select * from Client where CIN ='" + gunaTextBox10.Text + "'";
                lect = cmd.ExecuteReader();
                while (lect.Read())
                {
                    try
                    {
                        cmd = new SqlCommand("insert into Auto values('" + gunaTextBox14.Text + "', '" + gunaTextBox10.Text + "','" + gunaComboBox2.Text + "'," + int.Parse(gunaTextBox15.Text) + ",'" + gunaTextBox11.Text + "','" + gunaTextBox12.Text + "','" + gunaTextBox13.Text + "','" + int.Parse(gunaComboBox3.Text) + "','" + gunaComboBox4.Text + "','" + gunaDateTimePicker1.Value + "');", con);
                        MessageBox.Show("ok");

                    }
                    catch (Exception x)
                    {
                        if (MessageBox.Show("Vérifier les Champs, voullez vous voir l'erreur ? ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                        { MessageBox.Show(x.Message); }
                        
                    }
                    
                }
                lect.Close();
                cmd.ExecuteNonQuery();
                con.Close();

                
            }
            else if (label37.Text=="Moto")
            {
                FileStream fl = new FileStream(gunaTextBox17.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] image = new byte[fl.Length];
                fl.Read(image, 0, Convert.ToInt32(fl.Length));
                fl.Close();

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select * from Client where CIN ='" + gunaTextBox16.Text + "'";
                lect = cmd.ExecuteReader();
                while (lect.Read())
                {
                    try
                    {
                        cmd = new SqlCommand("insert into Moto values('" + gunaTextBox18.Text + "', '" + gunaTextBox16.Text + "','" + gunaComboBox11.Text + "','" + gunaComboBox12.Text + "','" + gunaComboBox13.Text + "',@imag,'" + gunaComboBox5.Text + "'," + int.Parse(gunaComboBox6.Text) + ",'" + gunaComboBox7.Text + "','" + gunaDateTimePicker2.Value + "');", con);
                        SqlParameter prm = new SqlParameter("@imag",SqlDbType.VarBinary,image.Length,ParameterDirection.Input,false,0,0,null,DataRowVersion.Current,image);
                        cmd.Parameters.Add(prm);
                        MessageBox.Show("ok");

                    }
                    catch (Exception x)
                    {
                        if (MessageBox.Show("Vérifier les Champs, voullez vous voir l'erreur ? ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                        { MessageBox.Show(x.Message); }


                    }
                    
                }
                lect.Close();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if(label37.Text=="Habitation")
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select * from Client where CIN ='" + gunaTextBox111.Text + "'";
                lect = cmd.ExecuteReader();
                while (lect.Read())
                {
                    try
                    {
                        cmd = new SqlCommand("insert into habitation1 values('" + gunaTextBox121.Text + "', '" + gunaTextBox111.Text + "','" + gunaComboBox111.Text + "','" + gunaTextBox19.Text + "','" + gunaTextBox20.Text + "'," + int.Parse(gunaComboBox10.Text)+ ",'" + gunaComboBox8.Text + "','" + gunaDateTimePicker3.Value + "');", con);
                        MessageBox.Show("ok");

                    }
                    catch (Exception x)
                    {
                        if (MessageBox.Show("Vérifier les Champs, voullez vous voir l'erreur ? ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                        { MessageBox.Show(x.Message); }


                    }

                }
                lect.Close();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if(gunaComboBox2.Text == "Auto")
            {
                
                Form6 f = new Form6();
                f.TopMost = true;
                f.ShowDialog();
            }
            else if (gunaComboBox2.Text == "Moto")
            {
               
                DGV_moto f1 = new DGV_moto();
                f1.TopMost = true;
                f1.ShowDialog();
            }
            else if(gunaComboBox2.Text == "Habitation")
            {
                
                DGV_habitation f2 = new DGV_habitation();
                f2.TopMost = true;

                f2.ShowDialog();
            }
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gunaTextBox17.Text = openFileDialog1.FileName;
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
