using System.ComponentModel.DataAnnotations;

namespace Inventory.API.DTOs
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        [Range(0.01, 1000000, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Price { get; set; }

        [Range(0, 9999)]
        public int Stock { get; set; }
    }
}