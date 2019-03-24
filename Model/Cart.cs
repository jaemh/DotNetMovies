using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Movies.Model
{


    public class Cart
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int CustomerId { get; set; }

        public string SeatNo { get; set; }

        public DateTime date { get; set; }

        public int price { get; set; }


    }
}