using System;
using System.Collections.Generic;

namespace Application
{
    public interface IMusicalGenreApplicationService
    {
        List<Domain.MusicalGenre> FilterGenre(FilterApplication filter);
    }
}
