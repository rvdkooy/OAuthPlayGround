using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

namespace IdentityServer
{
    internal static class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                new Client 
                {
                    Enabled = true,
                    ClientName = "MVC Client",
                    ClientId = "mvc",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "https://localhost:44300/"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:44300/"
                    }
                },new Client 
                {
                    Enabled = true,
                    ClientName = "MVC Client 2",
                    ClientId = "mvc2",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "https://localhost:44302/"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:44302/"
                    }
                },
            };
        }
    }
}