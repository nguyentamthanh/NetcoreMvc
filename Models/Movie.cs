using System;
using System.ComponentModel.DataAnnotations;

namespace PROJECT_DEMO.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Column(Typename="nvarcha(50)")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        //abcxyz@gmail.com 
        [EmailAddress]
        public string Email { get; set; }
    }
}