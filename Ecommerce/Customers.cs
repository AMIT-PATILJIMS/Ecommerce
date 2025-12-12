using System.ComponentModel.DataAnnotations;

namespace Ecommerce
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public CustomerEnum CustomerType{get;set;}
    }

    public enum CustomerEnum
    {
            Regular = 0,
            Premium = 1,
            Gold = 2
    }
}
