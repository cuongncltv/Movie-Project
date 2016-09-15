namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admins
    {
        [Key]
        public int Admin_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Admin_Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Admin_Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Admin_Name { get; set; }
    }
}
