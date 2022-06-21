#pragma warning disable CS8618

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Category : BaseEntity
    {
        public ICollection<Product> Products { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } 
        
        [Required]
        [MaxLength(300)]
        public string ImageUrl { get; set; }

        public Category(ICollection<Product> products)
        {
            Products = new Collection<Product>();
        }
    }
}
