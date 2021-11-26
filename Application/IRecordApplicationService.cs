using System;
using System.Collections.Generic;

namespace Application
{
    public interface IRecordApplicationService
    {
        List<Domain.MusicalGenre> FilterGenre(Filter filter);
    }
}
