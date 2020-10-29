using FluentValidation;
using FluentValidatorPresentation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace FluentValidatorPresentation.Validators
{
    public class PessoaValidator:AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9]")
                .WithMessage("O objeto precisa obedecer as regras de validação");


            RuleFor(x => x.Nom4)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9]")
                .WithMessage("O objeto precisa obedecer as regras de validação");


            RuleFor(x => x.Nom5)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9]")
                .WithMessage("O objeto precisa obedecer as regras de validação");


            RuleFor(x => x.Nome3)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9]")
                .WithMessage("O objeto precisa obedecer as regras de validação");

        }

    }
}
