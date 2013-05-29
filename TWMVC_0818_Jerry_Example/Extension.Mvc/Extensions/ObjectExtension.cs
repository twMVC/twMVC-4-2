using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension.Mvc
{
    public static class ObjectExtension
    {
        public static T ToConvertOrDefault<T>(this object obj, T defaultValue)
        {
            try
            {
                return (T)Convert.ChangeType(obj, typeof(T));
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
