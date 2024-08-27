using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DomainModels.Enums;

namespace Qinshft.Movies.DataAccess.DataSource
{
    public static class StaticDb
    {
        public static List<Movie> Movies = new()
        {
            new Movie {
                Id = 1,
                Title = "Inception",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
                Year = 2010,
                Genre = GenreEnum.SciFi
            },
            new Movie {
                Id = 2,
                Title = "Shutter Island",
                Description = "Teddy Daniels and Chuck Aule, two US marshals, are sent to an asylum on a remote island in order to investigate the disappearance of a patient, where Teddy uncovers a shocking truth about the place.",
                Year = 2010,
                Genre = GenreEnum.Thriller
            },
            new Movie {
                Id = 3,
                Title = "The Departed",
                Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                Year = 2006,
                Genre = GenreEnum.Drama
            },
            new Movie {
                Id = 4,
                Title = "The Martian",
                Description = "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive and can survive until a potential rescue.",
                Year = 2015,
                Genre = GenreEnum.Adventure
            },
            new Movie {
                Id = 5,
                Title = "The Dark Knight",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.",
                Year = 2008,
                Genre = GenreEnum.Action
            },
        };
    }
}
