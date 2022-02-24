using NumberSystemsConverter.Conversion;

namespace NumberSystemsConverter.Conversion_classes
{
    //класс для восьмеричной конвертации
    public class OctalConversion : BaseConversion
    {
        //наследование от базового конструктора и определения объекта интерфейса к стратегии восьмеричной конвертации
        public OctalConversion(string Text)
            : base(Text)
        {
            this.Text = Text;
            convertBehavior = new ToOctal(Text);
        }
    }
}
