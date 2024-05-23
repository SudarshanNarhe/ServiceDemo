using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServiceDemo.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
