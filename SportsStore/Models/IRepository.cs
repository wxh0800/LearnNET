using System.Collections.Generic;

namespace SportsStore.Models {
    public interface IRepository {
        
        IEnumerable<Product> Products { get; }
        DataContext Context { get; set; }

        void AddProduct(Product product);
        Product GetProduct(long key);
        void UpdateProduct(Product product);
    }
}