using System;
using System.Collections.Generic;

namespace ApiForEmias2.Models;

public partial class Admin
{
    public int? IdAdmin { get; set; }

    public string Surname { get; set; } = null!;

    public string AdminName { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string EnterPassword { get; set; } = null!;
}
