using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer4Demo
{
    public static class Configuration
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            ApiResource resource = new ApiResource("api1", "My API");
            resource.ApiSecrets.Add(new Secret("secret".Sha256()));
            return new List<ApiResource> { resource };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedScopes = { "api1" }
                }
            };
        }

        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>
            {
               new TestUser { Password = "testpass", Username = "testuser", SubjectId = "testsubject" }
            };
        }
    }
}