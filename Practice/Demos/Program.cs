using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos;

public class Program
{
    static void Main()
    {
        // Random numbers
        Console.WriteLine(RandomNumbers.Generate(12));

        QueueUsage _queueUsage = new QueueUsage();
        _queueUsage.Demo();
        // _queueUsage.EnqueueDequeueAndPeek(new Object[] { "3", 2 }, 0);
    }
}
