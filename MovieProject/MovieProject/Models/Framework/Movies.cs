namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movies()
        {
            Movie_Ratings = new HashSet<Movie_Ratings>();
            Showings = new HashSet<Showings>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Movie_ID { get; set; }

        [StringLength(50)]
        public string Movie_Name_Eng { get; set; }

        [StringLength(50)]
        public string Movie_Name_Vie { get; set; }

        [Required]
        [StringLength(50)]
        public string Movie_Director { get; set; }

        [Required]
        [StringLength(50)]
        public string Movie_Cast { get; set; }

        [Required]
        [StringLength(50)]
        public string Movie_Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Movie_Genre { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Movie_Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime Movie_ReleaseDay { get; set; }

        [StringLength(50)]
        public string Movie_Trailer { get; set; }

        [MaxLength(50)]
        public byte[] Movie_Picture { get; set; }

        public bool Movie_Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie_Ratings> Movie_Ratings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Showings> Showings { get; set; }
    }
}
