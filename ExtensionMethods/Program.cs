using ExtensionMethods.TCPData;

// ################################################
// ###### LINQ Query Synthax vs TSQL Synthax ######
// ################################################

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

//List<Department> deparmentList = Data.GetDepartments();
//var filteredDeparments = deparmentList.Filter(dept => dept.ShortName == "HR" || dept.ShortName == "IT");
//var filteredDeparments = deparmentList.Filter(dept => dept.Id > 1);

//foreach (var deparment in filteredDeparments)
//{

//    Console.WriteLine($"Id: {deparment.Id}");
//    Console.WriteLine($"Short Name: {deparment.ShortName}");
//    Console.WriteLine($"Long Name: {deparment.LongName}");
//    Console.WriteLine();
//};


List<Employee> employeeList = Data.GetEmployees();
List<Department> deparmentList = Data.GetDepartments();

var resultList = from emp in employeeList
                 join dept in deparmentList
                 on emp.DepartmentId equals dept.Id
                 select new
                 {
                     FirstName = emp.FirstName,
                     LastName = emp.LastName,
                     AnnualSalary = emp.AnnualSalary,
                     Manager = emp.IsManager,
                     Department = emp.DepartmentId,
                 };

foreach (var employee in resultList)
{
    Console.WriteLine($"First Name: {employee.FirstName}");
    Console.WriteLine($"Last Name: {employee.LastName}");
    Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
    Console.WriteLine($"Manager: {employee.Manager}");
    Console.WriteLine($"Department: {employee.Department}");
    Console.WriteLine();
}

var averageAnnualSalary = resultList.Average(a => a.AnnualSalary);
var highestAnnualSalary = resultList.Max(a => a.AnnualSalary);
var lowestAnnualSalary = resultList.Min(a => a.AnnualSalary);

Console.WriteLine($"Avergage annual salary: {averageAnnualSalary}");
Console.WriteLine($"Highest annual salary: {highestAnnualSalary}");
Console.WriteLine($"Lowest annual salary: {lowestAnnualSalary}");