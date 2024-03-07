using IA;
using IA.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddRouting(r => r.LowercaseUrls = true);

//chamando configure da swagger
SwaggerConfiguration.Configure(builder);
//chamando configure da autenticação com JWT
JwtConfiguration.Configure(builder);
//chamando configure da injeção de dependencia
DependencyInjectionConfiguration.Configure(builder);

CorsConfiguration.Configure(builder);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//Confirmando que usará o CORS
CorsConfiguration.UseCors(app);

app.Run();

public partial class Program { }