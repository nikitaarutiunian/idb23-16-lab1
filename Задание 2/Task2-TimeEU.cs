using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class EuropeanDateTimePrinter : IDateTimePrinter
    {
        public string PrintDateTime()
        {
            CultureInfo culture = new CultureInfo("fr-FR");
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString(culture));
            return sb.ToString();
        }
    }
}