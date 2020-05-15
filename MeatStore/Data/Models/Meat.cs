using System;
namespace MeatStore.Data.Models
{
    public class Meat
    {
        public int MeatId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredMeat { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
