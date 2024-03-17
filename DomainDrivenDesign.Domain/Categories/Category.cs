﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDrivenDesign.Domain.Products;

namespace DomainDrivenDesign.Domain.Categories
{
    public sealed class Category
    {
        public  Guid Id  { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
