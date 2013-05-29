using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatesExample
{
    public class ProductService : BaseService
    {
        public IEnumerable<Product> GetAll()
        {
            return this.DataContext.Product;
        }

        public Product Get(int id)
        {
            return this.DataContext.Product.FirstOrDefault(p => p.Id == id);
        }

        public void Create(Product product)
        {
            product.CreateTime = DateTime.Now;
            this.DataContext.Product.AddObject(product);
            this.DataContext.SaveChanges();
        }

        public void Update(Product product)
        {
            product.EditTime = DateTime.Now;
            this.DataContext.SaveChanges();
        }

        public void Delete(Product product)
        {
            this.DataContext.Product.DeleteObject(product);
            this.DataContext.SaveChanges();
        }
    }
}
