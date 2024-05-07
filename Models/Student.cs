using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public decimal Gpa { get; set; }

    public int Age { get; set; }
}
