using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFTheCore
{
    public static class Utility
    {
        /*
        public static bool IsNullOrEmpty(this Array array)
        {
            return (array == null || array.Any());
        }
         */

        public static bool IsNullOrEmpty<T>(this T[] array) where T : class
        {
            return (array == null || !array.Any());
        }
    }
}
