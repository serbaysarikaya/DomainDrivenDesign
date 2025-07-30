namespace DomainDrivenDesign.Domain.Shared
{
    public sealed record Currency
    {
        internal static readonly Currency None = new(""); 
        public static readonly Currency TRY = new("TRY");
        public static readonly Currency USD = new("USD");
        public string Code { get; init; }
        public Currency(string code)
        {
            Code = code;
        }

        public static Currency FromCode(string code)
        {
           return All.FirstOrDefault(c => c.Code.Equals(code, StringComparison.OrdinalIgnoreCase)) 
                  ?? throw new ArgumentException($"Currency with code '{code}' not found.");

        }
        public static readonly IReadOnlyCollection<Currency> All= new[] { TRY, USD };
    }
}
