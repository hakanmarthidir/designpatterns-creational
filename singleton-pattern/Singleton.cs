using System;

namespace singleton_pattern
{
    public class Singleton
    {

        private Singleton() { }

        private static Singleton _singleton;

        public static Singleton GetInstance()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
            return _singleton;
        }

        public void MakeSomething()
        {
            Console.WriteLine("helloo singleton");
        }
    }
}
