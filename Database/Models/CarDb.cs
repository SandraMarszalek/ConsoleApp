using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class CarDb
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
    }
}