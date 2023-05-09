using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class RandomNumbers
    {

        public static List<int> Generate(int count)
        {
            var rand = new Random();
            List<int> randNums = new List<int>();

            for(int i = 0; i < count; ++i)
                randNums.Add(rand.Next());

            return randNums;
        }
    }
}
