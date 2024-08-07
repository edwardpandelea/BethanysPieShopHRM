﻿using BethanysPieShopHRM;
using BethanysPieShopHRM.HR;

#region Comments
//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
//Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
//Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
//Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
//Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
//Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

//Employee[] employees = new Employee[7];

//IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);


//Console.Write("How many hours do we need to register for Bethany?");
//int numberOfHours = 0;
//string input = Console.ReadLine();
//numberOfHours = int.Parse(input);

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(numberOfHours);


//employees[0] = bethany;
//employees[1] = george;
//employees[2] = mary;
//employees[3] = bobJunior;
//employees[4] = kevin;
//employees[5] = kate;
//employees[6] = kim;



//foreach (var employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(25);
//    employee.PerformWork(numberOfHoursWorked);
//    employee.ReceiveWage();
//}

//int[] sampleArray1 = new int[5];


//int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };

////int[] sampleArray3 = new int[6] { 1, 2, 3, 4, 5 };


//Console.WriteLine("How many employees IDs do you want to register?");

//int length = int.Parse(Console.ReadLine());

//int[] employeeIds = new int[length];

////var testId = employeeIds[0];
////Console.WriteLine(testId);

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());//let's assume here that the user will always enter an int value
//    employeeIds[i] = id;
//}

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//Array.Sort(employeeIds);

//Console.WriteLine("After sorting");
//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}


//int[] employeeIdsCopy = new int[length];

//employeeIds.CopyTo(employeeIdsCopy, 0);

//Array.Reverse(employeeIds);

//Console.WriteLine("After reversing original array");

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//Console.WriteLine("Copy of array");

//for (int i = 0; i < employeeIdsCopy.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIdsCopy[i]}");
//}


//List<int> employeeIds = new List<int>();
//employeeIds.Add(55);
//employeeIds.Add(1);
//employeeIds.Add(943);
//employeeIds.Add(78);
//employeeIds.Add(78);

////employeeIds.Add("test");

//if (employeeIds.Contains(78))
//{
//    Console.WriteLine("78 is found!");
//}



//int currentAmountOfEmployees = employeeIds.Count;

//var employeeIdsArray = employeeIds.ToArray();


//employeeIds.Clear();


//Console.WriteLine("How many employees IDs do you want to register?");

//int length = int.Parse(Console.ReadLine());

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());//let's assume here that the user will always enter an int value
//    employeeIds.Add(id);
//}

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
//Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
//Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
//Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
//Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
//Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

//List<Employee> employees = new List<Employee>(); 
//employees.Add(george);
//employees.Insert(0, bethany);
//employees.Add(mary);

//employees.Add(bobJunior);

//employees.Add(kevin);
//employees.Add(kate);
//employees.Add(kim);
////employees.Add(kim);

//foreach (var employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//}

//Console.ReadLine();

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork(8);
//bethany.PerformWork();
//bethany.PerformWork(3);
//bethany.ReceiveWage();

//mary.DisplayEmployeeDetails();
//mary.PerformWork(12);
//mary.PerformWork();
//mary.PerformWork();
//mary.PerformWork();
//mary.ReceiveWage();

////mary.AttendManagementMeeting();

//mary.GiveBonus();

//bobJunior.ResearchNewPieTastes(5);
//bobJunior.ResearchNewPieTastes(5);
//IEmployee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
//IEmployee bobJunior = new JuniorReasearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
//IEmployee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
//IEmployee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);


//List<IEmployee> employees = new List<IEmployee>();
//employees.Add(bethany);
//employees.Add(bobJunior);
//employees.Add(mary);
//employees.Add(kevin);
//employees.Add(kate);

//foreach(Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    employee.GiveBonus();
//    employee.GiveCompliment();
//}
#endregion



List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("***********************************");
Console.WriteLine("* Bethany's Pie Shop Employee App *");
Console.WriteLine("***********************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("********************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("5: Load specific employee");
    Console.WriteLine("9: Quit application");
    Console.Write("Your selection: ");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployees(employees);
            break;
        case "4":
            Utilities.LoadEmployees(employees);
            break;
        case "5":
            Utilities.LoadEmployeeById(employees);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
}
while (userSelection != "9");

Console.WriteLine("Thanks for using the application");