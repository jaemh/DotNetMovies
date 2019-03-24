using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Model
{

    public class BookingTable
    {

        public int Id { get; set; }
        public int SeatNo { get; set; }
        public int UserId { get; set; }
        public DateTime time { get; set; }

        public int MovieId { get; set; }

        public int price { get; set; }

        [ForeignKey("MovieDetailsId")]
        public virtual MovieDetails moviedetails { get; set; } //BookingTable has one movie

    }
}