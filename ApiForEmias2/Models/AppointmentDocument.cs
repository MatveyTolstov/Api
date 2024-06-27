using System;
using System.Collections.Generic;

namespace ApiForEmias2.Models;

public partial class AppointmentDocument
{
    public int? IdAppointmentDocument { get; set; }

    public int AppointmentId { get; set; }

    public string NameDocument { get; set; } = null!;

    public string Rtf { get; set; } = null!;
}
