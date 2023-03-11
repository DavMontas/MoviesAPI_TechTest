using MoviesAPI.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Core.Domain.Entities
{
    public class Actor : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Info { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
