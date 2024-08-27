using Microsoft.EntityFrameworkCore;
using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DomainModels.Enums;

namespace Qinshft.Movies.DataAccess.DataSource
{
    public static class InitialDb
    {
        public static void InitDb(ModelBuilder builder)
        {
            builder.Entity<Movie>()
                .HasData(new List<Movie>
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
                    new Movie {
                        Id = 6,
                        Title = "Interstellar",
                        Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                        Year = 2014,
                        Genre = GenreEnum.SciFi
                    },
                    new Movie {
                        Id = 7,
                        Title = "Gladiator",
                        Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                        Year = 2000,
                        Genre = GenreEnum.Action
                    },
                    new Movie {
                        Id = 8,
                        Title = "The Shawshank Redemption",
                        Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                        Year = 1994,
                        Genre = GenreEnum.Drama
                    },
                    new Movie {
                        Id = 9,
                        Title = "Pulp Fiction",
                        Description = "The lives of two mob hitmen, a boxer, a gangster, and his wife intertwine in four tales of violence and redemption.",
                        Year = 1994,
                        Genre = GenreEnum.Action
                    },
                    new Movie {
                        Id = 10,
                        Title = "Fight Club",
                        Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                        Year = 1999,
                        Genre = GenreEnum.Drama
                    },
                    new Movie {
                        Id = 11,
                        Title = "Forrest Gump",
                        Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal, and other historical events unfold from the perspective of an Alabama man with an IQ of 75.",
                        Year = 1994,
                        Genre = GenreEnum.Drama
                    },
                    new Movie {
                        Id = 12,
                        Title = "The Matrix",
                        Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                        Year = 1999,
                        Genre = GenreEnum.SciFi
                    },
                    new Movie {
                        Id = 13,
                        Title = "The Lord of the Rings: The Return of the King",
                        Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                        Year = 2003,
                        Genre = GenreEnum.SciFi
                    },
                    new Movie {
                        Id = 14,
                        Title = "The Godfather",
                        Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                        Year = 1972,
                        Genre = GenreEnum.Thriller
                    },
                    new Movie {
                        Id = 15,
                        Title = "Schindler's List",
                        Description = "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                        Year = 1993,
                        Genre = GenreEnum.Drama
                    },
                    new Movie {
                        Id = 16,
                        Title = "Inglourious Basterds",
                        Description = "In Nazi-occupied France during World War II, a plan to assassinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same.",
                        Year = 2009,
                        Genre = GenreEnum.Action
                    },
                    new Movie {
                        Id = 17,
                        Title = "The Silence of the Lambs",
                        Description = "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
                        Year = 1991,
                        Genre = GenreEnum.Thriller
                    },
                    new Movie {
                        Id = 18,
                        Title = "Saving Private Ryan",
                        Description = "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.",
                        Year = 1998,
                        Genre = GenreEnum.Drama
                    },
                    new Movie {
                        Id = 19,
                        Title = "Braveheart",
                        Description = "Scottish warrior William Wallace leads his countrymen in a rebellion to free his homeland from the tyranny of King Edward I of England.",
                        Year = 1995,
                        Genre = GenreEnum.Action
                    },
                    new Movie {
                        Id = 20,
                        Title = "The Wolf of Wall Street",
                        Description = "Based on the true story of Jordan Belfort, from his rise to a wealthy stock-broker living the high life to his fall involving crime, corruption, and the federal government.",
                        Year = 2013,
                        Genre = GenreEnum.Drama
                    }
                });
        }
    }
}
