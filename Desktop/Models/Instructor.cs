using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop.Models;

public partial class Instructor
{
    public int InsID { get; set; }

    public DateOnly? Hiredate { get; set; }

    [ForeignKey("InsID")]
    public virtual Person Person { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
