using System;
using System.Threading.Tasks;
using abstract_factory_pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using objectpool_pattern;
using singleton_pattern;

namespace tests
{
    [TestClass]
    public class ObjectPoolTests
    {
        [TestMethod]
        public void ObjectPool_Creation_Successfully()
        {
            var objectPool = ObjectPool<DesignObject>.Instance;

            var instance = objectPool.AcquireReusable();
            Console.WriteLine(instance.CreatedDate);

            var instance2 = objectPool.AcquireReusable();
            Console.WriteLine(instance2.CreatedDate);

            var instance3 = objectPool.AcquireReusable();
            Console.WriteLine(instance3.CreatedDate);

            Assert.IsTrue(instance != null);

        }

        [TestMethod]
        public async Task ObjectPool_Async_Successfully()
        {
            await Task.Run(() =>
            {
                ObjectPool<DesignObject> objPool = ObjectPool<DesignObject>.Instance;

                var instance = objPool.AcquireReusable();
                objPool.ReleaseObject(instance);
                Console.WriteLine(instance.CreatedDate);
                Assert.IsTrue(instance != null);
            });


            await Task.Run(() =>
            {
                ObjectPool<DesignObject> objPool = ObjectPool<DesignObject>.Instance;

                var instance = objPool.AcquireReusable();
                objPool.ReleaseObject(instance);
                Console.WriteLine(instance.CreatedDate);
                Assert.IsTrue(instance != null);
            });


        }

        [TestMethod]
        public void ObjectPoolBag_Creation_Successfully()
        {
            var objectPool = new ObjectPoolBag<DesignObject>();

            var instance = objectPool.AcquireReusable();
            Console.WriteLine(instance.CreatedDate);

            var instance2 = objectPool.AcquireReusable();
            Console.WriteLine(instance2.CreatedDate);

            var instance3 = objectPool.AcquireReusable();
            Console.WriteLine(instance3.CreatedDate);

            Assert.IsTrue(instance != null);

        }

        [TestMethod]
        public async Task ObjectPoolBag_Async_Successfully()
        {
            ObjectPoolBag<DesignObject> objPool = new ObjectPoolBag<DesignObject>();
            await Task.Run(() =>
            {
                var instance = objPool.AcquireReusable();
                objPool.ReleaseObject(instance);
                Console.WriteLine(instance.CreatedDate);
                Assert.IsTrue(instance != null);
            });


            await Task.Run(() =>
            {
                var instance = objPool.AcquireReusable();
                objPool.ReleaseObject(instance);
                Console.WriteLine(instance.CreatedDate);
                Assert.IsTrue(instance != null);
            });


        }

        [TestMethod]
        public void ObjectPoolMicrosoft_Creation_Successfully()
        {
            var objectPool = new DefaultMicrosoftPoolProvider();

            var instance = objectPool.AcquireReusable();
            Console.WriteLine(instance.CreatedDate);

            var instance2 = objectPool.AcquireReusable();
            Console.WriteLine(instance2.CreatedDate);

            var instance3 = objectPool.AcquireReusable();
            Console.WriteLine(instance3.CreatedDate);

            Assert.IsTrue(instance != null);

        }
    }
}
