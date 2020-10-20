using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Filters
{
    public class DebugResourceFilter : Attribute, IResourceFilter, IOrderedFilter
    {
        public int Order => 3;

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"[Resource filter 1:] {context.ActionDescriptor.DisplayName} is executing...");
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"[Resource filter 1:] {context.ActionDescriptor.DisplayName} is executed");
        }        
    }
}
