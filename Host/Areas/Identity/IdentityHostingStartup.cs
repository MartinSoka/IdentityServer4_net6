using IdentityServer4.Host.Areas.Identity;

[assembly: HostingStartup(typeof(IdentityHostingStartup))]
namespace IdentityServer4.Host.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

            });
        }
    }
}