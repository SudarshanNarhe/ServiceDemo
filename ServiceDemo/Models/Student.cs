using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServiceDemo.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Java { get; set; }

        [Required]
        public int DotNet { get; set; }

        [Required]
        public int SQL { get; set; }

        [Required]
        public int Angular { get; set; }

        public decimal Percentage { get; set; }

    }
}
