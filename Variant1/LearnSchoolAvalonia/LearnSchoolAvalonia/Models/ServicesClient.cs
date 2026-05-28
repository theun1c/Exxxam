using System;
using System.Collections.Generic;

namespace LearnSchoolAvalonia.Models;

public partial class ServicesClient
{
    public int Id { get; set; }

    public int? ServiceId { get; set; }

    public int? ClientId { get; set; }

    public DateTime? StartProvideService { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Service? Service { get; set; }
}
