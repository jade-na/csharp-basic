using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread_pool
{
    internal class AutoUnitConvertUtills
    {
        public static string Convert(decimal bytes, int decimals=2)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB"};
            int order = 0;
            while(bytes >= 1024 && order < sizes.Length)
            {
                bytes /= 1024;
                order++;
            }
            return $"{Math.Round(bytes, decimals)} {sizes[order]}";
        }
    }
}
