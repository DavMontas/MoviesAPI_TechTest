using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoviesAPI.Core.Application.Interfaces.Repositories;
using MoviesAPI.Infrastructure.Persistance.Context;
using MoviesAPI.Infrastructure.Persistance.Repositories;


namespace MoviesAPI.Infrastructure.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceInfrastructure(this IServiceCollection svc, IConfiguration config)
        {
            svc.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            #region 'repos'

            svc.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            svc.AddTransient<IActorRepository, ActorRepository>();
            svc.AddTransient<IMovieRepository, MovieRepository>();


            #endregion
        }
    }
}
