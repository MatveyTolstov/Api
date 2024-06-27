using System;
using System.Collections.Generic;

namespace ApiForEmias2.Models;

public partial class Patient
{
    public long? Oms { get; set; }

    public string Surname { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public string Addresss { get; set; } = null!;

    public string LivingAddress { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Nickname { get; set; }


}
