using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    public class SingletonThreadSafeVolatile
    {
        private static object _lock = new object();
        private static volatile SingletonThreadSafeVolatile _singletonThreadSafeVolatile = null;

        private SingletonThreadSafeVolatile()
        {

        }


        //public SingletonThreadSafeVolatile GetInstance()
        //{
        //    if (_singletonThreadSafeVolatile == null)
        //    {
        //        lock (_lock)
        //        {
        //            if (_singletonThreadSafeVolatile == null)
        //            {
        //                _singletonThreadSafeVolatile = new SingletonThreadSafeVolatile();
        //            }
        //        }
        //    }

        //    return _singletonThreadSafeVolatile;
        //}

        public static SingletonThreadSafeVolatile Instance
        {
            get
            {
                if (_singletonThreadSafeVolatile == null)
                {
                    lock (_lock)
                    {
                        if (_singletonThreadSafeVolatile == null)
                        {
                            _singletonThreadSafeVolatile = new SingletonThreadSafeVolatile();
                        }
                    }
                }

                return _singletonThreadSafeVolatile;
            }

        }


        public void MakeSomething()
        {
            Console.WriteLine("thread safe - singleton..");
        }

    }
}
