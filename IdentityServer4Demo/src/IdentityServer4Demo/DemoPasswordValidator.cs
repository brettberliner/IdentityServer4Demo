using IdentityServer4.Models;
using IdentityServer4.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer4Demo
{
    public class DemoPasswordValidator : IResourceOwnerPasswordValidator
    {
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            if (context.UserName != context.Password)
            {
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "password not correct");
            }
            else
            {
                context.Result = new GrantValidationResult(context.UserName, "custom", new List<Claim>() { new Claim("userName", context.UserName) });
            }

            await Task.FromResult<GrantValidationResult>(context.Result);
        }
    }
}
