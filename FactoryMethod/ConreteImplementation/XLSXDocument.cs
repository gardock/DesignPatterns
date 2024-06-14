using FactoryMethod.Interfaces;

namespace FactoryMethod.ConreteImplementation
{
    public class XLSXDocument : IDocument
    {
        public void Close()
        {
            Console.WriteLine("Zamknięto dokument xlsx");
        }

        public void Open()
        {
            Console.WriteLine("Otwarto dokument xlsx");
        }

        public string Read()
        {
            return "Zawartość dokument xlsx";
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
