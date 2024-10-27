using Employee.Models;

var empmodel = new EmpModel();
int id = int.Parse(args[0]);
string name = args[1];
int deptno = int.Parse(args[2]);


if (empmodel.GetDepartments().Any(d => d.Id == deptno))
{
    empmodel.AddEmployee(id, name, deptno);
    Console.WriteLine("Employee added successfully.");
}
else
{
    Console.WriteLine($"Error: Department {deptno} does not exist.");
}


Console.WriteLine("\nList of Employees:");
if (empmodel.GetEmployees().Any())
{
    foreach (var item in empmodel.GetEmployees())
    {
        Console.WriteLine("{0} {1} {2}", item.Id, item.EmployeeName, item.DepartmentNo);
    }
}
else
{
    Console.WriteLine("No employees found.");
}

Console.WriteLine("\nList of Departments:");
if (empmodel.GetDepartments().Any())
{
    foreach (var item in empmodel.GetDepartments())
    {
        Console.WriteLine("{0} {1}", item.Id, item.Name);
    }
}
else
{
    Console.WriteLine("No departments found.");
}

// using Employee.Models;

// var empmodel = new EmpModel();
// int id = int.Parse(args[0]);
// string name = args[1];
// int deptno = int.Parse(args[2]);

// empmodel.AddEmployee(id,name,deptno);

// foreach (var item in empmodel.GetEmployees()) 
// {
//     Console.WriteLine("{0} {1} {2}", item.Id, item.EmployeeName, item.DepartmentNo); 
// }

// foreach (var item in empmodel.GetDepartments())
// {
//     Console.WriteLine("{0} {1}", item.Id, item.Name);
// }





