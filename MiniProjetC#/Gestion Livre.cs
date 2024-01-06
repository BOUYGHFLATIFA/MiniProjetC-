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
    public partial class Gestion_Livre : Form
    {
        string parametres = "Data Source=DESKTOP-7QON5IO;Initial Catalog=library;User Id=utilisateur;Password=12345678;";
        private SqlConnection maconnexion;
        DataTable dataTable = new DataTable();
        DataGridViewRow currRow;
        public Gestion_Livre()
        {
            InitializeComponent();
            loadLivreTable();
        }

        public void loadLivreTable()
        {
            maconnexion = new SqlConnection(parametres);
            maconnexion.Open();
            string request = "select * from Livre";
            SqlCommand cmd = new SqlCommand(request, maconnexion);

            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                int idLivre = reader.GetInt32(reader.GetOrdinal("idLivre"));
                string Isbn = reader.GetString(reader.GetOrdinal("Isbn"));
                string titre = reader.GetString(reader.GetOrdinal("titre"));
                int nbreExemplaire = reader.GetInt32(reader.GetOrdinal("nbreExemplaire"));
                int nbrePages = reader.GetInt32(reader.GetOrdinal("nbrePages"));
                string datePublication = reader.GetString(reader.GetOrdinal("datePublication"));
                string resume = reader.GetString(reader.GetOrdinal("resume"));


                dataGridView1.Rows.Add(idLivre, Isbn, titre, nbreExemplaire, nbrePages, datePublication,resume);
            }


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string Isbn = textIsbn.Text;
            string titre = texttitre.Text;
            string nbreExemplaire = textNbrExemp.Text;
            string nbrePages = textNbrPages.Text;
            string datePublication = textDate.Text;
            string resume = textResume.Text;


            if (Isbn == "" || titre == "" || nbreExemplaire == "" || nbrePages == "" || datePublication == "" || resume == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Livre LIVRE = new Livre(Isbn, titre, nbreExemplaire, nbrePages, datePublication, resume);

                maconnexion = new SqlConnection(parametres);
                maconnexion.Open();
                SqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "INSERT INTO Livre " +
                    "VALUES(@Isbn, @titre,@nbreExemplaire,@nbrePages,@datePublication,@resume)";
                cmd.Parameters.AddWithValue("@Isbn", textIsbn.Text);
                cmd.Parameters.AddWithValue("@titre", texttitre.Text);
                cmd.Parameters.AddWithValue("@nbreExemplaire", textNbrExemp.Text);
                cmd.Parameters.AddWithValue("@nbrePages", textNbrPages.Text);
                cmd.Parameters.AddWithValue("@datePublication", textDate.Text);
                cmd.Parameters.AddWithValue("@resume", textResume.Text);



                cmd.ExecuteNonQuery();
                maconnexion.Close();
                textIsbn.Clear(); texttitre.Clear(); textNbrExemp.Clear(); textNbrPages.Clear(); textDate.Clear(); textResume.Clear();
            }
            loadLivreTable();
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            string Isbn = textIsbn.Text;
            string titre = texttitre.Text;
            string nbreExemplaire = textNbrExemp.Text;
            string nbrePages = textNbrPages.Text;
            string datePublication = textDate.Text;
            string resume = textResume.Text;


            if (Isbn == "" || titre == "" || nbreExemplaire == "" || nbrePages == "" || datePublication == "" || resume == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult dialogUpdate = MessageBox.Show("voulez-vous vraiment modifier ce livre ", "Modifier un livre", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogUpdate == DialogResult.OK)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;

                    maconnexion = new SqlConnection(parametres);
                    maconnexion.Open();

                    SqlCommand cmd = maconnexion.CreateCommand();
                    cmd.CommandText = "UPDATE Livre SET Isbn= @Isbn, titre=@titre, nbreExemplaire=@nbreExemplaire,nbrePages=@nbrePages,datePublication=@datePublication,resume=@resume" +
                                           " WHERE idLivre=" + this.currRow.Cells[0].Value;
                    cmd.Parameters.AddWithValue("@Isbn", textIsbn.Text);
                    cmd.Parameters.AddWithValue("@titre", texttitre.Text);
                    cmd.Parameters.AddWithValue("@nbreExemplaire", textNbrExemp.Text);
                    cmd.Parameters.AddWithValue("@nbrePages", textNbrPages.Text);
                    cmd.Parameters.AddWithValue("@datePublication", textDate.Text);
                    cmd.Parameters.AddWithValue("@resume", textResume.Text);

                    cmd.ExecuteNonQuery();
                    maconnexion.Close();
                    textIsbn.Clear(); texttitre.Clear(); textNbrExemp.Clear(); textNbrPages.Clear(); textDate.Clear(); textResume.Clear();

                    loadLivreTable();
                }
            }
        }
        private void Supprimer_Click(object sender, EventArgs e)
        {
            string Isbn = textIsbn.Text;
            string titre = texttitre.Text;
            string nbreExemplaire = textNbrExemp.Text;
            string nbrePages = textNbrPages.Text;
            string datePublication = textDate.Text;
            string resume = textResume.Text;


            if (Isbn == "" || titre == "" || nbreExemplaire == "" || nbrePages == "" || datePublication == "" || resume == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer ce livre", "Supprimer un livre", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogDelete == DialogResult.OK)
                {
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    maconnexion = new SqlConnection(parametres);
                    maconnexion.Open();
                    SqlCommand cmd = maconnexion.CreateCommand();
                    cmd.CommandText = "DELETE FROM Livre WHERE idLivre=" + this.currRow.Cells[0].Value;
                    cmd.ExecuteNonQuery();
                    maconnexion.Close();
                    loadLivreTable();
                    textIsbn.Clear(); texttitre.Clear(); textNbrExemp.Clear(); textNbrPages.Clear(); textDate.Clear(); textResume.Clear();
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
                textIsbn.Text = row.Cells[1].Value.ToString();
                texttitre.Text = row.Cells[2].Value.ToString();
                textNbrExemp.Text = row.Cells[3].Value.ToString();
                textNbrPages.Text = row.Cells[4].Value.ToString();
                textDate.Text = row.Cells[5].Value.ToString();
                textResume.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}

