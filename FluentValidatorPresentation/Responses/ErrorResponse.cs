using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidatorPresentation.Responses
{
    public class ErrorResponse
    {
        public string CodigoErro { get; set; } = "Eroooooooooo";
        public List<ErrorModel> erros { get; set; } = new List<ErrorModel>();

    }
}
