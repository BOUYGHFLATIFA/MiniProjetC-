using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniProjetC_
{
    
    public partial class Gestion_des_emprunts : Form
    {
        string parametres = "Data Source=DESKTOP-7QON5IO;Initial Catalog=library;User Id=utilisateur;Password=12345678;";
        private SqlConnection maconnexion;
        DataTable dataTable = new DataTable();
        DataGridViewRow currRow;
        public Gestion_des_emprunts()
        {
            InitializeComponent();
            loadEmpruntTable();
        }
        
        
        public void loadEmpruntTable()
        {
            maconnexion = new SqlConnection(parametres);
            maconnexion.Open();
            string request = "select * from Emprunt";
            SqlCommand cmd = new SqlCommand(request, maconnexion);

            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                int idAd = reader.GetInt32(reader.GetOrdinal("idAd"));
                int idLivre = reader.GetInt32(reader.GetOrdinal("idLivre"));
                DateTime dateEmprunt = reader.GetDateTime(reader.GetOrdinal("dateEmprunt"));
                DateTime dateRetourPrevu = reader.GetDateTime(reader.GetOrdinal("dateRetourPrevu"));
                DateTime dateRetourEffective = reader.GetDateTime(reader.GetOrdinal("dateRetourEffective"));
                dataGridView1.Rows.Add(idAd,idLivre,dateEmprunt, dateRetourPrevu, dateRetourEffective);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                this.currRow = row;
                textEmprunteur.Text = row.Cells[1].Value.ToString();
                textLivre.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                dateTimePicker2.Text = row.Cells[4].Value.ToString();
                dateTimePicker3.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Emprunter_Click(object sender, EventArgs e)
        {
            string idAd = textEmprunteur.Text;
            string idLivre = textLivre.Text;
            string dateEmprunt = dateTimePicker1.Text;
            string dateRetourPrevu = dateTimePicker2.Text;
            string dateRetourEffective = dateTimePicker3.Text;

            if (string.IsNullOrWhiteSpace(idAd) || string.IsNullOrWhiteSpace(idLivre) || string.IsNullOrWhiteSpace(dateEmprunt) || string.IsNullOrWhiteSpace(dateRetourPrevu) || string.IsNullOrWhiteSpace(dateRetourEffective))
            {
                MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection maconnexion = new SqlConnection(parametres))
                {
                    maconnexion.Open();
                    using (SqlCommand cmd = maconnexion.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Emprunt (idAd, idLivre, dateEmprunt, dateRetourPrevu, dateRetourEffective) " +
                                          "VALUES (@idAd, @idLivre, @dateEmprunt, @dateRetourPrevu, @dateRetourEffective)";

                        cmd.Parameters.AddWithValue("@idAd", int.Parse(idAd)); // Assurez-vous que idAd est convertible en entier
                        cmd.Parameters.AddWithValue("@idLivre", int.Parse(idLivre)); // Assurez-vous que idLivre est convertible en entier
                        cmd.Parameters.AddWithValue("@dateEmprunt", DateTime.Parse(dateEmprunt));
                        cmd.Parameters.AddWithValue("@dateRetourPrevu", DateTime.Parse(dateRetourPrevu));
                        cmd.Parameters.AddWithValue("@dateRetourEffective", DateTime.Parse(dateRetourEffective));

                        cmd.ExecuteNonQuery();
                    }
                }

                textEmprunteur.Clear();
                textLivre.Clear();
                loadEmpruntTable();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

