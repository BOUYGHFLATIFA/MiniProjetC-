using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjetC_
{
    public partial class Gestion_Adhérent : Form
    {
        Adherent adh = new Adherent();
        string parametres = "Data Source=DESKTOP-7QON5IO;Initial Catalog=library;User Id=utilisateur;Password=12345678;";
        private SqlConnection maconnexion;
        DataTable dataTable = new DataTable();
        DataGridViewRow currRow;
        


        public Gestion_Adhérent()
        {
            InitializeComponent();
            loadAdherentTable();

        }
        public void loadAdherentTable()
        {
            maconnexion = new SqlConnection(parametres);
            maconnexion.Open();
            string request = "select * from Adherent";
            SqlCommand cmd = new SqlCommand(request, maconnexion);

            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                int idAd = reader.GetInt32(reader.GetOrdinal("idAd"));
                string nom = reader.GetString(reader.GetOrdinal("nom"));
                string prenom = reader.GetString(reader.GetOrdinal("prenom"));
                string email = reader.GetString(reader.GetOrdinal("email"));
                string adresse = reader.GetString(reader.GetOrdinal("adresse"));
                string telephone = reader.GetString(reader.GetOrdinal("telephone"));

                dataGridView1.Rows.Add(idAd, nom, prenom, email, adresse, telephone);
            }


        }


        private void Gestion_Adhérent_Load(object sender, EventArgs e)
        {
            maconnexion = new SqlConnection(parametres);
            maconnexion.Open();
            string request = "select * from Adherent";
            SqlCommand cmd = new SqlCommand(request, maconnexion);

            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                int idAd = reader.GetInt32(reader.GetOrdinal("idAd"));
                string nom = reader.GetString(reader.GetOrdinal("nom"));
                string prenom = reader.GetString(reader.GetOrdinal("prenom"));
                string email = reader.GetString(reader.GetOrdinal("email"));
                string adresse = reader.GetString(reader.GetOrdinal("adresse"));
                string telephone = reader.GetString(reader.GetOrdinal("telephone"));

                dataGridView1.Rows.Add(idAd, nom, prenom, email, adresse, telephone);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string prenom = textPrenom.Text;
            string email = textEmail.Text;
            string adresse = textAdresse.Text;
            string telephone = textTelephone.Text;


            if (nom == "" || prenom == "" || email == "" || adresse == "" || telephone == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Adherent adherent = new Adherent(nom, prenom, email, adresse, telephone);

                maconnexion = new SqlConnection(parametres);
                maconnexion.Open();
                SqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "INSERT INTO Adherent " +
                    "VALUES(@nom, @prenom,@email,@adresse,@telephone)";
                cmd.Parameters.AddWithValue("@nom", textNom.Text);
                cmd.Parameters.AddWithValue("@prenom", textPrenom.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@adresse", textAdresse.Text);
                cmd.Parameters.AddWithValue("@telephone", textTelephone.Text);


                cmd.ExecuteNonQuery();
                maconnexion.Close();
                textNom.Clear(); textPrenom.Clear(); textEmail.Clear(); textAdresse.Clear(); textTelephone.Clear();
            }
            loadAdherentTable();
        
    }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string prenom = textPrenom.Text;
            string email = textEmail.Text;
            string adresse = textAdresse.Text;
            string telephone = textTelephone.Text;


            if (nom == "" || prenom == "" || email == "" || adresse == "" || telephone == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult dialogUpdate = MessageBox.Show("voulez-vous vraiment modifier cet Adherent ", "Modifier un Adherent", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogUpdate == DialogResult.OK)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;

                    maconnexion = new SqlConnection(parametres);
                    maconnexion.Open();

                    SqlCommand cmd = maconnexion.CreateCommand();

                    cmd.CommandText = "UPDATE Adherent SET nom= @nom, prenom=@prenom, email=@email ,adresse=@adresse,telephone=@telephone" +
                        " WHERE idAd=" + this.currRow.Cells[0].Value;
                    cmd.Parameters.AddWithValue("@nom", textNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", textPrenom.Text);
                    cmd.Parameters.AddWithValue("@email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@adresse", textAdresse.Text);
                    cmd.Parameters.AddWithValue("@telephone", textTelephone.Text);

                    cmd.ExecuteNonQuery();
                    maconnexion.Close();
                    textNom.Clear(); textPrenom.Clear(); textEmail.Clear(); textAdresse.Clear(); textTelephone.Clear();

                    loadAdherentTable();
                }
            }
        }
      
        

        private void Supprimer_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string prenom = textPrenom.Text;
            string email = textEmail.Text;
            string adresse = textAdresse.Text;
            string telephone = textTelephone.Text;


            if (nom == "" || prenom == "" || email == "" || adresse == "" || telephone == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer cet adherent", "Supprimer un adherent", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogDelete == DialogResult.OK)
                {
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    maconnexion = new SqlConnection(parametres);
                    maconnexion.Open();
                    SqlCommand cmd = maconnexion.CreateCommand();
                    cmd.CommandText = "DELETE FROM Adherent WHERE idAd=" + this.currRow.Cells[0].Value;
                    cmd.ExecuteNonQuery();
                    maconnexion.Close();
                    loadAdherentTable();
                    textNom.Clear(); textPrenom.Clear(); textEmail.Clear(); textAdresse.Clear(); textTelephone.Clear();
                }
            }
        
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                this.currRow = row;
                textNom.Text = row.Cells[1].Value.ToString();
                textPrenom.Text = row.Cells[2].Value.ToString();
                textEmail.Text = row.Cells[3].Value.ToString();
                textAdresse.Text = row.Cells[4].Value.ToString();
                textTelephone.Text = row.Cells[5].Value.ToString();
            }
        
    }
    }
}
