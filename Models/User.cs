using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMigrations.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Nome).NotEmpty().WithMessage("Informe um nome!").Length(1, 60);
        }
    }
}
