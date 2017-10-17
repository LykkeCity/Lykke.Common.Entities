namespace Lykke.Contracts.Slack
{
    public class SlackIntegrationSettings
    {
        public string Env { get; set; }
        public Channel[] Channels { get; set; }
    }
}