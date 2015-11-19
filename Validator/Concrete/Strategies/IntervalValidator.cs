using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator.Abstract;

namespace Validator.Concrete.Strategies
{
    public class IntervalValidator : IValidatorStrategy
    {
        private readonly string _actual;
        private readonly int _min;
        private readonly int _max;

        public IntervalValidator(string actual, int min, int max)
        {
            _max = max;
            _min = min;
            _actual = actual;
        }

        public bool Validate()
        {
            try
            {
                int val = Convert.ToInt32(_actual);
                return _min < val && val < _max;
            }
            catch (Exception)
            {
                return  false;
            }
        }
    }
}
