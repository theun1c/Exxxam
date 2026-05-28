using System;
using System.Collections.Generic;

namespace LearnSchoolAvalonia.Models;

public partial class Image
{
    public int Id { get; set; }

    public string MainImage { get; set; } = null!;

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
