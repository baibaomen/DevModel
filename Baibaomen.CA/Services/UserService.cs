﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServer3.Core.Services.InMemory;
using IdentityServer3.Core;
using System.Security.Claims;

namespace Baibaomen.CA
{

    static class UserService
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
                Claims = new[]
                {
                    new Claim(Constants.ClaimTypes.GivenName, "Bob"),
                    new Claim(Constants.ClaimTypes.FamilyName, "Smith")
                }
            },
            new InMemoryUser
            {
                Username = "alice",
                Password = "secret",
                Subject = "2"
            }
        };
        }
    }
}