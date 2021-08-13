using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    public class SingletonLazyThreadSafe
    {
        private SingletonLazyThreadSafe()
        {
        }

        public static SingletonLazyThreadSafe Instance
        {
            get
            {
                return SingletonNested.singletonLazyThreadSafe;
            }
        }

        public void MakeSomething()
        {
            Console.WriteLine("thread safe lazy singleton...");
        }

        private class SingletonNested
        {
            static SingletonNested() { }
            internal static readonly SingletonLazyThreadSafe singletonLazyThreadSafe = new SingletonLazyThreadSafe();
        }


    }
}
