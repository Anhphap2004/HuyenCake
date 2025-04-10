using System;
using System.Collections.Generic;

namespace HuyenCake.Models;

public partial class ProductCategory
{
    public int ProductCategoryId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
