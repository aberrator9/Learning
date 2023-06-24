using System.Collections;

/*
    Works as FIFO, so its operations, enqueue and dequeue,
    push to the tail node and pop from the head node.
    Queues function differently from a stack,
    which pushes to and pops from the tail (I think).
    Array can serve both of these purposes, so it would be
    interesting to compare Queue's performance vs array.
*/

namespace Demos;

public class QueueUsage
{
    public void Demo()
    {
        Queue QQ = new();

        QQ.Enqueue("Hello");
        QQ.Enqueue("there");
        QQ.Enqueue("fine");
        QQ.Enqueue("fellow");
        QQ.Enqueue("how are you?");
        QQ.Dequeue();
        QQ.Dequeue();

        Console.WriteLine(QQ.Peek());
        // Writes "fine"

        PrintValues(QQ);
        // Prints "    fine    fellow    how are you?"
    }

    public Object EnqueueDequeueAndPeek(Object[] objects, int returnObjectAtIndex)
    {
        if (objects.Length <= 0 || returnObjectAtIndex > objects.Length - 1)
            return null;

        Queue queue = new();
        foreach (Object o in objects)
            queue.Enqueue(o);

        for (int x = 0; x < returnObjectAtIndex; x++)
            queue.Dequeue();

        return queue.Peek();
    }

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write($"    {obj}");
        Console.WriteLine();
    }
}