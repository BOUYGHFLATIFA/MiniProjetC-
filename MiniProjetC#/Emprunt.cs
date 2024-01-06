namespace MiniProjetC_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Emprunt")]
    public partial class Emprunt
    {
        public Emprunt(string idAd1, string idLivre1, string dateEmprunt1, string dateRetourPrevu1, string dateRetourEffective1)
        {
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idAd { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLivre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateEmprunt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateRetourPrevu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateRetourEffective { get; set; }

        public virtual Adherent Adherent { get; set; }

        public virtual Livre Livre { get; set; }
    }
}
