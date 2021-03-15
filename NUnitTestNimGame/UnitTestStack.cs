using NUnit.Framework;
using NimGame_WinForms;

namespace NUnitTestNimGame
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void takingElementsFromStack()
        {
            Stack s = new Stack(3, 4);
            Assert.IsTrue(s.canBeTaken(2));
            Assert.IsFalse(s.canBeTaken(5));
            Assert.IsTrue(s.canBeTaken(4));
            s.takeNumberOfElements(2);
            Assert.IsTrue(s.canBeTaken(2));
            Assert.IsFalse(s.canBeTaken(5));
            Assert.IsFalse(s.canBeTaken(4));
        }
    }
}