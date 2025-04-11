using System.ComponentModel.DataAnnotations;

namespace ProductListApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        
        [StringLength(200)]
        public string? ImageUrl { get; set; }
        
        [StringLength(500)]
        public string? Description { get; set; }
        
        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        
        // Thêm trường cho đánh giá và giá gốc
        [Range(0, 5)]
        public double Rating { get; set; }
        
        public int RatingCount { get; set; }
        
        public decimal? OriginalPrice { get; set; }
        
        // Tính toán phần trăm giảm giá nếu có
        public int? DiscountPercent 
        {
            get 
            {
                if (OriginalPrice.HasValue && OriginalPrice > Price)
                {
                    return (int)Math.Round((1 - Price / OriginalPrice.Value) * 100);
                }
                return null;
            }
        }
    }
}