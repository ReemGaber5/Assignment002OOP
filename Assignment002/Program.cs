using System.Globalization;
using System.Reflection;
using System.Xml.Linq;

namespace Assignment002
{

    #region Q1-Design and implement a Class for the employees in a company
    //public enum securityprivileges
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}
    //public class Employee
    //{
    //    public int _ID { get; set; }
    //    public string _Name { get; set; }
    //    public securityprivileges _securitylevel { get; set; }
    //    public decimal _salary { get; set; }
    //    public DateTime _hiredate { get; set; }
    //    private char gender;
    //    public char _Gender
    //    {
    //        get => gender;
    //        set
    //        {
    //            if (value != 'M' && value != 'F')
    //                throw new ArgumentException("Gender must be 'M' or 'F'.");
    //            gender = value;
    //        }
    //    }

    //    public Employee(int id, string name, securityprivileges securityLevel, decimal salary,
    //               DateTime hireDate, char gender)
    //    {
    //        _ID = id;
    //        _Name = name;
    //        _securitylevel = securityLevel;
    //        _salary = salary;
    //        _hiredate = hireDate;
    //        _Gender = gender;
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format(
    //            "ID: {0}, Name: {1}, Security Level: {2}, Salary: {3}, Hire Date: {4:yyyy-MM-dd}, Gender: {5}",
    //            _ID,
    //            _Name,
    //            _securitylevel,
    //            _salary.ToString("C", CultureInfo.CurrentCulture),
    //            _hiredate,
    //            _Gender
    //        );
    //    }
    //}

    #endregion

    #region Q2-Develop a Class to represent the Hiring Date Data

    //public class Hiringdate
    //{
    //    private int day;
    //    private int month;  
    //    private int year;

    //    public int _Day
    //    {
    //        get => day;
    //        set
    //        {
    //            if(value < 1 || value>31)
    //            {
    //                throw new ArgumentException("day muust be between 1 and 31");
    //            }
    //            day = value;
    //        }
    //    }

    //    public int _Month
    //    {
    //        get => month;
    //        set
    //        {
    //            if (value < 1 || value > 12)
    //            {
    //                throw new ArgumentException("month muust be between 1 and 12");
    //            }
    //            month = value;
    //        }
    //    }

    //    public int _Year
    //    {
    //        get => year;
    //        set
    //        {
    //            if (value < 1950 || value > DateTime.Now.Year)
    //            {
    //                throw new ArgumentException("month muust be between 1950 and Current year");
    //            }
    //            year = value;
    //        }
    //    }

    //    public Hiringdate(int Day,int Month , int Year )
    //    {
    //        _Day = Day;
    //        _Month = Month;
    //        _Year = Year;

    //    }
    //    public override string ToString()
    //    {
    //        return $"{day:D2}/{month:D2}/{year}";
    //    }


    //}
    #endregion

    #region Q3
    //public enum Role
    //{
    //    DBA,
    //    Guest,
    //    SecurityOfficer
    //}

    //public class Employee
    //{
    //    private int id;
    //    private string name;

    //    public int _ID
    //    {
    //        get { return id; }
    //        set 
    //        {
    //            if (value <= 0)
    //            {
    //                throw new ArgumentException("Id must be greater that 0");
    //            }
    //            id = value;
    //        }
    //    }

    //    public string _Name
    //    {
    //        get => name;
    //        set
    //        {
    //            if (string.IsNullOrEmpty(value))
    //            {
    //                throw new ArgumentException("name can not be empty");
    //            }
    //            name = value;
    //        }
    //    }

    //    public Role _role { get; set; }  

    //    public bool _Fullpermission { get; set; }

    //    public Employee(int Id,string Name,Role role )
    //    {
    //        _ID = Id;
    //        _Name = Name;
    //        _role = role;
    //        _Fullpermission = (role == Role.SecurityOfficer);

    //    }

    //    public void DisplayEmployeeDetails()
    //    {
    //        Console.WriteLine($"Name: {_Name}");
    //        Console.WriteLine($"Role: {_role}");
    //        Console.WriteLine($"Full Permissions: {_Fullpermission}");
    //    }

    //}

    #endregion

    #region Q4
    public class Employee
    {
        public string _Name { get; set; }
        public DateTime _hiredate { get; set; }
       

        public Employee(string name, DateTime hireDate)

        {
            _Name = name;
            _hiredate = hireDate;
          
        }

        public override string ToString()
        {
            return $"{_Name} - {_hiredate.ToShortDateString()}";
        }

    }
    #endregion
    internal class Program
    {
     
        static void Main(string[] args)
        {
            #region Q1-Design and implement a Class for the employees in a company
            //try
            //{
            //    Console.WriteLine("Enter employtee details:");

            //    Console.WriteLine("Enter ID:");
            //    int ID = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter Name:");
            //    string Name = Console.ReadLine();

            //    Console.WriteLine("Select Security Level (0: Guest, 1: Developer, 2: Secretary, 3: DBA): ");
            //    securityprivileges securityLevel = (securityprivileges)int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter Salary:");
            //    decimal salary = decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter HiringDate:");
            //    DateTime hiredate = DateTime.Parse(Console.ReadLine());

            //    Console.Write("Enter Gender (M/F): ");
            //    char gender = char.ToUpper(Console.ReadKey().KeyChar);
            //    Console.WriteLine();

            //    Employee emp = new Employee(ID, Name, securityLevel, salary, hiredate, gender);
            //    Console.WriteLine(emp.ToString());

            //}
            //catch (Exception ex) 
            //{
            //    throw ex;

            //}
            #endregion

            #region Q2-Develop a Class to represent the Hiring Date Data
            //try
            //{
            //    Console.Write("Enter day: ");
            //    int day = int.Parse(Console.ReadLine());

            //    Console.Write("Enter month: ");
            //    int month = int.Parse(Console.ReadLine());

            //    Console.Write("Enter year: ");
            //    int year = int.Parse(Console.ReadLine());

            //    Hiringdate hiringDate = new Hiringdate(day, month, year);

            //    Console.WriteLine($"The Hiring Date is: {hiringDate}");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            #endregion


            #region Q3

            //Employee[] emparr = new Employee[3];

            //emparr[0]=new Employee(1,"Ahmed",Role.DBA);
            //emparr[1] = new Employee(2, "Alaa", Role.Guest);
            //emparr[2] = new Employee(3, "Sara", Role.SecurityOfficer);

            //foreach (var emp in emparr)
            //{
            //    emp.DisplayEmployeeDetails();
            //}


            #endregion

            #region Q4

            List<Employee> employees = new List<Employee>
            {
                new Employee("Ali", new DateTime(2020, 5, 10)),
                new Employee("Ahmed", new DateTime(2018, 3, 22)),
                new Employee("Alaa", new DateTime(2022, 7, 15)),
                new Employee("Sara", new DateTime(2019, 11, 1))
            };


            var sortemployess=employees.OrderBy(e=>e._hiredate).ToList();
            foreach (var emp in sortemployess)
            {
                Console.WriteLine(emp);
            }





            #endregion


        }
    }
}
