using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Deposit
    {
        public Deposit(Guid id, Money money, string link)
        {
            Id = id;
            Money = money;
            Link = link;
        }

        public Guid Id { get; }
        public Money Money { get; }
        public string Link { get; }
    }
}