using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Extension.Mvc
{
    public static class HtmlHelperExtension
    {
        /// <summary>
        /// 擴充HtmlHelper
        /// 如果ModelMetadata.AdditionalValues中有UIHintTemplateControlParameters這個Key，就回傳Dictionary
        /// </summary>
        public static Dictionary<string, object> GetUIHintParametersDictionary(this HtmlHelper helper)
        {
            var additionalValues = helper.ViewContext.ViewData.ModelMetadata.AdditionalValues;

            if (additionalValues.ContainsKey("UIHintTemplateControlParameters"))
            {
                Dictionary<string, object> dic = (Dictionary<string, object>)additionalValues["UIHintTemplateControlParameters"];
                return dic;
            }
            return null;
        }

        /// <summary>
        /// 擴充HtmlHelper
        /// 用指定的key去抓設定在UIHintTemplateControlParameters Dictionary中的Value
        /// </summary>
        public static T GetUIHintParametersValue<T>(this HtmlHelper helper, string key)
        {
            return GetUIHintParametersValue<T>(helper, key, default(T));
        }

        /// <summary>
        /// 擴充HtmlHelper
        /// 用指定的key去抓設定在UIHintTemplateControlParameters Dictionary中的Value
        /// 並在沒有設定時傳回預設值
        /// </summary>
        public static T GetUIHintParametersValue<T>(this HtmlHelper helper, string key, T defaultValue)
        {
            var dic = GetUIHintParametersDictionary(helper);
            if (dic != null && dic.ContainsKey(key))
            {
                var value = dic[key].ToConvertOrDefault<T>(defaultValue);
                return value;
            }
            return defaultValue;
        }
    }
}