using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplatesExample
{
    public static class DropDownListService
    {
        public static IEnumerable<SelectListItem> CategoryList(object id)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            CategoryService categoryService = new CategoryService();
            foreach (var item in categoryService.GetAll())
            {
                var selected = false;
                int selectValue = 0;
                if (id != null && int.TryParse(id.ToString(), out selectValue))
                {
                    selected = item.Id == selectValue;
                }
                items.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString(), Selected = selected });
            }
            return items;
        }
    }
}