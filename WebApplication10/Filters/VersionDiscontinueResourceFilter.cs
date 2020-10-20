using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Filters
{
    public class VersionDiscontinueResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {            
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (context.HttpContext.Request.Path.Value.ToLower().Contains("v1"))
            {
                context.Result = new BadRequestObjectResult(new
                {
                    Success = false,
                    Errors = new[] { "This version of the API is discontinued, please use V2" }
                });
            }
        }
    }
}
