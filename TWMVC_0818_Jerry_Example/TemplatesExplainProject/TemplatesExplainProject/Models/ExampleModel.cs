using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TemplatesExplainProject
{
    public class ExampleModel
    {
        public bool Enabled { get; set; }

        [DataType(DataType.Currency)]
        public Decimal Currency { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }

        [AllowHtml]
        [DataType(DataType.Html)]
        public string Html { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [UIHint("Uploadify")]
        public string ImageUrl { get; set; }

        [UIHint("Uploadify")]
        public string ImageUrl2 { get; set; }

        [UIHint("Uploadify")]
        public string ImageUrl3 { get; set; }
    }
}