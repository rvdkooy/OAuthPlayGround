using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace IdentityServer.Settings
{
    internal static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "bob",
                    Password = "secret",
                    Subject = "1",
                }
            };
        }
    }
}