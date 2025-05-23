using Domain.Enums;

namespace Domain.ValueObjects
{
    public readonly struct Money(decimal amount, Currency currency)
    {
        public decimal Amount { get; } = amount;
        public Currency Currency { get; } = currency;
    }
}