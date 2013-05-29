using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects.DataClasses;
using System.Web.Mvc;

namespace TemplatesExample
{
[MetadataType(typeof(NewsMetadata))]
	public partial class News
	{
		internal sealed class NewsMetadata
		{
			
			[DisplayName("Id")]
			[Required(ErrorMessage="Id 為必填")]
    		public Int32 Id { get; set; }

			[DisplayName("標題")]
			[Required(ErrorMessage="標題 為必填")]
			[StringLength(100)]
    		public String Title { get; set; }

			[DisplayName("內容")]
			[UIHint("CLEditor")]	
			[AllowHtml]
    		public String Content { get; set; }

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

		}
	}
}
