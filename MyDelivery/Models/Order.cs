using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDelivery.Models
{
    
    public class Order
    {
        public int Id { get; set; }
        [Column("Status")]
        public string? Status { get; set; }
       [Required] [ForeignKey("Customer")]
        public int CustumerId {  get;  }
        [Required]
        public DateTime OrderDate { get; set; }
    }
}
