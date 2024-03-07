using IA.Entities;
using Microsoft.EntityFrameworkCore;

namespace IA.Data.Contexts
{
    public class Context : DbContext
    {

        #region DbSets
        public DbSet<Produto> Produtos { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ContextConfiguration.Configure(builder);
        }
    }
}