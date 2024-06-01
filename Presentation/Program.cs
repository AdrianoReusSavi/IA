using IA;
using IA.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(r => r.LowercaseUrls = true);

// Adicionando o provedor de logger customizado
builder.Logging.ClearProviders();  // Opcional: Remove outros provedores de log
builder.Logging.AddProvider(new CustomLoggerProvider());

// Chamando configure da Swagger
SwaggerConfiguration.Configure(builder);

// Chamando configure da autentica��o com JWT
// JwtConfiguration.Configure(builder);

// Chamando configure da inje��o de depend�ncia
DependencyInjectionConfiguration.Configure(builder);

// Configurando o CORS
CorsConfiguration.Configure(builder);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Confirmando que usar� o CORS
CorsConfiguration.UseCors(app);

app.Run();

public partial class Program { }
