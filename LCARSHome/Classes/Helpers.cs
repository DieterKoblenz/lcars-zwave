using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCARSHome
{
    public static class Helpers
    {
        public static bool In<T>(this T obj, params T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (Object.Equals(obj, values[i]))
                    return true;
            }
            return false;
        }
    }
}
