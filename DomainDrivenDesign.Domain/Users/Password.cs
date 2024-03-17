namespace DomainDrivenDesign.Domain.Users
{
    public sealed record Password
    {
        public Password(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Password cant be null");
            }

            if (value.Length < 6)
            {
                throw new ArgumentException("Password cant be less than 6 charecters");
            }

            Value = value;
        }
        public string Value { get; init; }
    }
}
