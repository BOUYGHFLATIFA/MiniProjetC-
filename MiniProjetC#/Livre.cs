namespace MiniProjetC_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Livre")]
    public partial class Livre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livre()
        {
            Emprunt = new HashSet<Emprunt>();
        }

        public Livre(string titre)
        {
            this.titre = titre;
        }

        public Livre(string isbn, string titre, string nbreExemplaire1, string nbrePages1, string datePublication, string resume)
        {
            Isbn = isbn;
            this.titre = titre;
            this.datePublication = datePublication;
            this.resume = resume;
        }

        [Key]
        public int idLivre { get; set; }

        [StringLength(50)]
        public string Isbn { get; set; }

        [StringLength(50)]
        public string titre { get; set; }

        public int? nbreExemplaire { get; set; }

        public int? nbrePages { get; set; }

        [StringLength(50)]
        public string datePublication { get; set; }

        [StringLength(50)]
        public string resume { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprunt> Emprunt { get; set; }
    }
}
