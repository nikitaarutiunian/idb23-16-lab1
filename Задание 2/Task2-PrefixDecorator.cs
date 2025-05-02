using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class PrefixDecorator : IDateTimePrinter
    {
        private IDateTimePrinter _printer;
        private string _prefix;

        public PrefixDecorator(IDateTimePrinter printer, string prefix)
        {
            _printer = printer;
            _prefix = prefix;
        }

        public string PrintDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_prefix);
            sb.Append(_printer.PrintDateTime());
            return sb.ToString();
        }
    }
}
