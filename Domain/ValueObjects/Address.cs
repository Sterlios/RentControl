namespace Domain.ValueObjects
{
    public struct Address
    {
        public string Country { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Street { get; private set; }
        public string ZipCode { get; private set; }
        public string Building { get; private set; }
        public string Apartment { get; private set; }
    }
}