using lab1_webapi_event.Entity;

namespace lab1_webapi_event.Store
{
    public class MockDataStore
    {
        public static List<Product> _products =  
        [
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Description = "Description 1",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Product
            {
                Id = 2,
                Name = "Product 2",
                Description = "Description 2",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Product
            {
                Id = 3,
                Name = "Product 3",
                Description = "Description 3",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
         ];


         public async Task AddProduct(Product product){
            _products.Add(product);
            await Task.CompletedTask;
         }  

         public async Task<List<Product>> GetProducts(){
            return await Task.FromResult(_products);
         }


    }
}