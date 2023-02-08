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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            //this.BackColor = Color.Beige;
            // gunaGradientPanel1.Dock = DockStyle.Fill;
            //gunaPanel2.Hide();
            //gunaPanel1.Anchor = AnchorStyles.Right;
            // gunaPanel1.Anchor = AnchorStyles.Top;

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form5")
                {
                    isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (isopen == false)
            {
                Form5 ff = new Form5();
                ff.MdiParent = this;
                ff.Dock = DockStyle.Fill;
                // f3.Anchor = AnchorStyles.None;
                ff.Show();
            }
        }

        private void gunaGradientCircleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                TopMost = true;

            }

        }

        private void gunaGradientCircleButton2_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Close();
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleProgressBar3_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gestionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    this.WindowState = FormWindowState.Maximized;

            //}

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form4")
                {
                    isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (isopen == false)
            {
                Form4 f1 = new Form4();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                // f3.Anchor = AnchorStyles.None;
                f1.Show();
            }
        }

        private void laideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void déclarerAccidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form3")
                {
                    isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (isopen == false)
            {
                Form3 f3 = new Form3();
                f3.MdiParent = this;
                f3.Dock = DockStyle.Fill;
                // f3.Anchor = AnchorStyles.None;
                f3.Show();
            }
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form8")
                {
                    isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (isopen == false)
            {
                Form8 f1 = new Form8();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                // f3.Anchor = AnchorStyles.None;
                f1.Show();
            }
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expertRisqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Expert form")
                {
                    isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (isopen == false)
            {
                Expert_form f1 = new Expert_form();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                // f3.Anchor = AnchorStyles.None;
                f1.Show();
            }
        }

        private void nouveauUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form7")
                {
                    isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (isopen == false)
            {
                Form7 f10 = new Form7();
                f10.MdiParent = this;
                f10.Dock = DockStyle.Fill;
                // f3.Anchor = AnchorStyles.None;
                f10.Show();
            }
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form9")
                {
                    isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (isopen == false)
            {
                Form9 f10 = new Form9();
                f10.MdiParent = this;
                f10.Dock = DockStyle.Fill;
                // f3.Anchor = AnchorStyles.None;
                f10.Show();
            }
        }
    }
}
