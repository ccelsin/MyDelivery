using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDelivery.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        [Column("Status")]
        public string? Status { get; set; }
       [Required] [ForeignKey("Customer")]
        public int CustumerId {  get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
    }
}
