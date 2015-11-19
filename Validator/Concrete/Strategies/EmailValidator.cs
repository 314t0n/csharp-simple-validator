using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator.Abstract;

namespace Validator.Concrete.Strategies
{
    public class EmailValidator : IValidatorStrategy
    {
        private readonly string _email;

        public EmailValidator(string email)
        {
            _email = email;
        }

        public bool Validate()
        {
           return _email.Contains('@'); // loljk
        }
    }
}
