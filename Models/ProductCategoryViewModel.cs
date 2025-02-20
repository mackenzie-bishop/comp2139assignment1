namespace SmartInventory.Models
{
    public class ProductCategoryViewModel
    {
        // Initialize the properties to empty lists
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
