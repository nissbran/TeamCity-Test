using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldUnitTest
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void TestGetHello()
        {
            var helloWorldString = HelloWorldTest.Program.GetHelloWorld();

            Assert.AreEqual("Hello World!", helloWorldString);
        }

        [TestMethod]
        public void TestTrue()
        {
            Assert.AreEqual(true, true);
        }
    }
}
