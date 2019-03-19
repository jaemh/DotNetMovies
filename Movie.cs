using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies
{

    public class Movie
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //will be generated when the value is added to the database
        public int Id { get; set; }

        [Required] //not null
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }



    }

}


