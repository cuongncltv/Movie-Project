namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Showing_Schedule
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Movie_Showing_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Showing_Date { get; set; }

        [Key]
        [Column("Showing_Schedule", Order = 2)]
        public TimeSpan Showing_Schedule1 { get; set; }

        public virtual Showings Showings { get; set; }
    }
}
