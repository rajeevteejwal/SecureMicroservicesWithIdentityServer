using Duende.IdentityServer.Models;

namespace IdentityServer.Configuration
{
    public class Config
    {
        public Config() { }

        public static List<Client> GetClients => new List<Client>
        {
            new Client
            {
                ClientId = "clientid",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = { "moviesAPI" }
            },
            new Client
            {
                ClientId = "client23",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = { "moviesAPI" }
            }
        };

        public static List<ApiScope> GetApiScopes => new List<ApiScope>
        {
            new ApiScope("moviesAPI", "Movies API")
        };
    }
}
