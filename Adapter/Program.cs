using Adapter;
int employeeId = 12;
var employee = new LegacyGetEmployeeDetails();
Console.WriteLine(employee.GetEmpDet(employeeId));

Console.WriteLine();

var adapter = new EmployeeDetailsAdapter(employee);
Console.WriteLine(adapter.GetEmployeeDetails(employeeId));

Console.ReadKey();