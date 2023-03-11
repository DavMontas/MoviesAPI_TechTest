using Swashbuckle.AspNetCore.SwaggerUI;

namespace MoviesAPI.Extensions
{
    public static class AppExtensions
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "RealEstateAPI");
                opt.DefaultModelRendering(ModelRendering.Model);
            });
        }
    }
}
