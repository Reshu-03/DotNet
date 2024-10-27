using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Data;

[Table("employe")]
public class Employee
{
    [Column("empno")]
    public required int Id { get; set; }

    [Column("ename")]
    public required string EmployeeName { get; set; }

    [Column("deptno")]
    public int DepartmentNo { get; set; }
}
//  INSERT INTO employe (empno, ename, job, mgr, hiredate, sal, comm, deptno) VALUES