using System;
using MeatStore.Data.Models;

namespace MeatStore.Data.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
