using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; private set; }
        public PaymentCategory Category { get; private set; }
        public DateTime InvoiceDate { get; private set; }
        public DateTime ExpiredDate { get; private set; }
        public Money Money { get; private set; }
        public string InvoiceLink { get; private set; }
        public PaymentStatus Status { get; private set; }
        public DateTime PaidDate { get; private set; }
        public string BillLink { get; private set; }

        public Payment(Guid id, PaymentCategory category, DateTime invoiceDate, DateTime expiredDate, Money money, string invoiceLink)
        {
            Id = id;
            Category = category;
            InvoiceDate = invoiceDate;
            ExpiredDate = expiredDate;
            Money = money;
            InvoiceLink = invoiceLink;
            Status = PaymentStatus.Unpaid;
        }

        public void MarkAsPaid(DateTime paidDate, string billLink)
        {
            if (Status == PaymentStatus.Paid)
                throw new InvalidOperationException("Payment is already paid");

            if (string.IsNullOrWhiteSpace(billLink))
                throw new ArgumentException($"'{nameof(billLink)}' cannot be null or whitespace.", nameof(billLink));

            Status = PaymentStatus.Paid;
            PaidDate = paidDate;
            BillLink = billLink;
        }

        public void MarkAsOverdue()
        {
            if (DateTime.Today > ExpiredDate && Status == PaymentStatus.Unpaid)
                Status = PaymentStatus.Overdue;
        }
    }
}
