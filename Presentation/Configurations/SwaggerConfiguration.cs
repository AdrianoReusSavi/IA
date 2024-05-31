using Microsoft.OpenApi.Models;

namespace IA.Configuration
{
    public class SwaggerConfiguration
    {
        public static void Configure(WebApplicationBuilder builder)
        {

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API IA",
                    Description = "Projeto de Inteligência Artifical SATC",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Email = "adrianorsavi@gmail.com",
                        Name = "Adriano Reus Savi",
                    }

                });
            });
        }
    }
}