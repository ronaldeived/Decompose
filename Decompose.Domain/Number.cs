using System.Collections.Generic;

namespace Decompose.Domain
{
    public class Number
    {
        public int Value { get; set; }
        public List<int> Dividers { get; set; }
        public List<int> Primes { get; set; }
    }
}
