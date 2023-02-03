using Decompose.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Decompose.Service
{
    public class VerifyNumberService
    {
        public Number Decompose(int number)
        {
            var dividersNumbers = GetDividers(number);
            var primesNumbers = GetPrimes(dividersNumbers);

            return new Number
            {
                Value = number,
                Dividers = dividersNumbers,
                Primes = primesNumbers
            };
        }

        private List<int> GetDividers(int number)
        {
            var dividers = new List<int>();

            for (var i = 1; i <= number; i++)
                if (number % i == 0)
                    dividers.Add(i);

            return dividers;
        }

        private List<int> GetPrimes(List<int> numbers)
        {
            var primes = new List<int>();

            if (!numbers.Any())
                return new List<int>();

            foreach (var item in numbers)
                if (IsPrime(item))
                    primes.Add(item);

            return primes;
        }

        private bool IsPrime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
                if (number % i == 0)
                    return false;

            if (i == number)
                return true;

            return false;
        }
    }
}
