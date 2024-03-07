using IA.Interfaces.Repository;
using IA.Interfaces.Service;
using IA.Repositories;
using IA.Services;

namespace IA.Configuration
{
    public class DependencyInjectionConfiguration
    {
        public static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IProdutoService, ProdutoService>();
            builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
        }
    }
}