using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Browser_Simulator.Tests
{
    [TestClass]
    public class StringStackTests
    {
        [TestMethod]
        public void Push_Pop_Test()
        {
            StringStack stack = new StringStack();

            stack.Push("Element 1");
            Assert.AreEqual("Element 1", stack.Pop());

            stack.Push("Element 2");
            stack.Push("Element 3");
            Assert.AreEqual("Element 3", stack.Pop());
            Assert.AreEqual("Element 2", stack.Pop());
        }

        [TestMethod]
        public void Clear_Test()
        {
            StringStack stack = new StringStack();

            stack.Push("Element 1");
            stack.Push("Element 2");

            stack.Clear();

            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void IsEmpty_Test()
        {
            StringStack stack = new StringStack();

            Assert.IsTrue(stack.IsEmpty);

            stack.Push("Element 1");

            Assert.IsFalse(stack.IsEmpty);
        }

        [TestMethod]
        public void Count_Test()
        {
            StringStack stack = new StringStack();

            Assert.AreEqual(0, stack.Count);

            stack.Push("Element 1");
            stack.Push("Element 2");

            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        public void IsFull_Test()
        {
            StringStack stack = new StringStack();

            for (int i = 0; i < 10; i++)
            {
                stack.Push($"Element {i}");
            }

            Assert.IsTrue(stack.IsFull);
        }
    }
}
