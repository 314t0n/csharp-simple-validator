using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator.Abstract
{
    public interface IValidator
    {
        bool Validate();
        void AddValidator(IValidatorStrategy validator);
    }
}
