using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator.Abstract;

namespace Validator.Concrete.Strategies
{
    public class PasswordValidator : IValidatorStrategy
    {
        private readonly string _password;
        private readonly string _match;

        public PasswordValidator(string password, string match)
        {
            _match = match;
            _password = password;
        }

        public bool Validate()
        {
            return !String.IsNullOrEmpty(_password) && !String.IsNullOrEmpty(_match) && _password.Equals((_match));
        }
    }
}
