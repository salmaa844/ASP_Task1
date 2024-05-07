using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Title { get; set; } = null!;
}
