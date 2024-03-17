using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Categories
{
    public sealed class Category: Entity
    {
        public Category(Guid id,Name name):base(id)
        {
            Name = name;
        }

        public  Guid Id  { get; set; }
        public Name Name { get; private set; }
        public ICollection<Product> Products { get; set; }

        public void ChangeName(string Name)
        {
            Name = Name;
        }
        
    }
}
