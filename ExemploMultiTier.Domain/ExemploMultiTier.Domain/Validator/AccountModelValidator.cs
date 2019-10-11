using ExemploMultiTier.Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Validator
{
    public class AccountModelValidator : AbstractValidator<AccountModel>
    {
        public AccountModelValidator()
        {
            RuleFor(a => a.AccountNumber).NotEmpty()
                .WithMessage("O número da conta deve ser preenchido!");

            RuleFor(a => a.AgencyNumber).NotEmpty()
                .WithMessage("O número da agência deve ser preenchido!");

            RuleFor(a => a.BankNumber).NotEmpty()
                .WithMessage("O número do banco deve ser preenchido!");
        }
    }
}
