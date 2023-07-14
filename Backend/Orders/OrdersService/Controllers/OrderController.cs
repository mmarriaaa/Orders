using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrdersService.Models;

namespace OrdersService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase, IEntityController<Order>
    {
        private const int MaxSelectedRecords = 1000;

        private readonly DbSet<Order> _ordersDbSet;

        private readonly DatabaseContext _databaseContext;

        public OrderController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _ordersDbSet = databaseContext.Orders;
        }

        [HttpGet("Get")]
        public async Task<IEnumerable<Order>> Get(int from, int offset)
        {
            Argument.NotLessThanZero(offset, nameof(offset));
            Argument.NotMoreThen(offset, nameof(offset), MaxSelectedRecords);
            Argument.NotLessThanZero(from, nameof(from));

            return await _ordersDbSet.Skip(from).Take(offset).ToListAsync();
        }

        [HttpPut("Create")]
        public async Task<Order> Create(Order order)
        {
            ValidateOrder(order);

            var entityEntry = await _ordersDbSet.AddAsync(order);
            await _databaseContext.SaveChangesAsync();

            return entityEntry.Entity;
        }

        private void ValidateOrder(Order order)
        {
            Argument.NotNullOrEmpty(order.SenderCity, nameof(order.SenderCity));
            Argument.NotNullOrEmpty(order.SenderAddress, nameof(order.SenderAddress));
            Argument.NotNullOrEmpty(order.RecipientCity, nameof(order.RecipientCity));
            Argument.NotNullOrEmpty(order.RecipientAddress, nameof(order.RecipientAddress));
            Argument.NotZeroOrLessThanZero(order.CargoWeight, nameof(order.CargoWeight));
        }
    }
}
