using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Agreement
    {
        public Guid Id { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }
        public Money CostPerMonth { get; private set; }
        public string Link { get; private set; }
    }
}