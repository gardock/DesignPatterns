using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConreteImplementation
{
    public class ExcelDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument(string name)
        {
            DoOtherStuff();
            if (name.Contains("xlsx")) return new XLSXDocument();
            return new ExcelDocument();
        }

        public void DoOtherStuff()
        {
            Console.WriteLine("Inne czynności przed utworzeniem obiektu z fabryki ExcelDocumentCreator");
        }
    }
}
