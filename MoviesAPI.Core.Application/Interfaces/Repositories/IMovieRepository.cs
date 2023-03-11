using MoviesAPI.Core.Domain.Entities;

namespace MoviesAPI.Core.Application.Interfaces.Repositories
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        List<Actor> GetActorsByMovie(int IdMovie);
    }
}
