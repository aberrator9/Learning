using NUnit;

namespace Tests;

public class Tests
{
    Demos.QueueUsage _queueUsage = new Demos.QueueUsage();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PassingTest()
    {
        Assert.Pass();
    }

    [TestCase(new Object[] { "3" }, 1)]                     // Index OOB - Return null
    [TestCase(new Object[] { "3", 2 }, -1)]                 // "Index OOB" - Return null
    [TestCase(new Object[] { 3, "Dentist", 'y', 'n' }, 1)]  // "Dentist"
    [TestCase(new Object[] { "3", 2 }, 0)]                  // "3"

    public void QueueUsage_EnqueueDequeueAndPeekTest(Object[] objects, int returnObjectAtIndex)
    {
        var result = _queueUsage.EnqueueDequeueAndPeek(objects, returnObjectAtIndex);
        Assert.AreEqual(result, objects[returnObjectAtIndex]);
    }
}