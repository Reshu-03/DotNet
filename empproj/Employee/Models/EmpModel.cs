using Employee.Data;


namespace Employee.Models
{
    public class EmpModel
    {
        public IEnumerable<Emps> GetEmployees()
        {
            using var emp = new EmpDbContext();
            var selection = from e in emp.Employees
                            select new Emps
                            {
                                Id = e.Id,
                                EmployeeName = e.EmployeeName,
                                DepartmentNo = e.DepartmentNo
                            };
            return selection.ToList();
        }

        public IEnumerable<Depts> GetDepartments()
        {
            using var dept = new EmpDbContext();
            var selection = from d in dept.Departments
                            select new Depts
                            {
                                Id = d.Id, 
                                Name = d.Name 
                            };
            return selection.ToList();
        }

        public void AddEmployee(int id, string name, int deptno)
        {
            using var emp = new EmpDbContext();
            var existingEmployee = emp.Employees.Find(id);
            if (existingEmployee == null)
            {
                var newEmployee = new Data.Employee
                {
                    Id = id,
                    EmployeeName = name,
                    DepartmentNo = deptno
                };
                emp.Employees.Add(newEmployee);
                emp.SaveChanges(); 
            }
            
        }
    }
}
