using NumberSystemsConverter.Conversion;

namespace NumberSystemsConverter.Conversion_classes
{
    //Базовый абстрактный класс для контекста Конвертации  
    public abstract class BaseConversion
    {
        //композиция с интерфейсом поведения конвертации
        protected IConversion convertBehavior;

        //публичные свойства для хранения текста и конвертированного текста
        public string Text { get; protected set; }
        public string Result { get; protected set; }

        //конструктор по умолчанию
        public BaseConversion()
        {
            Text = null;
            Result = null;
        }

        //конструктор с параметром
        public BaseConversion(string Text)
        {
            this.Text = Text;
        }

        //метод который возвращает конвертированного число
        public virtual string Converting()
        {
            return convertBehavior.Converting();
        }
    }
}
