using MoviesAPI.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Core.Domain.Entities
{
    public class ActorMovie : AuditableBaseEntity
    {
        public int IdActor { get; set; }
        public int IdMovie { get; set; }
    }
}
