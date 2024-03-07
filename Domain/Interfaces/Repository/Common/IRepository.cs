namespace IA.Interfaces.Repository.Common
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> All();
        void Delete(TEntity entity);
        TEntity Get(int id);
        void Update(TEntity entity);
    }
}