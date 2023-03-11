using MoviesAPI.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Core.Domain.Entities
{
    public class Movie : AuditableBaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Actor> Actors { get; set; }

    }
}
