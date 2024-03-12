using System.ComponentModel.DataAnnotations.Schema;

namespace MyDelivery.Models
{
    public class Delivery
    {
       
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public string? Status { get; set; }
    }
}
