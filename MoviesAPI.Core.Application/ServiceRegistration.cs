using Microsoft.Extensions.DependencyInjection;
using MoviesAPI.Core.Application.Interfaces.Services;
using MoviesAPI.Core.Application.Services;
using System.Reflection;

namespace MoviesAPI.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection service)
        {
            service.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region services
            service.AddTransient<IActorService, ActorService>();
            service.AddTransient<IMovieService, MovieService>();
            #endregion
        }
    }
}
