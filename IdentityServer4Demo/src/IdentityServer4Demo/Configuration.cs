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
            return new List<ApiResource>
    {
            resource  
     //   new ApiResource("api1", "My API")
    };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
    {
        new Client
        {
            ClientId = "client",

            // no interactive user, use the clientid/secret for authentication
            AllowedGrantTypes = GrantTypes.ClientCredentials,

            // secret for authentication
            ClientSecrets =
            {
                new Secret("secret".Sha256())
            },

            // scopes that client has access to
            AllowedScopes = { "api1" }
        }
    };
        }
    }
}


            //public static List<TestUser> GetTestUsers()
            //{
            //    return new List<TestUser>
            //    {
            //       new TestUser { Password = "testpass", Username = "testuser" }
            //    };
            //}
        

