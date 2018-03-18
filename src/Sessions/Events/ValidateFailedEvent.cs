namespace Lykke.Contracts.Sessions.Events
{
    public class ValidationFailedEvent
    {
        public string SessionToken { get; set; }

        public RequestType RequestType { get; set; }
    }
}