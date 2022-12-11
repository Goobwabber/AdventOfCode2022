using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Elf
    {
        public List<int> foods { get; set; } = new List<int>();

        public int Calories()
            => foods.Aggregate((a, b) => a + b);
    }
}
