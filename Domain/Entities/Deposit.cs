using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Deposit
    {
        public int Guid { get; private set; }
        public Money Money { get; private set; }
        public string Link { get; private set; }
    }
}