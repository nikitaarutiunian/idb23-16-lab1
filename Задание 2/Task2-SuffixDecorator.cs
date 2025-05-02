using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SuffixDecorator : IDateTimePrinter
    {
        private IDateTimePrinter _printer;
        private string _suffix;

        public SuffixDecorator(IDateTimePrinter printer, string suffix)
        {
            _printer = printer;
            _suffix = suffix;
        }

        public string PrintDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_printer.PrintDateTime());
            sb.Append(_suffix);
            return sb.ToString();
        }
    }

}
