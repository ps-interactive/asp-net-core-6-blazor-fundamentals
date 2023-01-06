using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop.Shared
{
    public class Pie
    {
        public int PieId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string ShortDescription { get; set; } = string.Empty;
        public string? LongDescription { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
    }
}
