using NumberSystemsConverter.Conversion;

namespace NumberSystemsConverter.Conversion_classes
{
    //класс для шестнадцатеричной конвертации
    public class HexalConversion : BaseConversion
    {
        //наследование от базового конструктора и определения объекта интерфейса к стратегии шестнадцатеричной конвертации
        public HexalConversion(string Text) 
            : base(Text)
        {
            this.Text = Text;
            convertBehavior = new ToHex(Text);
        }
    }
}
