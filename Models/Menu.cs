using System;
using System.Collections.Generic;

namespace HuyenCake.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public int? ParentId { get; set; }

    public int? DisplayOrder { get; set; }
}
