namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int News_ID { get; set; }

        [StringLength(100)]
        public string News_Title { get; set; }

        [Column(TypeName = "text")]
        public string News_Content { get; set; }
    }
}
