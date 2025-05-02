using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AmericanDateTimePrinter : IDateTimePrinter
    {
        public string PrintDateTime()
        {
            CultureInfo culture = new CultureInfo("en-US");
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString(culture));
            return sb.ToString();
        }
    }
}
