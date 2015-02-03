using System;
using System.Security.Cryptography.X509Certificates;
using IdentityServer.Settings;
using Microsoft.Owin.Hosting;
using Owin;
using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.Core.Logging;

namespace IdentityServer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LogProvider.SetCurrentLogProvider(new DiagnosticsTraceLogProvider());

            using (WebApp.Start<Startup>("https://localhost:44333"))
            {
                Console.WriteLine("Identity Server V3 running...");
                Console.ReadLine();
            }
        }
    }

    internal class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            LogProvider.SetCurrentLogProvider(new DiagnosticsTraceLogProvider());
            var factory = InMemoryFactory.Create(
                users: Users.Get(),
                clients: Clients.Get(),
                scopes: Scopes.Get());

            var options = new IdentityServerOptions
            {
                SigningCertificate = LoadCertificate(),
                Factory = factory,
            };

            app.Map("/identity", builder => builder.UseIdentityServer(options));
        }

        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2(
                string.Format(@"{0}\..\..\idsrv3test.pfx", AppDomain.CurrentDomain.BaseDirectory), "idsrv3test");
        }
    }
}