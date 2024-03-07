using IA.Entities;
using IA.Interfaces.Repository;
using IA.Interfaces.Service;

namespace IA.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Add(Produto entity)
        {
            _produtoRepository.Add(entity);
        }

        public IEnumerable<Produto> All()
        {
            return _produtoRepository.All();
        }

        public void Delete(Produto entity)
        {
            _produtoRepository.Delete(entity);
        }

        public Produto Get(int id)
        {
            return _produtoRepository.Get(id);
        }

        public void Update(Produto entity)
        {
            _produtoRepository.Update(entity);
        }
    }
}