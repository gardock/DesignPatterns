
using Prototype;

Report report = new Report() { ID = 1, 
    Info = new HeaderData() { 
        Title = "test", 
        Author = "Kowalski" 
    } 
};
Console.WriteLine(report);

Report clonedReport = report.DeepCopy();
clonedReport.ID = 2;
Console.WriteLine(clonedReport);

Report clonedReport2 = report.DeepCopy();
clonedReport2.ID = 3;
clonedReport2.Info.Title = "nowy";
Console.WriteLine(clonedReport2);

Console.ReadKey();