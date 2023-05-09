using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class RandomNumbers
    {
        public static int[] Generate(int count)
        {
            var rand = new Random();
            int[] randNums = new int[count];

            for (int i = 0; i < count; ++i)
                randNums[i] = rand.Next();

            return randNums;
        }
    }
}
