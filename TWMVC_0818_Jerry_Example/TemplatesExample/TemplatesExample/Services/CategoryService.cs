using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatesExample
{
    public class CategoryService : BaseService
    {
        public IEnumerable<Category> GetAll()
        {
            return this.DataContext.Category;
        }

        public Category Get(int id)
        {
            return this.DataContext.Category.FirstOrDefault(p => p.Id == id);
        }

        public void Create(Category category)
        {
            category.CreateTime = DateTime.Now;
            this.DataContext.Category.AddObject(category);
            this.DataContext.SaveChanges();
        }

        public void Update(Category category)
        {
            category.EditTime = DateTime.Now;
            this.DataContext.SaveChanges();
        }

        public void Delete(Category category)
        {
            this.DataContext.Category.DeleteObject(category);
            this.DataContext.SaveChanges();
        }
    }
}
