using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Customers")]
        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int TotalAmount { get; set; }
    }
}
