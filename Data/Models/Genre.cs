namespace BookMarket.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Genre
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(GenreMaxLenght)]
        public string Name { get; set; }

        public IEnumerable<Book> Books = new List<Book>();
    }
}
