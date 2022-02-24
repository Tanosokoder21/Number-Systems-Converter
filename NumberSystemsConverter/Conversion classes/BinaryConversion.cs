using NumberSystemsConverter.Conversion;

namespace NumberSystemsConverter.Conversion_classes
{
    //класс для бинарной конвертации
    public class BinaryConversion : BaseConversion
    {
        //наследование от базового конструктора и определения объекта интерфейса к стратегии бинарной конвертации
        public BinaryConversion(string Text) 
            : base(Text)
        {
            this.Text = Text;
            convertBehavior = new ToBinary(Text);
        }
    }
}
