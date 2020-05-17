using System;
namespace MeatStore.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Meat Meat { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
