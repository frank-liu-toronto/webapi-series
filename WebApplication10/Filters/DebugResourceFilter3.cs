using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Filters
{
    public class DebugResourceFilter3 : Attribute, IResourceFilter, IOrderedFilter
    {
        public int Order => -1;

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"[Resource filter 3:] {context.ActionDescriptor.DisplayName} is executing...");
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"[Resource filter 3:] {context.ActionDescriptor.DisplayName} is executed");
        }
    }
}
