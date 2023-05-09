using System;
using System.Collections;

/*
    Works as FIFO, so its operations, enqueue and dequeue,
    push and pop from the head.
    Function in opposite fashion to a stack,
    which pushes to and pops from the tail.
    Array can serve both of these purposes, so it would be
    interesting to compare Queue's performance vs array.
*/

public class QueueUsage
{
    public static void Main()
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

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write($"    {obj}");
        Console.WriteLine();
    }
}