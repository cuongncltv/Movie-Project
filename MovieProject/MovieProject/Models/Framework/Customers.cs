namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            Movie_Ratings = new HashSet<Movie_Ratings>();
        }

        [Key]
        public int Customer_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Name { get; set; }

        public int? Customer_Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Customer_Password { get; set; }

        [Required]
        [StringLength(100)]
        public string Customer_Email { get; set; }

        [MaxLength(50)]
        public byte[] Customer_Avatar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie_Ratings> Movie_Ratings { get; set; }
    }
}
