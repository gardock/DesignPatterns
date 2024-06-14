using FactoryMethod;
using FactoryMethod.ConreteImplementation;
using FactoryMethod.Interfaces;

DocumentCreator creator;

creator = new WordDocumentCreator();
IDocument document = creator.CreateDocument("testWord.doc");
Console.WriteLine(document.ReadContentAsString());

creator = new ExcelDocumentCreator();
document = creator.CreateDocument("testExcel.xls");
Console.WriteLine(document.ReadContentAsString());

document = creator.CreateDocument("testExcel.xlsx");
Console.WriteLine(document.ReadContentAsString());

Console.ReadKey();
