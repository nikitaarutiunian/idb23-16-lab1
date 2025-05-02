using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

class Program
{
    static void Main(string[] args)
    {
        // Базовый вывод
        IDateTimePrinter europeanPrinter = new EuropeanDateTimePrinter();
        IDateTimePrinter americanPrinter = new AmericanDateTimePrinter();

        // Декорирование с одним префиксом и одним суффиксом
        IDateTimePrinter decoratedPrinter =
            new PrefixDecorator(
                new SuffixDecorator(
                    new EuropeanDateTimePrinter(),
                    "...Теперь ты знаешь время!"  // Суффикс с временной зоной
                ),
                "Сейчас..."      // Осмысленный префикс
            );

        Console.WriteLine("European format: " + europeanPrinter.PrintDateTime());
        Console.WriteLine("American format: " + americanPrinter.PrintDateTime());
        Console.WriteLine("Decorated format: " + decoratedPrinter.PrintDateTime());
    }
}
