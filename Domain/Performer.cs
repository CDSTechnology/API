using System.Collections.Generic;

namespace Domain
{
    public class Performer
    {                
        public int PerformerId { get; set; }        
        public string FirstName { get; set; }        
        public string MiddleName { get; set; }        
        public string LastName { get; set; }        
        public int YearsOld { get; set; }        
        public string Email { get; set; }
        public IList<Curiosity> Curiosities { get; set; }
    }
}
