namespace ExtensionMethods.TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Long",
                AnnualSalary = 60000.3m,
                IsManager = true,
                DepartmentId = 1,
            };
            employees.Add(employee);

            employee = new Employee()
            {
                Id = 2,
                FirstName = "Sara",
                LastName = "Jameson",
                AnnualSalary = 80000.1m,
                IsManager = true,
                DepartmentId = 2,
            };
            employees.Add(employee);

            employee = new Employee()
            {
                Id = 3,
                FirstName = "Bob",
                LastName = "Martin",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 2,
            };
            employees.Add(employee);

            employee = new Employee()
            {
                Id = 4,
                FirstName = "Faith",
                LastName = "Evans",
                AnnualSalary = 60000.3m,
                IsManager = false,
                DepartmentId = 3,
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> deparments = new List<Department>();

            Department deparment = new Department()
            {
                Id = 1,
                ShortName = "IT",
                LongName = "Information Tecnology"
            };
            deparments.Add(deparment);

            deparment = new Department()
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"
            };
            deparments.Add(deparment);

            deparment = new Department()
            {
                Id = 3,
                ShortName = "HR",
                LongName = "Human Recourses"
            };
            deparments.Add(deparment);

            return deparments;
        }
    }
}
