using global::System.ComponentModel.DataAnnotations;

namespace global::CAFallAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [global::System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }

        [global::System.ComponentModel.DataAnnotations.Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public int Stock { get; set; }
    }
}