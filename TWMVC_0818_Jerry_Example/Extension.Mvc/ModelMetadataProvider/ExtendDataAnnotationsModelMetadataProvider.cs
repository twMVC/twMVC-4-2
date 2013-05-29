using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Extension.Mvc
{
    public class ExtendDataAnnotationsModelMetadataProvider : DataAnnotationsModelMetadataProvider
    {
        protected override ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
        {
            //不希望覆寫太多東西，所以大部分還是用base的CreateMetadata方法
            ModelMetadata metadata = base.CreateMetadata(attributes,
                                                          containerType,
                                                          modelAccessor,
                                                          modelType,
                                                          propertyName);

            List<Attribute> attributeList = new List<Attribute>(attributes);

            IEnumerable<UIHintAttribute> uiHintAttributes = attributeList.OfType<UIHintAttribute>();
            UIHintAttribute uiHintAttribute = uiHintAttributes.FirstOrDefault(a => String.Equals(a.PresentationLayer, "MVC", StringComparison.OrdinalIgnoreCase))
                                            ?? uiHintAttributes.FirstOrDefault(a => String.IsNullOrEmpty(a.PresentationLayer));

            //如果有UIHint屬性，就將他的參數塞到ModelMetadata.AdditionalValues裡面
            //Key是UIHintTemplateControlParameters
            if (uiHintAttribute != null)
            {
                if (metadata.AdditionalValues.ContainsKey("UIHintTemplateControlParameters"))
                    throw new ArgumentException("Metadate.AdditionalValues已存在 \"UIHintTemplateControlParameters\"這個Key，請更換擴充UIHintAttribute的Key值。");

                metadata.AdditionalValues.Add("UIHintTemplateControlParameters", uiHintAttribute.ControlParameters);
            }
            return metadata;
        }
    }
}