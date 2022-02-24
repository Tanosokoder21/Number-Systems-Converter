using System;
using NumberSystemsConverter.Conversion_classes;

namespace NumberSystemsConverter.Conversion
{
    //наследования от интерфейса и базового класса
    class ToBinary : BaseConversion, IConversion
    {
        //наследуем от базового конструктора
        public ToBinary(string Text) 
            : base(Text)
        {
            this.Text = Text;
        }

        //переопределяем метод конвертации и реализуем двоичное преобразование десятичного числа
        public override string Converting()   
        {
            int Number = Convert.ToInt32(Text);

            Result = Convert.ToString(Number, 2);

            return Result;
        }
    }
}
