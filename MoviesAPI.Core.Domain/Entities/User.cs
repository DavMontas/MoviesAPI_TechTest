using MoviesAPI.Core.Domain.Common;


namespace MoviesAPI.Core.Domain.Entities
{
    public class User : AuditableBaseEntity
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}
