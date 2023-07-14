using OrdersService.Models;

namespace OrdersService.Controllers
{
    public interface IEntityController<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> Get(int from, int offset);

        Task<TEntity> Create(TEntity order);
    }
}
