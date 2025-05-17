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
        public string InvoiceLink { get; private set; }
        public PaymentStatus Status { get; private set; }
        public DateOnly PaidDate { get; private set; }
        public string BillLink { get; private set; }

        public Payment(PaymentCategory category, DateOnly invoiceDate, DateOnly expiredDate, Money money, string invoiceLink)
        {
            Category = category;
            InvoiceDate = invoiceDate;
            ExpiredDate = expiredDate;
            Money = money;
            InvoiceLink = invoiceLink;
            Status = PaymentStatus.Unpaid;
        }

        public void SetId(Guid id) =>
            Id = id;

        public void MarkAsPaid(DateOnly paidDate, string billLink)
        {
            if (Status == PaymentStatus.Paid)
                throw new InvalidOperationException("Payment is already paid");

            Status = PaymentStatus.Paid;
            PaidDate = paidDate;
            BillLink = billLink;
        }

        public void MarkAsOverdue()
        {
            if (DateTime.Today > DateOnly.ToDateTime(ExpiredDate))
        }
    }
}
