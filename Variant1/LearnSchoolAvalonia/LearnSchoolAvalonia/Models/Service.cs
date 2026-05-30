using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Collections.Generic;

namespace LearnSchoolAvalonia.Models;

public partial class Service
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Cost { get; set; }

    public int DurationSec { get; set; }

    public int DurationMinutes => DurationSec / 60;

    public string Description { get; set; } = null!;

    public int? Discount { get; set; }

    public int? ImageId { get; set; }

    public virtual Image? Image { get; set; }

    public Bitmap? ImageBitmap
    {
        get
        {
            var path = Image?.MainImage?.Replace("\\", "/");

            if (string.IsNullOrWhiteSpace(path))
                return null;

            var uri = new Uri($"avares://LearnSchoolAvalonia/Assets/{path}");

            return new Bitmap(AssetLoader.Open(uri));
        }
    }

    public virtual ICollection<ServicesClient> ServicesClients { get; set; } = new List<ServicesClient>();
}
