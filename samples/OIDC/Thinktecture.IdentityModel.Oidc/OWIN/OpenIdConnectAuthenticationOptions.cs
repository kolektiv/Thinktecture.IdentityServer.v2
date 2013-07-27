﻿using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IdentityModel.Oidc.OWIN
{
    class OpenIdConnectAuthenticationOptions : AuthenticationOptions
    {
        public OpenIdConnectAuthenticationOptions() : base("OpenIdConnect")
        { }
    }
}