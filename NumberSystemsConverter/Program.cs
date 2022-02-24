using System;

namespace NumberSystemsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //переменные для хранения типа в какую систему конвертировать и числа для конвертирования
            int sys;
            string Number;

            Console.WriteLine("\t\t\t\t\t\tHello! \n\nThis is mini console app for converting decimal numbers " +
                "into three different number systems;");

            Console.WriteLine("So enter your system and number for converting there: ");

            sys = Convert.ToInt32(Console.ReadLine());

            Number = Console.ReadLine();

            //создаем инстанцию класса одиночки
            var singleton = FileWorker.Instance;

            //конвертируем число и сохраняем ее пока в дин. память
            singleton.ConvertFileWorker(sys, Number);

            //сохраняем ее в файл
            singleton.Save();

            //выводим все конвертированные числа из файла и системы их счисления откуда они были конвертированы
            Console.WriteLine($"Your previous and current results: \n{singleton.Text}is written to a {singleton.FilePath}");
        }
    }
}
