using System;
using System.Collections.Generic;

namespace HuyenCake.Models;

public partial class NewsCategory
{
    public int NewsCategoryId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<News> News { get; set; } = new List<News>();
}
