namespace SmartInventory.Models
{
    public class Product
    {
        public int Id { get; set; } 

        public string? Name { get; set; }  
        
        public int CategoryId { get; set; }  
        
      
        public Category Category { get; set; } = null!;  
        
        public decimal Price { get; set; }  
        
        public int QuantityInStock { get; set; }  
        
        public int LowStockThreshold { get; set; }  
    }
}
