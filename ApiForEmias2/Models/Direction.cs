using System;
using System.Collections.Generic;

namespace ApiForEmias2.Models;

public partial class Direction
{
    public int? IdDirection { get; set; }

    public int SpecialityId { get; set; }

    public long Oms { get; set; }

}
