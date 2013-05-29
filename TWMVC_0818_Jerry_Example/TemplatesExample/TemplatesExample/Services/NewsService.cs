using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatesExample
{
    public class NewsService : BaseService
    {
        public IEnumerable<News> GetAll()
        {
            return this.DataContext.News;
        }

        public News Get(int id)
        {
            return this.DataContext.News.FirstOrDefault(p => p.Id == id);
        }

        public void Create(News news)
        {
            news.CreateTime = DateTime.Now;
            this.DataContext.News.AddObject(news);
            this.DataContext.SaveChanges();
        }

        public void Update(News news)
        {
            news.EditTime = DateTime.Now;
            this.DataContext.SaveChanges();
        }

        public void Delete(News news)
        {
            this.DataContext.News.DeleteObject(news);
            this.DataContext.SaveChanges();
        }
    }
}
