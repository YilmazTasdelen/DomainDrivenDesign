namespace DomainDrivenDesign.Domain.Shared
{
    public sealed record Name
    {
        public Name(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cant be null");
            }

            if (value.Length < 3)
            {
                throw new ArgumentException("Name cant be less than 3 charecters");
            }


            Value = value;
        }

        public string Value { get; init; }


    };
}
