using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public interface IMusicalGenreRepository
    {
        List<Domain.MusicalGenre> FilterGenre(Domain.FilterDomain filterDomain);
    }
}
