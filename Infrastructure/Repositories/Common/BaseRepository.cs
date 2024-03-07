using IA.Data.Contexts;
using IA.Interfaces.Repository.Common;

namespace IA.Repositories.Common
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            using (var context = new Context())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<TEntity> All()
        {
            using (var context = new Context())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new Context())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity Get(int id)
        {
            using (var context = new Context())
            {
                return context.Set<TEntity>().FirstOrDefault();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new Context())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}