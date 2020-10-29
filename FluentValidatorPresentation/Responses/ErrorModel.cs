using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidatorPresentation.Responses
{
    public class ErrorModel
    {
        public string TipoErro { get; set; }
        public string FielName { get; set; }
        public string Message { get; set; }
    }
}
