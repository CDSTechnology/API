using System.Collections.Generic;

namespace Domain
{
    public class MusicalGenre
    {
        public int MusicalGenreId { get; set; }
        public string Description { get; set; }
        public IList<Performer> Performers { get; set; }
    }
}
