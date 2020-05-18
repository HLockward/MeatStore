using System;
using MeatStore.Data.Interfaces;
using MeatStore.Data.Models;

namespace MeatStore.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        private readonly IMeatRepository _meatRepository;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart, IMeatRepository meatRepository)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
            _meatRepository = meatRepository;
        }


        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    MeatId = shoppingCartItem.Meat.MeatId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Meat.Price
                };

                _appDbContext.OrderDetails.Add(orderDetail);
                _meatRepository.RemoveMeatFromStock(shoppingCartItem.Meat.MeatId, shoppingCartItem.Amount);
            }

            _appDbContext.SaveChanges();
        }
    }
}
