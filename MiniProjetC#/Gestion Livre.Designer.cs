namespace MiniProjetC_
{
    partial class Gestion_Livre
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
            this.Isbn = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.nbrExemp = new System.Windows.Forms.Label();
            this.nbrPages = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.resume = new System.Windows.Forms.Label();
            this.textIsbn = new System.Windows.Forms.TextBox();
            this.texttitre = new System.Windows.Forms.TextBox();
            this.textNbrExemp = new System.Windows.Forms.TextBox();
            this.textNbrPages = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textResume = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isbnn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbreExemplaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrePages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Isbn
            // 
            this.Isbn.AutoSize = true;
            this.Isbn.Location = new System.Drawing.Point(32, 34);
            this.Isbn.Name = "Isbn";
            this.Isbn.Size = new System.Drawing.Size(44, 20);
            this.Isbn.TabIndex = 1;
            this.Isbn.Text = "Isbn:";
            this.Isbn.Click += new System.EventHandler(this.label2_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(32, 91);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(40, 20);
            this.titre.TabIndex = 2;
            this.titre.Text = "titre:";
            // 
            // nbrExemp
            // 
            this.nbrExemp.AutoSize = true;
            this.nbrExemp.Location = new System.Drawing.Point(31, 142);
            this.nbrExemp.Name = "nbrExemp";
            this.nbrExemp.Size = new System.Drawing.Size(119, 20);
            this.nbrExemp.TabIndex = 3;
            this.nbrExemp.Text = "nbr-Exemplaire:";
            // 
            // nbrPages
            // 
            this.nbrPages.AutoSize = true;
            this.nbrPages.Location = new System.Drawing.Point(31, 196);
            this.nbrPages.Name = "nbrPages";
            this.nbrPages.Size = new System.Drawing.Size(86, 20);
            this.nbrPages.TabIndex = 4;
            this.nbrPages.Text = "nbr-Pages:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(31, 248);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(78, 20);
            this.date.TabIndex = 5;
            this.date.Text = "date-Pub:";
            // 
            // resume
            // 
            this.resume.AutoSize = true;
            this.resume.Location = new System.Drawing.Point(32, 306);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(66, 20);
            this.resume.TabIndex = 6;
            this.resume.Text = "resume:";
            // 
            // textIsbn
            // 
            this.textIsbn.Location = new System.Drawing.Point(172, 34);
            this.textIsbn.Name = "textIsbn";
            this.textIsbn.Size = new System.Drawing.Size(172, 26);
            this.textIsbn.TabIndex = 8;
            // 
            // texttitre
            // 
            this.texttitre.Location = new System.Drawing.Point(172, 85);
            this.texttitre.Name = "texttitre";
            this.texttitre.Size = new System.Drawing.Size(172, 26);
            this.texttitre.TabIndex = 9;
            // 
            // textNbrExemp
            // 
            this.textNbrExemp.Location = new System.Drawing.Point(172, 142);
            this.textNbrExemp.Name = "textNbrExemp";
            this.textNbrExemp.Size = new System.Drawing.Size(172, 26);
            this.textNbrExemp.TabIndex = 10;
            // 
            // textNbrPages
            // 
            this.textNbrPages.Location = new System.Drawing.Point(172, 196);
            this.textNbrPages.Name = "textNbrPages";
            this.textNbrPages.Size = new System.Drawing.Size(172, 26);
            this.textNbrPages.TabIndex = 11;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(172, 248);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(172, 26);
            this.textDate.TabIndex = 12;
            // 
            // textResume
            // 
            this.textResume.Location = new System.Drawing.Point(172, 300);
            this.textResume.Name = "textResume";
            this.textResume.Size = new System.Drawing.Size(172, 26);
            this.textResume.TabIndex = 13;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.Sienna;
            this.Ajouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ajouter.Location = new System.Drawing.Point(46, 382);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(182, 56);
            this.Ajouter.TabIndex = 15;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.Sienna;
            this.Modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Modifier.Location = new System.Drawing.Point(269, 382);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(183, 56);
            this.Modifier.TabIndex = 16;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.Sienna;
            this.Supprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Supprimer.Location = new System.Drawing.Point(513, 382);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(202, 56);
            this.Supprimer.TabIndex = 17;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivre,
            this.Isbnn,
            this.Titree,
            this.nbreExemplaire,
            this.nbrePages,
            this.datePublication,
            this.resumé});
            this.dataGridView1.Location = new System.Drawing.Point(407, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(663, 314);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(401, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Liste des Livres :";
            // 
            // idLivre
            // 
            this.idLivre.HeaderText = "idLivre";
            this.idLivre.MinimumWidth = 8;
            this.idLivre.Name = "idLivre";
            this.idLivre.Width = 150;
            // 
            // Isbnn
            // 
            this.Isbnn.HeaderText = "Isbn";
            this.Isbnn.MinimumWidth = 8;
            this.Isbnn.Name = "Isbnn";
            this.Isbnn.Width = 150;
            // 
            // Titree
            // 
            this.Titree.HeaderText = "Titre";
            this.Titree.MinimumWidth = 8;
            this.Titree.Name = "Titree";
            this.Titree.Width = 150;
            // 
            // nbreExemplaire
            // 
            this.nbreExemplaire.HeaderText = "nbreExemplaire";
            this.nbreExemplaire.MinimumWidth = 8;
            this.nbreExemplaire.Name = "nbreExemplaire";
            this.nbreExemplaire.Width = 150;
            // 
            // nbrePages
            // 
            this.nbrePages.HeaderText = "nbrePages";
            this.nbrePages.MinimumWidth = 8;
            this.nbrePages.Name = "nbrePages";
            this.nbrePages.Width = 150;
            // 
            // datePublication
            // 
            this.datePublication.HeaderText = "datePublication";
            this.datePublication.MinimumWidth = 8;
            this.datePublication.Name = "datePublication";
            this.datePublication.Width = 150;
            // 
            // resumé
            // 
            this.resumé.HeaderText = "resume";
            this.resumé.MinimumWidth = 8;
            this.resumé.Name = "resumé";
            this.resumé.Width = 150;
            // 
            // Gestion_Livre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.textResume);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textNbrPages);
            this.Controls.Add(this.textNbrExemp);
            this.Controls.Add(this.texttitre);
            this.Controls.Add(this.textIsbn);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.date);
            this.Controls.Add(this.nbrPages);
            this.Controls.Add(this.nbrExemp);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.Isbn);
            this.Name = "Gestion_Livre";
            this.Text = "Gestion Livre";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Isbn;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label nbrExemp;
        private System.Windows.Forms.Label nbrPages;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label resume;
        private System.Windows.Forms.TextBox textIsbn;
        private System.Windows.Forms.TextBox texttitre;
        private System.Windows.Forms.TextBox textNbrExemp;
        private System.Windows.Forms.TextBox textNbrPages;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textResume;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbnn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titree;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbreExemplaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrePages;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePublication;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumé;
    }
}