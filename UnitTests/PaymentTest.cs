using Domain.Entities;
using Domain.Enums;

namespace UnitTests
{
    public class PaymentTest
    {
        [Fact]
        public void MarkAsPaid_Should_Change_Status()
        {
            var payment = new Payment(
               new Guid(),
                PaymentCategory.Rent,
                new DateTime(2025, 05, 01),
                new DateTime(2025, 05, 31),
                new Domain.ValueObjects.Money(2000, Currency.Rsd),
                "invoice_link1");

            payment.MarkAsPaid(DateTime.Now, "bill_link1");

            Assert.Equal(PaymentStatus.Paid, payment.Status);
        }

        [Fact]
        public void MarkAsOverdue_ShouldNot_Change_Status()
        {
            var payment = new Payment(
               new Guid(),
                PaymentCategory.Rent,
                new DateTime(2025, 05, 01),
                new DateTime(2025, 05, 31),
                new Domain.ValueObjects.Money(2000, Currency.Rsd),
                "invoice_link1");

            payment.MarkAsOverdue();

            Assert.NotEqual(PaymentStatus.Overdue, payment.Status);
        }

        [Fact]
        public void MarkAsOverdue_Should_Change_Status()
        {
            var payment = new Payment(
               new Guid(),
                PaymentCategory.Rent,
                new DateTime(2025, 05, 01),
                new DateTime(2025, 05, 20),
                new Domain.ValueObjects.Money(2000, Currency.Rsd),
                "invoice_link1");

            payment.MarkAsOverdue();

            Assert.Equal(PaymentStatus.Overdue, payment.Status);
        }

        [Fact]
        public void MarkAsOverdueAfterPaid_ShouldNot_Change_Status()
        {
            var payment = new Payment(
               new Guid(),
                PaymentCategory.Rent,
                new DateTime(2025, 05, 01),
                new DateTime(2025, 05, 20),
                new Domain.ValueObjects.Money(2000, Currency.Rsd),
                "invoice_link1");

            payment.MarkAsPaid(DateTime.Now, "bill_link1");
            payment.MarkAsOverdue();

            Assert.NotEqual(PaymentStatus.Overdue, payment.Status);
        }

        [Fact]
        public void MarkAsPaidAfterOverdue_Should_Change_Status()
        {
            var payment = new Payment(
               new Guid(),
                PaymentCategory.Rent,
                new DateTime(2025, 05, 01),
                new DateTime(2025, 05, 20),
                new Domain.ValueObjects.Money(2000, Currency.Rsd),
                "invoice_link1");

            payment.MarkAsOverdue();
            payment.MarkAsPaid(DateTime.Now, "bill_link1");

            Assert.Equal(PaymentStatus.Paid, payment.Status);
        }
    }
}