using System;
using System.Collections.Generic;

namespace ef_module1_scaffold.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int GroupId { get; set; }

    public virtual Group Group { get; set; } = null!;
}
