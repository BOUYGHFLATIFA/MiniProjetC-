namespace MiniProjetC_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employe")]
    public partial class Employe
    {
        public Employe(string nom, string prenom, string email, string adresse, string telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.adresse = adresse;
            this.telephone = telephone;
        }

        [Key]
        public int idEmp { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string prenom { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(255)]
        public string adresse { get; set; }

        [StringLength(15)]
        public string telephone { get; set; }
    }
}
