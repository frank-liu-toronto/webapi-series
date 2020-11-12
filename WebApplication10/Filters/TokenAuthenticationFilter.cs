using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.TokenAuthentication;

namespace WebApplication10.Filters
{
    public class TokenAuthenticationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var tokenManager = (ITokenManager)context.HttpContext.RequestServices.GetService(typeof(ITokenManager));

            var result = true;
            if (!context.HttpContext.Request.Headers.ContainsKey("Authorization"))
                result = false;

            string token = string.Empty;
            if (result)
            {
                token = context.HttpContext.Request.Headers.First(x => x.Key == "Authorization").Value;
                try
                {
                    var claimPrinciple = tokenManager.VerifyToken(token);
                }
                catch(Exception ex)
                {
                    result = false;
                    context.ModelState.AddModelError("Unauthorized", ex.ToString());
                }
                    
            }

            if (!result) context.Result = new UnauthorizedObjectResult(context.ModelState);            
        }
    }
}
