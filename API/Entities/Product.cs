#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(300)]
        public string ImageUrl { get; set; }

        public float Stock { get; set; }

        public DateTime CreatedAt { get; set; }

        public Category Category { get; set; }

        public Guid CategoryId { get; set; }
    }
}
