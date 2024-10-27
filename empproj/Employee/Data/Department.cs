using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Data;

[Table("dept")]
public class Department
{
    [Column("deptno")]
    public int Id { get; set; }

    [Column("dname")]
    public required string Name { get; set; }
}
// INSERT INTO dept (deptno , dname , loc) VALUES