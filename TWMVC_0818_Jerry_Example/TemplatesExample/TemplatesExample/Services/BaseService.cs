using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatesExample
{
    public class BaseService
    {
        public BaseService()
        {
            _dataContext = new ExampleDBEntities();
        }
        private ExampleDBEntities _dataContext;
        protected ExampleDBEntities DataContext { get { return _dataContext; } }
    }
}

