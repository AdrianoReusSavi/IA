namespace IA.Configuration
{
    public class CorsConfiguration
    {
        public static string policyName = "DefaultPolicy";
        public static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddCors(
                config => config.AddPolicy(policyName, builder =>
                {
                    builder.AllowAnyOrigin() //qualquer dominio poderá acessar a API
                    .AllowAnyMethod() //Permitir POST, PUT, DELETE, GET
                    .AllowAnyHeader(); // aceitar parametros de cabeçalho de requisição
                })
                );
        }

        public static void UseCors(WebApplication app)
        {
            app.UseCors(policyName);
        }
    }
}