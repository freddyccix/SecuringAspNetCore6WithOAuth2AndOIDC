using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace Marvin.IDP;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new("roles", "Your role(s)", new[] {"role"}),
            new("pais", "El país donde vives", new[] {"pais"})
        };

    public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new("api", "API Gallery", new []{"role", "pais"})
            {
                Scopes = {"api.read", "api.read", "api.full"}
            }
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new("api.full"),
            new("api.read"),
            new("api.write")
        };

    public static IEnumerable<Client> Clients =>
        new[]
        {
            new Client
            {
                ClientName = "Imagenes",
                ClientId = "img",
                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris =
                {
                    "https://localhost:7184/signin-oidc"
                },
                PostLogoutRedirectUris =
                {
                    "https://localhost:7184/signout-callback-oidc"
                },
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "roles",
                    "pais",
                    "api.read",
                    "api.write"
                },
                ClientSecrets =
                {
                    new Secret("secreto".Sha256())
                },
                RequireConsent = true
            }
        };
}