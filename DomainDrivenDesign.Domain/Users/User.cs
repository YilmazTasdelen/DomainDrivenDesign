using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domain.Users
{
    public sealed class User : Entity
    {
        public User(Guid id,Name name, Email email, Password password, Address address) : base(id)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public Address Address { get; private set; }

        public void ChangeName(string Name)
        {
            Name = Name;
        }

        public void ChangeAddress(string country,string city,string street,string postalCode,string fullAddress)
        {
            Address = new(country, city, street, fullAddress, postalCode);
        }

        public void ChangeEmail(string email)
        {
            Email = new(email);
        }

        public void ChangePassword(string password)
        {
            Password = new(password);
        }
    }
}
