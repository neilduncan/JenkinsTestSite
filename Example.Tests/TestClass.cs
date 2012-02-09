using JenkinsTestSite.Controllers;
using NUnit.Framework;

namespace Example.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestController_MethodToTest()
        {
            var controller = new TestController();

            var i = controller.MethodToTest();

            Assert.AreEqual(1, i);
        }
    }
}
