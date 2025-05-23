using Domain.ValueObjects;

namespace Domain.Entities
{
    internal class Apartment
    {
        private readonly List<Payment> _payments = new List<Payment>();
        private readonly List<Guid> _tenantIds = new List<Guid>();

        public Apartment(Guid id, Guid ownerId, Address address)
        {
            Id = id;
            OwnerId = ownerId;
            Address = address;
        }

        public Guid Id { get; private set; }
        public Address Address { get; private set; }
        public Guid OwnerId { get; private set; }
        public Agreement? Agreement { get; private set; }
        public Deposit? Deposit { get; private set; }
        public IReadOnlyList<Payment> Payments => _payments;
        public IReadOnlyList<Guid> TenantIds => _tenantIds;

        public void AddAgreement(Agreement agreement) =>
            Agreement = agreement ?? throw new ArgumentNullException(nameof(agreement));

        public void AddDeposit(Deposit deposit) =>
            Deposit = deposit ?? throw new ArgumentNullException(nameof(deposit));

        public void AddPayment(Payment payment)
        {
            if (payment is null)
                throw new ArgumentNullException(nameof(payment));

            _payments.Add(payment);
        }

        public void DeleteAgreement() =>
            Agreement = null;

        public void DeletePayment(Payment payment) =>
            _payments?.Remove(payment);

        public void DeleteDeposit() =>
            Deposit = null;

        public void ChangeOwner(Guid ownerId) =>
            OwnerId = ownerId;

        public void DeleteAllTenants() =>
            _tenantIds?.Clear();

        public void DeleteTenant(Guid tenantId) =>
            _tenantIds?.Remove(tenantId);
    }
}
