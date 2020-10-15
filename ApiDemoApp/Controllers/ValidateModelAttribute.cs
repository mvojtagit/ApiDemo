using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace ApiDemoApp.Controllers
{
    public class ValidateModelAttribute :ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
