namespace TankYouVeryMuch.Api.Configuration;

public class ServiceConfiguration
{
    private Dictionary<string, string> Settings { get; set; }

    public ServiceConfiguration(IConfiguration configuration)
    {
        configuration.Bind(this);
    }
}