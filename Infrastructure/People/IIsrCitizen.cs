namespace MakeWell.Infrastructure
{
    public interface IIsrCitizen : ICitizen
    {
        string Isr9DigitsId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
