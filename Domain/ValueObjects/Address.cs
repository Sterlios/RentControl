namespace Domain.ValueObjects
{
    public readonly struct Address(string country, string city, string region, string street, string zipCode, string building, string apartment)
    {
        public string Country { get; } = country;
        public string City { get; } = city;
        public string Region { get; } = region;
        public string Street { get; } = street;
        public string ZipCode { get; } = zipCode;
        public string Building { get; } = building;
        public string Apartment { get; } = apartment;
    }
}