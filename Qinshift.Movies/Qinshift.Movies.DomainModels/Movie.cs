using Qinshift.Movies.DomainModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace Qinshift.Movies.DomainModels
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public GenreEnum Genre { get; set; }
    }
}
