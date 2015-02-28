using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Security.Claims;
using System.Threading.Tasks;
using Owin.Security.Providers.LinkedIn;

namespace Pilot1.Utils
{
    public class CustomLinkedinAuthenticationProvider : LinkedInAuthenticationProvider
    {
        public const string MyTokenClaimName = "LinkedinToken";

        public override Task Authenticated(LinkedInAuthenticatedContext context)
        {
            context.Identity.AddClaim(new Claim(MyTokenClaimName, context.AccessToken));

            return base.Authenticated(context);
        }
    }
}
