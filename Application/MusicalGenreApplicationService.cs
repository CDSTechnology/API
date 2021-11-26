using System.Collections.Generic;

using Domain;
using Infra.Data;

namespace Application
{    
    public class MusicalGenreApplicationService : IMusicalGenreApplicationService
    {
        private readonly IMusicalGenreRepository _musicalGenreRepository;
        public MusicalGenreApplicationService(IMusicalGenreRepository musicalGenreRepository)
        {
            _musicalGenreRepository = musicalGenreRepository;
        }
        public List<MusicalGenre> FilterGenre(FilterApplication filterApplication)
        {
            //like automapper

            FilterDomain filterDomain = new FilterDomain()
            {
                Genre = filterApplication.DescriptionGenre,
                Movie = filterApplication.FavoriteMovie,
                Name = filterApplication.FirstName,
                Year = filterApplication.YearRelease
            };

            var listMusicalGenre = _musicalGenreRepository.FilterGenre(filterDomain);            

            return listMusicalGenre;
        }
    }
}
