using System;
namespace MeatStore.Data.Models
{
    public class ShoppingCarItem
    {
        public int ShoppingCarItemId { get; set; }
        public Meat Meat { get; set; }
        public int Amount { get; set; }
        public string ShoppingCarId { get; set; }
    }
}
