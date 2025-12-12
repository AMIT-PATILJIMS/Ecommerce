using System.ComponentModel.DataAnnotations;

namespace Ecommerce
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public int BasePrice { get; set; }

        public int Quantity { get; set; }
    }
}
