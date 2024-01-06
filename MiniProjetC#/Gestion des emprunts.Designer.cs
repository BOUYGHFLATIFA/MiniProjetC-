namespace MiniProjetC_
{
    partial class Gestion_des_emprunts
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
            this.label1 = new System.Windows.Forms.Label();
            this.textEmprunteur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLivre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.Emprunter = new System.Windows.Forms.Button();
            this.idEmpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRetourPrevu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRetourEff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "idEmprunteur :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textEmprunteur
            // 
            this.textEmprunteur.Location = new System.Drawing.Point(164, 33);
            this.textEmprunteur.Name = "textEmprunteur";
            this.textEmprunteur.Size = new System.Drawing.Size(154, 26);
            this.textEmprunteur.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "idLivre";
            // 
            // textLivre
            // 
            this.textLivre.Location = new System.Drawing.Point(164, 93);
            this.textLivre.Name = "textLivre";
            this.textLivre.Size = new System.Drawing.Size(154, 26);
            this.textLivre.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpr,
            this.idLivre,
            this.DateEmprunt,
            this.DateRetourPrevu,
            this.DateRetourEff});
            this.dataGridView1.Location = new System.Drawing.Point(164, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(815, 321);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "DateEmprunt :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "DateRetourPrévu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "DateRetourEffective :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(766, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(275, 26);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(766, 92);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(275, 26);
            this.dateTimePicker3.TabIndex = 12;
            // 
            // Emprunter
            // 
            this.Emprunter.BackColor = System.Drawing.Color.Sienna;
            this.Emprunter.ForeColor = System.Drawing.Color.White;
            this.Emprunter.Location = new System.Drawing.Point(690, 165);
            this.Emprunter.Name = "Emprunter";
            this.Emprunter.Size = new System.Drawing.Size(160, 58);
            this.Emprunter.TabIndex = 13;
            this.Emprunter.Text = "Ajouter Emprunt";
            this.Emprunter.UseVisualStyleBackColor = false;
            this.Emprunter.Click += new System.EventHandler(this.Emprunter_Click);
            // 
            // idEmpr
            // 
            this.idEmpr.HeaderText = "idEmpr";
            this.idEmpr.MinimumWidth = 8;
            this.idEmpr.Name = "idEmpr";
            this.idEmpr.Width = 150;
            // 
            // idLivre
            // 
            this.idLivre.HeaderText = "idLivre";
            this.idLivre.MinimumWidth = 8;
            this.idLivre.Name = "idLivre";
            this.idLivre.Width = 150;
            // 
            // DateEmprunt
            // 
            this.DateEmprunt.HeaderText = "DateEmprunt";
            this.DateEmprunt.MinimumWidth = 8;
            this.DateEmprunt.Name = "DateEmprunt";
            this.DateEmprunt.Width = 150;
            // 
            // DateRetourPrevu
            // 
            this.DateRetourPrevu.HeaderText = "DateRetourPrevu";
            this.DateRetourPrevu.MinimumWidth = 8;
            this.DateRetourPrevu.Name = "DateRetourPrevu";
            this.DateRetourPrevu.Width = 150;
            // 
            // DateRetourEff
            // 
            this.DateRetourEff.HeaderText = "DateRetourEff";
            this.DateRetourEff.MinimumWidth = 8;
            this.DateRetourEff.Name = "DateRetourEff";
            this.DateRetourEff.Width = 150;
            // 
            // Gestion_des_emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1131, 623);
            this.Controls.Add(this.Emprunter);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textLivre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEmprunteur);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_des_emprunts";
            this.Text = "Gestion_des_emprunts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEmprunteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLivre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button Emprunter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRetourPrevu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRetourEff;
    }
}