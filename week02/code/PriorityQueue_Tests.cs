using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: running the code with an empty queue trying to dequeue
    // Expected Result: invalid operation is thrown
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
    }

    [TestMethod]
    // Scenario: add items to and remove them from queue
    // Expected Result: highest priority item gets remove first
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("bob", 1);
        priorityQueue.Enqueue("tim", 2);

        Assert.AreEqual("tim", priorityQueue.Dequeue());
        Assert.AreEqual("bob", priorityQueue.Dequeue());

    }

    // Add more test cases as needed below.
}