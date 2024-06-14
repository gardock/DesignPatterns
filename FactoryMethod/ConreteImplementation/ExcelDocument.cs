using FactoryMethod.Interfaces;

namespace FactoryMethod.ConreteImplementation
{
    public class ExcelDocument : IDocument
    {
        public void Close()
        {
            Console.WriteLine("Zamknięto dokument excel");
        }

        public void Open()
        {
            Console.WriteLine("Otwarto dokument excel");
        }

        public string Read()
        {
            return "Zawartość dokument excel";
        }

        public string ReadContentAsString()
        {
            this.Open();
            var content = this.Read();
            this.Close();
            return content;
        }
    }
}
