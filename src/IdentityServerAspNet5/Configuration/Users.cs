﻿using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;

namespace IdentityServerAspNet5
{
    static class Users
    {
        public static List<InMemoryUser> Get()
        {
            var users = new List<InMemoryUser>
            {
                new InMemoryUser{Subject = "88421113", Username = "Damien", Password = "Damien",
                    Claims = new Claim[]
                    {
                        new Claim(Constants.ClaimTypes.Name, "Damienbod"),
                        new Claim(Constants.ClaimTypes.GivenName, "Damien"),
                        new Claim(Constants.ClaimTypes.Email, "damien_bod@hotmail.com"),
                        new Claim(Constants.ClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(Constants.ClaimTypes.Role, "Developer")
                    }
                }
            };

            return users;
        }
    }
}