using System;
using System.Collections.Generic;

namespace ApiForEmias2.Models;

public partial class ResearchDocument
{
    public int? IdResearchDocument { get; set; }

    public int AppointmentId { get; set; }

    public string Name { get; set; } = null!;

    public string Rtf { get; set; } = null!;

    public byte[]? Attachment { get; set; }
}
