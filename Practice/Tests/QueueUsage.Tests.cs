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

    [TestCase(new Object[] { 3, "Dentist", 'y', 'n' }, 1)]          // "Dentist"
    [TestCase(new Object[] { "alight", 2 }, 0)]                     // "alight"
    [TestCase(new Object[] { 'l', 'b', 'j', "best", "prez" }, 4)]   // "prez"
    public void QueueUsage_EnqueueDequeueAndPeekTest(Object[] objects, int returnObjectAtIndex)
    {
        var result = _queueUsage.EnqueueDequeueAndPeek(objects, returnObjectAtIndex);
        Assert.AreEqual(objects[returnObjectAtIndex], result);
    }
}