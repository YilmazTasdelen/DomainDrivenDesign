using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domain.Shared
{
    public sealed record Currency
    {
        internal static readonly Currency None = new("");
        public static Currency Usd = new("Usd");
        public static Currency TRY = new("TRY");
        private Currency(string code)
        {
            Code = code;
        }

        public string Code { get; init; }

        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(p => p.Code == code) ??
                    throw new ArgumentException("Enter a valid currency type");
        }

        public static readonly IReadOnlyCollection<Currency> All = new[] { Usd, TRY };
    }
}
