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
        public void Singleton_Classic_Creation_Successfully()
        {
            var singleton1 = SingletonClassic.GetInstance();
            var singleton2 = SingletonClassic.GetInstance();
            singleton1.MakeSomething();
            singleton2.MakeSomething();
            Assert.IsTrue(singleton1 == singleton2);
        }

        [TestMethod]
        public void Singleton_ThreadSafe_Creation_Successfully()
        {
            var singleton1 = SingletonThreadSafe.GetInstance();
            var singleton2 = SingletonThreadSafe.GetInstance();
            singleton1.MakeSomething("Jordan");
            singleton2.MakeSomething("Kobe");
            Assert.IsTrue(singleton1 == singleton2);
        }

        [TestMethod]
        public void Singleton_ThreadSafe_Volatile_Creation_Successfully()
        {
            var singleton1 = SingletonThreadSafeVolatile.Instance;
            var singleton2 = SingletonThreadSafeVolatile.Instance;
            singleton1.MakeSomething();
            singleton2.MakeSomething();
            Assert.IsTrue(singleton1 == singleton2);
        }

        [TestMethod]
        public void Singleton_ThreadSafe_Lazy_Creation_Successfully()
        {
            var singleton1 = SingletonLazyThreadSafe.Instance;
            var singleton2 = SingletonLazyThreadSafe.Instance;
            singleton1.MakeSomething();
            singleton2.MakeSomething();
            Assert.IsTrue(singleton1 == singleton2);
        }
    }
}
