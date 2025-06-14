using EntityLayer.Concrete;

namespace PresentationLayer.Models
{
    public class ProductWithCategoryViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
