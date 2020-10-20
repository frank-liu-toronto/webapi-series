using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Filters
{
    public class EnsureCorrectDateRange : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            DateTime beginDate = (DateTime)context.ActionArguments["beginDate"];
            DateTime endDate = (DateTime)context.ActionArguments["endDate"];

            if (beginDate > endDate)
            {
                context.ModelState.AddModelError("beginDate", "Begin Date has be earlier than the End Date");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
