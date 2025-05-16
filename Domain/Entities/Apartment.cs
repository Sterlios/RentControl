using Domain.ValueObjects;

namespace Domain.Entities
{
    internal class Apartment
    {
        public Guid Id { get; private set; }
        public Address Address { get; private set; }
        public Person Owner { get; private set; }
        public Agreement Agreement { get; private set; }
        public Deposit Deposit { get; private set; }
        public List<Payment> Payments { get; private set; }
    }
}
