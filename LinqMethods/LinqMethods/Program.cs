////List<Employee> employeelist = Data.GetEmployees();
////List<Department> departmentslist = Data.GetDepartments();
////// select and where operators - Method Syntax
////var result = employeelist.Select(e => new
////{
////    fullname = e.FirstName + " " + e.LastName,
////    AnnualSalary = e.AnnualSalary
////}).Where(e=> e.AnnualSalary>=50000);
////foreach (var item in result)
////{
////    Console.WriteLine($"{item.fullname,-20} {item.AnnualSalary}");
////}
////var restults = from emp in employeelist
////               where emp.AnnualSalary >= 50000
////               select new
////               {
////                   fullname = emp.FirstName + " " + emp.LastName,
////                   annualsalary = emp.AnnualSalary
////               };


////foreach (var item in restults)
////{
////    Console.WriteLine($"{item.fullname,-20} {item.annualsalary}");
////}
//Console.ReadKey();

//public static class EnumerableCollectionMethods
//{
//    public static IEnumerable<Employee> GetHighSalalry(this IEnumerable<Employee> employees)
//    {
//        foreach (Employee emp in employees)
//        {
//            Console.WriteLine(emp.FirstName + " " + emp.LastName);
//            if (emp.AnnualSalary >= 50000)
//            {
//                yield return emp;
//            }
//        }
//    }
//    public class Employee
//    {
//        public int Id { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public decimal AnnualSalary { get; set; }
//        public bool IsManager { get; set; }
//        public int DepartmentId { get; set; }
//    }

//    public class Department
//    {
//        public int Id { get; set; }
//        public string ShortName { get; set; }
//        public string LongName { get; set; }
//    }
//    public static class Data
//    {
//        public static List<Employee> GetEmployees()
//        {
//            List<Employee> employees = new List<Employee>();

//            Employee employee = new Employee
//            {
//                Id = 1,
//                FirstName = "Bob",
//                LastName = "Jones",
//                AnnualSalary = 60000.3m,
//                IsManager = true,
//                DepartmentId = 1
//            };
//            employees.Add(employee);
//            employee = new Employee
//            {
//                Id = 2,
//                FirstName = "Sarah",
//                LastName = "Jameson",
//                AnnualSalary = 80000.1m,
//                IsManager = true,
//                DepartmentId = 2
//            };
//            employees.Add(employee);
//            employee = new Employee
//            {
//                Id = 3,
//                FirstName = "Douglas",
//                LastName = "Roberts",
//                AnnualSalary = 40000.2m,
//                IsManager = false,
//                DepartmentId = 2
//            };
//            employees.Add(employee);
//            employee = new Employee
//            {
//                Id = 4,
//                FirstName = "Jane",
//                LastName = "Stevens",
//                AnnualSalary = 30000.2m,
//                IsManager = false,
//                DepartmentId = 3
//            };
//            employees.Add(employee);

//            return employees;
//        }

//        public static List<Department> GetDepartments()
//        {
//            List<Department> departments = new List<Department>();

//            Department department = new Department
//            {
//                Id = 1,
//                ShortName = "HR",
//                LongName = "Human Resources"
//            };
//            departments.Add(department);
//            department = new Department
//            {
//                Id = 2,
//                ShortName = "FN",
//                LongName = "Finance"
//            };
//            departments.Add(department);
//            department = new Department
//            {
//                Id = 3,
//                ShortName = "TE",
//                LongName = "Technology"
//            };
//            departments.Add(department);

//            return departments;
//        }

//    }
//}



//using System.Linq;
////// Specify the data source.
//int[] scores = [97, 92, 81, 60];
//int[] arr = [97, 92, 1, 2];
////// Define the query expression.
////IEnumerable<int> scoreQuery =
////    from score in scores

////    select score;

//var x = scores.Union(arr);


//// Execute the query.
//foreach (var i in x)
//{
//    Console.Write(i + " ");
//}

//// Output: 97 92 81

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

public record City(string Name, long Population);
public record Country(string Name, double Area, long Population, List<City> Cities);
public record Product(string Name, string Category);

public class Program
{
    public static readonly City[] cities = {
        new City("Tokyo", 37_833_000),
        new City("Delhi", 30_290_000),
        new City("Shanghai", 27_110_000),
        new City("São Paulo", 22_043_000),
        new City("Mumbai", 20_412_000),
        new City("Beijing", 20_384_000),
        new City("Cairo", 18_772_000),
        new City("Dhaka", 17_598_000),
        new City("Osaka", 19_281_000),
        new City("New York-Newark", 18_604_000),
        new City("Karachi", 16_094_000),
        new City("Chongqing", 15_872_000),
        new City("Istanbul", 15_029_000),
        new City("Buenos Aires", 15_024_000),
        new City("Kolkata", 14_850_000),
        new City("Lagos", 14_368_000),
        new City("Kinshasa", 14_342_000),
        new City("Manila", 13_923_000),
        new City("Rio de Janeiro", 13_374_000),
        new City("Tianjin", 13_215_000)
    };

    public static readonly Country[] countries = {
        new Country("Vatican City", 0.44, 526, new List<City> { new City("Vatican City", 826) }),
        new Country("Monaco", 2.02, 38_000, new List<City> { new City("Monte Carlo", 38_000) }),
        new Country("Nauru", 21, 10_900, new List<City> { new City("Yaren", 1_100) }),
        new Country("Tuvalu", 26, 11_600, new List<City> { new City("Funafuti", 6_200) }),
        new Country("San Marino", 61, 33_900, new List<City> { new City("San Marino", 4_500) }),
        new Country("Liechtenstein", 160, 38_000, new List<City> { new City("Vaduz", 5_200) }),
        new Country("Marshall Islands", 181, 58_000, new List<City> { new City("Majuro", 28_000) }),
        new Country("Saint Kitts & Nevis", 261, 53_000, new List<City> { new City("Basseterre", 13_000) })
    };

    public static void Main()
    {
        var x = from  country in countries

                where country.Name.StartsWith('T')
                select country;
        
            

        foreach (var city in x)
        {
            Console.WriteLine(city.Name);
        }
    }
}
