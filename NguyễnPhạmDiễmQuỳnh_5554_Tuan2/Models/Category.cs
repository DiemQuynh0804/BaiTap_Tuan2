using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NguyễnPhạmDiễmQuỳnh_5554_Tuan2.Models
{
    public class Category
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }

        [DisplayName("Tên sản phẩm")]
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
