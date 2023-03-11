using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly ApplicationDbContext _db;
        public MovieRepository(ApplicationDbContext db) : base (db) 
        {
            _db = db;
        }
    }
}
