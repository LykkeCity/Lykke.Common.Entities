namespace Lykke.Contracts.Sessions.Events
{
    public class ValidationSuccessfulEvent
    {
        public string SessionToken { get; set; }

        public RequestType RequestType { get; set; }
    }
}