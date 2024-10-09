namespace ResourcesApiGateway.Core.Configuration
{
    public class LoadConfigurration
    {
        public static void EnableLocalDebugging(WebApplicationBuilder builder)
        {
            if (builder.Environment.IsDevelopment())
            {
                builder.WebHost.ConfigureKestrel(serverOptions =>
                {
                    serverOptions.ListenAnyIP(5079);
                    serverOptions.Listen(System.Net.IPAddress.Parse("192.168.0.100"), 5079);
                });
            }
        }
    }
}
