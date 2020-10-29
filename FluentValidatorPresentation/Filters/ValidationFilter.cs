using FluentValidatorPresentation.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidatorPresentation.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            
            if(!context.ModelState.IsValid)
            {

                var errorModel = new ErrorModel();
                errorModel.TipoErro = "CodigoValidacao";

                var errorInModelState = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(x => x.ErrorMessage)).ToArray();

                var erroResponse = new ErrorResponse();
                foreach(var error in errorInModelState)
                {
                    foreach(var suberror in error.Value)
                    {
                        errorModel.Message += suberror;
                    }
                }

                context.Result = new BadRequestObjectResult(erroResponse);
                return;
            }

            await next();
        }
    }
}
