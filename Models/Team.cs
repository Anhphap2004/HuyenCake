using System;
using System.Collections.Generic;

namespace HuyenCake.Models;

public partial class Team
{
    public int TeamId { get; set; }

    public string? Name { get; set; }

    public string? Position { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }
}
