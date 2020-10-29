using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidatorPresentation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidatorPresentation.Controllers
{
   
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        [Route("Validacao/Fluent")]
        public IActionResult testaFluentApi([FromBody]Pessoa pessoa)
        {

            return Ok();
        }
    }
}