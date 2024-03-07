namespace IA.Interfaces.Service.Common
{
    public interface IService<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> All();
        void Delete(TEntity entity);
        TEntity Get(int id);
        void Update(TEntity entity);
    }
}