namespace MiniProjetC_
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
            this.employeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererEmployeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adherantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererAdherantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesEmpruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeToolStripMenuItem,
            this.adherantToolStripMenuItem,
            this.livreToolStripMenuItem,
            this.empruntToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeToolStripMenuItem
            // 
            this.employeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererEmployeToolStripMenuItem});
            this.employeToolStripMenuItem.Name = "employeToolStripMenuItem";
            this.employeToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.employeToolStripMenuItem.Text = "Employé";
            this.employeToolStripMenuItem.Click += new System.EventHandler(this.employeToolStripMenuItem_Click);
            // 
            // gererEmployeToolStripMenuItem
            // 
            this.gererEmployeToolStripMenuItem.Name = "gererEmployeToolStripMenuItem";
            this.gererEmployeToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.gererEmployeToolStripMenuItem.Text = "Gestion des Employés";
            this.gererEmployeToolStripMenuItem.Click += new System.EventHandler(this.gererEmployeToolStripMenuItem_Click);
            // 
            // adherantToolStripMenuItem
            // 
            this.adherantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererAdherantToolStripMenuItem});
            this.adherantToolStripMenuItem.Name = "adherantToolStripMenuItem";
            this.adherantToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.adherantToolStripMenuItem.Text = "Adhérent";
            this.adherantToolStripMenuItem.Click += new System.EventHandler(this.adherantToolStripMenuItem_Click);
            // 
            // gererAdherantToolStripMenuItem
            // 
            this.gererAdherantToolStripMenuItem.Name = "gererAdherantToolStripMenuItem";
            this.gererAdherantToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.gererAdherantToolStripMenuItem.Text = "Gestion des Adhérents";
            this.gererAdherantToolStripMenuItem.Click += new System.EventHandler(this.gererAdherantToolStripMenuItem_Click);
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererLivreToolStripMenuItem});
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.livreToolStripMenuItem.Text = "Livre";
            // 
            // gererLivreToolStripMenuItem
            // 
            this.gererLivreToolStripMenuItem.Name = "gererLivreToolStripMenuItem";
            this.gererLivreToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.gererLivreToolStripMenuItem.Text = "Gestion des Livres";
            this.gererLivreToolStripMenuItem.Click += new System.EventHandler(this.gererLivreToolStripMenuItem_Click);
            // 
            // empruntToolStripMenuItem
            // 
            this.empruntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEmpruntsToolStripMenuItem});
            this.empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            this.empruntToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.empruntToolStripMenuItem.Text = "Emprunt";
            this.empruntToolStripMenuItem.Click += new System.EventHandler(this.empruntToolStripMenuItem_Click);
            // 
            // gestionDesEmpruntsToolStripMenuItem
            // 
            this.gestionDesEmpruntsToolStripMenuItem.Name = "gestionDesEmpruntsToolStripMenuItem";
            this.gestionDesEmpruntsToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.gestionDesEmpruntsToolStripMenuItem.Text = "Gestion des Emprunts";
            this.gestionDesEmpruntsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesEmpruntsToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProjetC_.Properties.Resources.section1112;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Gestion de Bibliothèque";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererEmployeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adherantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererAdherantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem empruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEmpruntsToolStripMenuItem;
    }
}