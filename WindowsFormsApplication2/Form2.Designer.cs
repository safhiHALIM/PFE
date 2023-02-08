namespace WindowsFormsApplication2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laGestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déclarerAccidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertRisqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaGradientCircleButton3 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.gunaGradientCircleButton2 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.gunaGradientCircleButton1 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laGestionToolStripMenuItem,
            this.connexionToolStripMenuItem,
            this.plusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laGestionToolStripMenuItem
            // 
            this.laGestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientToolStripMenuItem,
            this.déclarerAccidentToolStripMenuItem,
            this.contratToolStripMenuItem});
            this.laGestionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laGestionToolStripMenuItem.Name = "laGestionToolStripMenuItem";
            this.laGestionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.laGestionToolStripMenuItem.Text = "La gestion";
            // 
            // gestionClientToolStripMenuItem
            // 
            this.gestionClientToolStripMenuItem.Name = "gestionClientToolStripMenuItem";
            this.gestionClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.gestionClientToolStripMenuItem.Text = "Gestion Client";
            this.gestionClientToolStripMenuItem.Click += new System.EventHandler(this.gestionClientToolStripMenuItem_Click);
            // 
            // déclarerAccidentToolStripMenuItem
            // 
            this.déclarerAccidentToolStripMenuItem.Name = "déclarerAccidentToolStripMenuItem";
            this.déclarerAccidentToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.déclarerAccidentToolStripMenuItem.Text = "Déclarer Accident";
            this.déclarerAccidentToolStripMenuItem.Click += new System.EventHandler(this.déclarerAccidentToolStripMenuItem_Click);
            // 
            // contratToolStripMenuItem
            // 
            this.contratToolStripMenuItem.Name = "contratToolStripMenuItem";
            this.contratToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.contratToolStripMenuItem.Text = "Contrat";
            this.contratToolStripMenuItem.Click += new System.EventHandler(this.contratToolStripMenuItem_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauUtilisateurToolStripMenuItem,
            this.expertRisqueToolStripMenuItem});
            this.connexionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.connexionToolStripMenuItem.Text = "Paramétre";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // nouveauUtilisateurToolStripMenuItem
            // 
            this.nouveauUtilisateurToolStripMenuItem.Name = "nouveauUtilisateurToolStripMenuItem";
            this.nouveauUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nouveauUtilisateurToolStripMenuItem.Text = "nouveau utilisateur";
            this.nouveauUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.nouveauUtilisateurToolStripMenuItem_Click);
            // 
            // expertRisqueToolStripMenuItem
            // 
            this.expertRisqueToolStripMenuItem.Name = "expertRisqueToolStripMenuItem";
            this.expertRisqueToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.expertRisqueToolStripMenuItem.Text = "Expert & Risque";
            this.expertRisqueToolStripMenuItem.Click += new System.EventHandler(this.expertRisqueToolStripMenuItem_Click);
            // 
            // plusToolStripMenuItem
            // 
            this.plusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.plusToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plusToolStripMenuItem.Name = "plusToolStripMenuItem";
            this.plusToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.plusToolStripMenuItem.Text = "plus";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.àProposToolStripMenuItem.Text = "à propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.gunaGradientCircleButton3);
            this.panel2.Controls.Add(this.gunaGradientCircleButton2);
            this.panel2.Controls.Add(this.gunaGradientCircleButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1047, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 550);
            this.panel2.TabIndex = 2;
            // 
            // gunaGradientCircleButton3
            // 
            this.gunaGradientCircleButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton3.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton3.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaGradientCircleButton3.BaseColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.gunaGradientCircleButton3.BorderColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton3.BorderSize = 1;
            this.gunaGradientCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientCircleButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton3.Image = null;
            this.gunaGradientCircleButton3.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton3.Location = new System.Drawing.Point(4, 62);
            this.gunaGradientCircleButton3.Name = "gunaGradientCircleButton3";
            this.gunaGradientCircleButton3.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption;
            this.gunaGradientCircleButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaGradientCircleButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton3.OnHoverImage = null;
            this.gunaGradientCircleButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton3.Size = new System.Drawing.Size(21, 21);
            this.gunaGradientCircleButton3.TabIndex = 8;
            this.gunaGradientCircleButton3.Click += new System.EventHandler(this.gunaGradientCircleButton3_Click);
            // 
            // gunaGradientCircleButton2
            // 
            this.gunaGradientCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton2.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton2.BaseColor1 = System.Drawing.Color.Red;
            this.gunaGradientCircleButton2.BaseColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.gunaGradientCircleButton2.BorderColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton2.BorderSize = 1;
            this.gunaGradientCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton2.Image = null;
            this.gunaGradientCircleButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton2.Location = new System.Drawing.Point(4, 6);
            this.gunaGradientCircleButton2.Name = "gunaGradientCircleButton2";
            this.gunaGradientCircleButton2.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.gunaGradientCircleButton2.OnHoverBaseColor2 = System.Drawing.Color.Red;
            this.gunaGradientCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton2.OnHoverImage = null;
            this.gunaGradientCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton2.Size = new System.Drawing.Size(21, 21);
            this.gunaGradientCircleButton2.TabIndex = 7;
            this.gunaGradientCircleButton2.Click += new System.EventHandler(this.gunaGradientCircleButton2_Click);
            // 
            // gunaGradientCircleButton1
            // 
            this.gunaGradientCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton1.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton1.BaseColor1 = System.Drawing.Color.Lime;
            this.gunaGradientCircleButton1.BaseColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.gunaGradientCircleButton1.BorderColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.BorderSize = 1;
            this.gunaGradientCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.Image = null;
            this.gunaGradientCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton1.Location = new System.Drawing.Point(4, 34);
            this.gunaGradientCircleButton1.Name = "gunaGradientCircleButton1";
            this.gunaGradientCircleButton1.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption;
            this.gunaGradientCircleButton1.OnHoverBaseColor2 = System.Drawing.Color.Lime;
            this.gunaGradientCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.OnHoverImage = null;
            this.gunaGradientCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.Size = new System.Drawing.Size(21, 21);
            this.gunaGradientCircleButton1.TabIndex = 6;
            this.gunaGradientCircleButton1.Click += new System.EventHandler(this.gunaGradientCircleButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1075, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laGestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton1;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton2;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton3;
        private System.Windows.Forms.ToolStripMenuItem gestionClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déclarerAccidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertRisqueToolStripMenuItem;
    }
}