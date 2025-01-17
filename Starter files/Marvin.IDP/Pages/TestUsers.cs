// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using System.Security.Claims;
using Duende.IdentityServer.Test;
using IdentityModel;

namespace Marvin.IDP;

public class TestUsers
{
    public static List<TestUser> Users =>
        new()
        {
            new TestUser
            {
                SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                Username = "David",
                Password = "password",

                Claims = new List<Claim>
                {
                    new("role", "FreeUser"),
                    new(JwtClaimTypes.GivenName, "David"),
                    new(JwtClaimTypes.FamilyName, "Flagg"),
                    new Claim("pais", "nl")
                }
            },
            new TestUser
            {
                SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                Username = "Emma",
                Password = "password",

                Claims = new List<Claim>
                {
                    new("role", "PayingUser"),
                    new(JwtClaimTypes.GivenName, "Emma"),
                    new(JwtClaimTypes.FamilyName, "Flagg"),
                    new Claim("pais", "be")
                }
            }
        };
}