namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cinema_Group
    {
        [Key]
        public int Group_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Group_Name { get; set; }
    }
}
