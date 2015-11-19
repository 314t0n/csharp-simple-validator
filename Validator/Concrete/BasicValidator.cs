using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator.Abstract;

namespace Validator.Concrete
{
    public class BasicValidator : IValidator
    {
        private List<IValidatorStrategy> validators;

        public BasicValidator()
        {
            validators = new List<IValidatorStrategy>();
        }

        public bool Validate()
        {
            return validators.Select(s=>s.Validate()).All(s=>s.Equals(true));
        }

        public void AddValidator(IValidatorStrategy validator)
        {
            validators.Add(validator);
        }
    }
}
