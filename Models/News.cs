using System;
using System.Collections.Generic;

namespace HuyenCake.Models;

public partial class News
{
    public int NewsId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? Image { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? NewsCategoryId { get; set; }

    public virtual NewsCategory? NewsCategory { get; set; }

    public virtual ICollection<NewsComment> NewsComments { get; set; } = new List<NewsComment>();
}
