namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cinemas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cinemas()
        {
            Seats = new HashSet<Seats>();
            Showings = new HashSet<Showings>();
        }

        [Key]
        public int Cinema_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Cinema_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Cinema_Address { get; set; }

        public int Cinema_Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Cinema_City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seats> Seats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Showings> Showings { get; set; }
    }
}
