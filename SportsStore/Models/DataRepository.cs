using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models {
    public class DataRepository : IRepository {
        public DataContext Context { get; set; }
        public DataRepository(DataContext ctx) =>Context = ctx;
        public IEnumerable<Product> Products => Context.Products;
        public void AddProduct(Product product) {
            this.Context.Products.Add(product);
            this.Context.SaveChanges();
        }

        public Product GetProduct(long key) => Context.Products.Find(key);
        
        public void UpdateProduct(Product product)
        {
            Context.Products.Update(product);
            Context.SaveChanges();
        }
    }
}