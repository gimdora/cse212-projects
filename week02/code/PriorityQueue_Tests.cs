using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue four items: A(1), B(3), C(2), and D(5), then call Dequeue four times.
    // Expected Result: The order returned should be: D, B, C, A.
    // Defect(s) Found:
    //   1) Dequeue did not remove the item from the queue, so the same item kept returning.
    //   2) The loop checked only up to _queue.Count - 1, so the last element (D) was never considered.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);
        pq.Enqueue("D", 5);

        Assert.AreEqual("D", pq.Dequeue());
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue two items with the same highest priority: X(5), Y(5), then Z(1), then call Dequeue three times.
    // Expected Result: When priorities are equal, the item that entered first must come out first. Expected output: X, Y, Z.
    // Defect(s) Found: The comparison used >= which caused the newer high-priority item to be chosen first, violating FIFO behavior for equal priorities.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 5);
        pq.Enqueue("Y", 5);
        pq.Enqueue("Z", 1);

        Assert.AreEqual("X", pq.Dequeue());
        Assert.AreEqual("Y", pq.Dequeue());
        Assert.AreEqual("Z", pq.Dequeue());
    }

    // Add more test cases as needed below.
}