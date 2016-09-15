namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Showings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Showings()
        {
            Showing_Schedule = new HashSet<Showing_Schedule>();
        }

        [Key]
        public int Movie_Showing_ID { get; set; }

        public int Cinema_ID { get; set; }

        public int Movie_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Showing_From_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime Showing_To_Date { get; set; }

        [Required]
        [StringLength(10)]
        public string Showing_Type { get; set; }

        public virtual Cinemas Cinemas { get; set; }

        public virtual Movies Movies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Showing_Schedule> Showing_Schedule { get; set; }
    }
}
