using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects.DataClasses;
using System.Web.Mvc;

namespace TemplatesExample
{
[MetadataType(typeof(ProductMetadata))]
	public partial class Product
	{
		internal sealed class ProductMetadata
		{
			
			[DisplayName("Id")]
			[Required(ErrorMessage="Id 為必填")]
    		public Int32 Id { get; set; }

			[DisplayName("名稱")]
			[Required(ErrorMessage="名稱 為必填")]
			[StringLength(50)]
    		public String Name { get; set; }

			[DisplayName("價格")]
			[Required(ErrorMessage="價格 為必填")]
    		public Int32 Price { get; set; }

			[DisplayName("描述")]
			[UIHint("CLEditor")]	
			[AllowHtml]
			[Required(ErrorMessage="描述 為必填")]
			[StringLength(200)]
    		public String Description { get; set; }

			[DisplayName("開啟")]
			[Required(ErrorMessage="開啟 為必填")]
    		public Boolean Enabled { get; set; }

			[DisplayName("圖片")]
			[UIHint("Uploadify")]	
			[StringLength(100)]
    		public String Image { get; set; }

			[DisplayName("CategoryId")]
			[Required(ErrorMessage="Category 為必填")]
            [UIHint("DropDownListTemplate", "MVC", "OptionLabel", "- 請選擇 -", "DropDownListMethodName", "CategoryList")]
    		public Int32 CategoryId { get; set; }

			[DisplayName("建立時間")]
			[Required(ErrorMessage="Create Time 為必填")]
			[DataType(DataType.DateTime)]
    		public DateTime CreateTime { get; set; }

			[DisplayName("修改時間")]
			[DataType(DataType.DateTime)]
    		public DateTime EditTime { get; set; }

    		public EntityCollection<Category> Category { get; set; }

		}
	}
}
