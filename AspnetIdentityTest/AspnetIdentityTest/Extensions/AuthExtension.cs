using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Extensions
{
    public static class AuthExtension
    {
        public static bool IsCorporate(this ClaimsPrincipal principal)
        {
            var cla = principal.Claims.Where(x => x.Type == "corporate").FirstOrDefault();
            if (cla != null)
                return true;
            return false;
        }

        public static string GetIdentity(this ClaimsPrincipal principal)
        {
            var cla = principal.Claims.Where(x => x.Type.Contains("nameidentifier")).FirstOrDefault();
            if (cla != null)
                return cla.Value;
            return "";
        }
    }

    //
}
