using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Agreement
    {
        public Agreement(Guid id, DateTime startDate, DateTime endDate, Money costPerMonth, string link)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            CostPerMonth = costPerMonth;
            Link = link;
        }

        public Guid Id { get; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public Money CostPerMonth { get; private set; }
        public string Link { get; private set; }
    }
}