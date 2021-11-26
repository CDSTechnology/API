using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class RecordApplicationService : IRecordApplicationService
    {
        public List<MusicalGenre> FilterGenre(Filter filter)
        {
            //TODO - use object filter to find records inside the listMusicalGenre

            var listMusicalGenre = new List<MusicalGenre>();
            MusicalGenre musicalGenre = new MusicalGenre();

            musicalGenre.MusicalGenreId = 1;
            musicalGenre.Description = "Hip Hop";
            musicalGenre.Performers = new List<Performer> { 
                new Performer 
                    { 
                        PerformerId = 1,
                        FirstName = "first name 1",
                        MiddleName = "middle name 1",
                        LastName = "Surname 1",
                        YearsOld = 35,
                        Email = "hiphop@hiphop.com",
                        Curiosities = new List<Curiosity>()
                                {new Curiosity 
                                    { CuriosityId = 1, FavorityMovie="Predator", YearRelease=1987 },
                                {new Curiosity 
                                    { CuriosityId = 2, FavorityMovie = "Predator 2", YearRelease = 1990 } },
                                {new Curiosity 
                                    { CuriosityId = 3, FavorityMovie = "Alien vs. Predator", YearRelease = 2004 } },
                                {new Curiosity 
                                    { CuriosityId = 4, FavorityMovie = "Alien vs. Predator 2", YearRelease = 2007} },
                                {new Curiosity 
                                    { CuriosityId = 5, FavorityMovie = "Predators", YearRelease = 2010} },
                                {new Curiosity 
                                    { CuriosityId = 6, FavorityMovie = "The Ultimate Predator", YearRelease = 2018 } }
                            }
                    },
                new Performer { PerformerId = 2, FirstName = "first name 2", MiddleName = "middle name 2", LastName = "last name 2", YearsOld = 40, Email = "second@hiphop.com" },
                new Performer { PerformerId = 3, FirstName = "first name 3", MiddleName = "middle name 3", LastName = "last name 3", YearsOld = 45, Email = "third@hiphop.com" }
                };
            listMusicalGenre.Add(musicalGenre);

            musicalGenre = new MusicalGenre();

            musicalGenre.MusicalGenreId = 2;
            musicalGenre.Description = "Rock in Roll";

            musicalGenre.Performers = new List<Performer> { 
                new Performer 
                { 
                    PerformerId = 4, 
                    FirstName = "first name 2", 
                    MiddleName = "middle name 2", 
                    LastName = "last name 2", 
                    YearsOld = 35, 
                    Email = "rockinroll@rockinroll.com",
                    Curiosities = new List<Curiosity>()
                    {
                        new Curiosity
                        {
                            CuriosityId = 7, FavorityMovie="Movie 1", YearRelease=2021
                        },

                        new Curiosity
                        { 
                            CuriosityId = 8, FavorityMovie="Movie 2", YearRelease=2021
                        },

                        new Curiosity
                        { 
                            CuriosityId = 9, FavorityMovie="Movie 3", YearRelease=2021
                        },

                        new Curiosity
                        {
                            CuriosityId = 10, FavorityMovie="Movie 4", YearRelease=2021
                        },

                        new Curiosity
                        {
                            CuriosityId = 11, FavorityMovie="Movie 5", YearRelease=2021
                        }
                    }
                },
                                                            
                new Performer { PerformerId = 5, FirstName = "first name 5", MiddleName = "middle name 5", LastName = "last name 5", YearsOld = 40, Email = "rock2@rockinroll.com" },
                                                            
                new Performer { PerformerId = 6, FirstName = "first name 6 ", MiddleName = "middle name 6", LastName = "last name6", YearsOld = 45, Email = "rock6@hiphop.com" }
                };
            listMusicalGenre.Add(musicalGenre);

            musicalGenre = new MusicalGenre();

            musicalGenre.MusicalGenreId = 3;
            musicalGenre.Description = "Pop";

            musicalGenre.Performers = new List<Performer> { new Performer { PerformerId = 7, FirstName = "first name 7 for repository", MiddleName = "middle name 7 for repository", LastName = "last name 7 for repository", YearsOld = 35, Email = "firstmidllelast7@hiphop.com" },
                                                            new Performer { PerformerId = 8, FirstName = "first name 8 for repository", MiddleName = "middle name 8 for repository", LastName = "last name 8 for repository", YearsOld = 40, Email = "firstmidllelast8@hiphop.com" },
                                                            new Performer { PerformerId = 9, FirstName = "first name 9 for repository", MiddleName = "middle name 9 for repository", LastName = "last name 9 for repository", YearsOld = 45, Email = "firstmidllelast9@hiphop.com" }
                                                          };
            listMusicalGenre.Add(musicalGenre);

            return listMusicalGenre;
        }
    }
}
