using ExtensionMethods.TCPData;
using ExtensionMethods.TCPExtensions;

//List<Employee> employeeList = Data.GetEmployees();

//var filteredEmployees = employeeList.Filter(emp => emp.IsManager == true);
//var filteredEmployees = employeeList.Filter(emp => emp.IsManager == false);
//var filteredEmployees = employeeList.Filter(emp => emp.AnnualSalary > 50000);

//foreach (var employee in filteredEmployees)
//{

//    Console.WriteLine($"First Name: {employee.FirstName}");
//    Console.WriteLine($"Last Name: {employee.LastName}");
//    Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
//    Console.WriteLine($"Mannager: {employee.IsManager}");
//    Console.WriteLine();
//};

List<Department> deparmentList = Data.GetDepartments();
//var filteredDeparments = deparmentList.Filter(dept => dept.ShortName == "HR" || dept.ShortName == "IT");
var filteredDeparments = deparmentList.Filter(dept => dept.Id > 1);

foreach (var deparment in filteredDeparments)
{

    Console.WriteLine($"Id: {deparment.Id}");
    Console.WriteLine($"Short Name: {deparment.ShortName}");
    Console.WriteLine($"Long Name: {deparment.LongName}");
    Console.WriteLine();
};