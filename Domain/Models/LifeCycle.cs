namespace Domain.Models
{
    public class LifeCycle
    {
        public LifeCycle(string phase, DateOnly implementation, DateOnly expireDate)
        {
            Phase = phase;
            Implementation = implementation;
            ExpireDate = expireDate;
        }

        public string Phase { get; set; }
        public DateOnly Implementation { get; set; }
        public DateOnly ExpireDate { get; set; }
    }
}