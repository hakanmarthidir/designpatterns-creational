using System;
using abstract_factory_pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using singleton_pattern;

namespace tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void Singleton_Creation_Successfully()
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            singleton1.MakeSomething();
            singleton2.MakeSomething();
            Assert.IsTrue(singleton1 == singleton2);
        }
    }
}
