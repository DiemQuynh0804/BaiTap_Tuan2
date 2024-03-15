using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NguyễnPhạmDiễmQuỳnh_5554_Tuan2.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }

        [DisplayName("Tên sản phẩm")]
        [Required, StringLength(100)] 
        public string Name { get; set; }

        [DisplayName("Giá bán")]
        [Range(0.01,10000.00)]
        public decimal Price { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [DisplayName("Mã loại")]
        public int CategoryId { get; set; }

        public String? ImageUrl { get; set; }

        public List<string>? ImageUrls { get; set; }


    }
}
