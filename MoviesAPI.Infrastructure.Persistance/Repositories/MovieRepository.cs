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

        public List<Actor> GetActorsByMovie(int IdMovie)
        {
            //SqlConnection conn = (SqlConnection)_db.Database.GetDbConnection();
            //SqlCommand cmd = conn.CreateCommand();
            //conn.Open();
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.CommandText = "ActorsByMovie";
            //cmd.Parameters.("@Movie", System.Data.SqlDbType.Int).Value = IdMovie;
            //cmd.ExecuteReader();
            //conn.Close();
        }
    }
}
