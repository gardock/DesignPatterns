using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConreteImplementation
{
    public class WordDocument : IDocument
    {
        public void Close()
        {
            Console.WriteLine("Zamknięto dokument word");
        }

        public void Open()
        {
            Console.WriteLine("Otwarto dokument word");
        }

        public string Read()
        {
            return "Zawartość dokument word";
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
