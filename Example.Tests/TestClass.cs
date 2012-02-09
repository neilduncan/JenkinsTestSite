using NUnit.Framework;

namespace Example.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Passing_Test()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Failing_Test()
        {
#if DEBUG
            Assert.IsTrue(false);
#endif
        }
    }
}
