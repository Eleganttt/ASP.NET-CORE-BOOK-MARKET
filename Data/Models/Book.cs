namespace BookMarket.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;
    public class Book
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(BookNameMaxLenght)]
        public string Name { get; init; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ImageURL { get; set; }


        [Required]
        public int PublishedOn { get; init; }


        [Required]
        [MaxLength(BookNConditoinMaxLenght)]
        public string Condition { get; set; }


        [Required]
        [MaxLength(DescriptionMaxLenght)]
        public string Description { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
