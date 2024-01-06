namespace MiniProjetC_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adherent")]
    public partial class Adherent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adherent()
        {
            Emprunt = new HashSet<Emprunt>();
        }

        public Adherent(string nom)
        {
            this.nom = nom;
        }

        public Adherent(string nom, string prenom, string email, string adresse, string telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.adresse = adresse;
            this.telephone = telephone;
        }

        [Key]
        public int idAd { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprunt> Emprunt { get; set; }
    }
}
