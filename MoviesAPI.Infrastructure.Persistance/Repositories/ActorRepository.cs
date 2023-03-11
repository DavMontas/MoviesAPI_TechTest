using MoviesAPI.Core.Application.Interfaces.Repositories;
using MoviesAPI.Core.Domain.Entities;
using MoviesAPI.Infrastructure.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Infrastructure.Persistance.Repositories
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        private readonly ApplicationDbContext _db;
        public ActorRepository(ApplicationDbContext db) : base (db) 
        {
            _db = db;
        }
    }
}
