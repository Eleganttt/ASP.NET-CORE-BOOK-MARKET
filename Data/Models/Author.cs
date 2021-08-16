namespace BookMarket.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Author
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(AuthorFirstNameMaxLenght)]
        public string FirstName { get; init; }

        [Required]
        [MaxLength(AuthorLastNameMaxLenght)]
        public string LastName { get; init; }

        public IEnumerable<Book> Books = new List<Book>();
    }
}
