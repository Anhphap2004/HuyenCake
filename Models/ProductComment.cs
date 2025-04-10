using System;
using System.Collections.Generic;

namespace HuyenCake.Models;

public partial class ProductComment
{
    public int CommentId { get; set; }

    public int? ProductId { get; set; }

    public int? UserId { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
