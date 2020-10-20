using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Filters
{
    public class DebugActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            Console.WriteLine($"[Action Filter] {context.ActionDescriptor.DisplayName} is executing...");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);

            Console.WriteLine($"[Action Filter] {context.ActionDescriptor.DisplayName} is executed");
        }
    }
}
