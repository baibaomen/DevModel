﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Models;

namespace Baibaomen.DevModel.CA
{
    static class ClientsManager
    {
        public static List<Client> Get()
        {
            return new List<Client>
        {
           // no human involved
            new Client
            {
                ClientName = "Silicon-only Client",
                ClientId = "silicon",
                Enabled = true,
                AccessTokenType = AccessTokenType.Reference,

                Flow = Flows.ClientCredentials,

                ClientSecrets = new List<Secret>
                {
                    new Secret("F621F470-9731-4A25-80EF-67A6F7C5F4B8".Sha256())
                },

                AllowedScopes = new List<string>
                {
                    "api1"
                }
            }
        };
        }
    }
}
