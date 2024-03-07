using IA;
using IA.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddRouting(r => r.LowercaseUrls = true);

//chamando configure da swagger
SwaggerConfiguration.Configure(builder);
//chamando configure da autentica��o com JWT
JwtConfiguration.Configure(builder);
//chamando configure da inje��o de dependencia
DependencyInjectionConfiguration.Configure(builder);

CorsConfiguration.Configure(builder);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//Confirmando que usar� o CORS
CorsConfiguration.UseCors(app);

app.Run();

public partial class Program { }