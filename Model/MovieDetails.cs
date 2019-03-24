using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Model
{


    public class MovieDetails
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //will be generated when the value is added to the database
        public int Id { get; set; }

        [Required] //not null
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        public string Description { get; set; }

        public DateTime DateAndTime { get; set; }

        public string Pictures { get; set; }

        public virtual ICollection<BookingTable> bookings { get; set; } //Movie has many bookings

    }
}
