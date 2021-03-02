using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Security.Encyption
{
   public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningHelper(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, algorithm: SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
