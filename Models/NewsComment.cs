using System;
using System.Collections.Generic;

namespace HuyenCake.Models;

public partial class NewsComment
{
    public int CommentId { get; set; }

    public int? NewsId { get; set; }

    public int? UserId { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual News? News { get; set; }

    public virtual User? User { get; set; }
}
