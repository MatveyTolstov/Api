using System;
using System.Collections.Generic;

namespace ApiForEmias2.Models;

public partial class Speciality
{
    public int? IdSpeciality { get; set; }

    public string Name { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

}
