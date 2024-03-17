namespace DomainDrivenDesign.Domain.Users
{
    public sealed record Email
    {
        public Email(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Email cant be null");
            }

            if (value.Length < 3)
            {
                throw new ArgumentException("Email cant be less than 3 charecters");
            }

            if (!value.Contains("@"))
            {
                throw new ArgumentException("Enter a valid email");
            }

            Value = value;
        }
        public string Value { get; init; }
    }
}
