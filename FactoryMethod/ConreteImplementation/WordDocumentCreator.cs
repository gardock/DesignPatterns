using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConreteImplementation
{
    public class WordDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument(string name)
        {
            return new WordDocument();
        }
    }
}
