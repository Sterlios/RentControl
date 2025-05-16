using Domain.Enums;

namespace Domain.ValueObjects
{
    public struct Money
    {
        public decimal Amount { get; private set; }
        public Currency Currency { get; private set; }
    }
}