namespace MovieProject.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seats
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Room_ID { get; set; }

        public int Cinema_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Row_Number { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seat_Count { get; set; }

        [Required]
        [StringLength(10)]
        public string Seat_Type { get; set; }

        public bool? Seat_Status { get; set; }

        public virtual Cinemas Cinemas { get; set; }
    }
}
