



using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects.DataClasses;
using System.Web.Mvc;

namespace TemplatesExample
{
[MetadataType(typeof(CategoryMetadata))]
	public partial class Category
	{
		internal sealed class CategoryMetadata
		{
			
			[DisplayName("Id")]
			[Required(ErrorMessage="Id 為必填")]
    		public Int32 Id { get; set; }

			[DisplayName("名稱")]
			[Required(ErrorMessage="名稱 為必填")]
			[StringLength(50)]
    		public String Name { get; set; }

			[DisplayName("開啟")]
			[Required(ErrorMessage="開啟 為必填")]
    		public Boolean Enabled { get; set; }

			[DisplayName("建立時間")]
			[Required(ErrorMessage="Create Time 為必填")]
			[DataType(DataType.DateTime)]
    		public DateTime CreateTime { get; set; }

			[DisplayName("修改時間")]
			[DataType(DataType.DateTime)]
    		public DateTime EditTime { get; set; }

    		public EntityCollection<Product> Product { get; set; }

		}
	}
}
