using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities
{
    internal class Payment
    {
        public Guid Id { get; private set; }
        public PaymentCategory Category { get; private set; }
        public DateOnly InvoiceDate { get; private set; }
        public DateOnly ExpiredDate { get; private set; }
        public Money Money { get; private set; }
        public PaymentStatus Status { get; private set; }
        public DateOnly PaidDate { get; private set; }
        public string Link { get; private set; }
    }
}
