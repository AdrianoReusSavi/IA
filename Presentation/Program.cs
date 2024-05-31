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

// Chamando configure da autenticação com JWT
// JwtConfiguration.Configure(builder);

// Chamando configure da injeção de dependência
DependencyInjectionConfiguration.Configure(builder);

// Configurando o CORS
CorsConfiguration.Configure(builder);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Confirmando que usará o CORS
CorsConfiguration.UseCors(app);

app.Run();

public partial class Program { }
