using PIMVIII.NovasComprasDomain.Domain;

namespace PIMVIII.NovasComprasDomain.Interfaces
{
    public interface IRepository<T>
    {
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);
        T ObterPorId(Base id);
        List<T> ObterTodos();
    }
}
