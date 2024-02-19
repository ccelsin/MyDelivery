namespace MyDelivery.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Order Order { get; set; }
        public string? Status { get; set; }
    }
}
