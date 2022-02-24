using System;
using System.IO;
using NumberSystemsConverter.Conversion_classes;

namespace NumberSystemsConverter
{
    //класс для работы с текстом, созданный с использованием паттерна одиночка
    public sealed class FileWorker
    {
        /*
        Закрытое статическое свойство класса, которое хранит единственный экземпляр класса.
        Она инициализировано лениво - то есть оно будет выполняться только при первом обращении.
        Оно и гарантирует создание только одного экземпляра при обращении из нескольких потоков
        */
        private static readonly Lazy<FileWorker> instance =
            new Lazy<FileWorker>(() => new FileWorker());

        //Инстанция для доступа к экземпляру класса 
        public static FileWorker Instance
        {
            get
            {
                return instance.Value;
            }
        }

        //свойство для хранения пути к файлу записи
        public string FilePath { get; }

        //свойство для хранения текста в динамической памяти
        public string Text { get; private set; }

        /*
        особенность класса одиночки - приватный конструктор, 
        для того, чтобы у пользователя не было возможности создавать
        новые экземпляры класса
        */
        private FileWorker()
        {
            FilePath = "test.txt";
            ReadTextFromFile();
        }

        //метод для записи переданного текста в динамическую память
        public void WriteText(string text)
        {
            Text += text;
        }

        //метод для записи конвертированного числа в динамическую память
        public void ConvertFileWorker(int SysType, string text)
        {
            string ErrorMessage = "Error! Your option is wrong!";
            switch (SysType)
            {
                case 2:
                    BaseConversion bin = new BinaryConversion(text);
                    WriteText(text + " = " + bin.Converting() + "\n");
                    break;
                case 8:
                    BaseConversion oct = new OctalConversion(text);
                    WriteText(text + " = " + oct.Converting() + "\n");
                    break;
                case 16:
                    BaseConversion hex = new HexalConversion(text);
                    WriteText(text + " = " + hex.Converting() + "\n");
                    break;
                default:
                    WriteText(ErrorMessage);
                    break;
            }
            
        }


        //Метод, который сохраняет текст в файл 
        public void Save()
        {
            using (var writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine(Text);
            }
        }

        //Метод, для прочтения текста из файла
        private void ReadTextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";
            }
            else
            {
                using (var reader = new StreamReader(FilePath))
                {
                    Text = reader.ReadToEnd();
                }
            }
        }
    }
}