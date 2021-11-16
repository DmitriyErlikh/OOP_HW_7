using System;
using System.Collections.Generic;

namespace OOP_HW_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Добрый день Павел!";
            Console.WriteLine(text);
            var coderA = new ACoder();
            var codeTextA = coderA.Encoder(text);
            Console.WriteLine(codeTextA);
            var decodeTextA = coderA.Decode(codeTextA);
            Console.WriteLine(decodeTextA);
            Console.ReadLine();
            Console.Clear();

            /*Кривое исполнение второго варианта (на сколько мозгов хватило, не принимает пробелы
            и на моменте кодировки приводит всё к нижнему регистру)*/
            var text2 = "Привет";
            var coderB = new BCoder();
            var codeTextB = coderB.Encoder(text2);
            Console.WriteLine(codeTextB);
            var decodeTextB = coderB.Decode(codeTextB);
            Console.WriteLine(decodeTextB);
            Console.ReadLine();
        }
    }
}
