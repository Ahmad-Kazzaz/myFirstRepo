using ECommerceApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Dtos
{
    public class DiscountDto
    {
        public int Discount_ID { get; set; }

        [Required(ErrorMessage = "رمز الخصم مطلوب.")]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required(ErrorMessage = "نوع الخصم مطلوب.")]
        public DiscountType DiscountType { get; set; }

        [Required(ErrorMessage = "قيمة الخصم مطلوبة.")]
        public decimal DiscountValue { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public bool IsActive { get; set; }
        public int? UsedCount { get; set; }
        public int? MaxUses { get; set; }
    }
}
