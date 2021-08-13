using System;

namespace singleton_pattern
{
    public class SingletonClassic
    {
        private SingletonClassic() { }

        private static SingletonClassic _singleton;

        public static SingletonClassic GetInstance()
        {
            if (_singleton == null)
            {
                _singleton = new SingletonClassic();
            }
            return _singleton;
        }

        public void MakeSomething()
        {
            Console.WriteLine("helloo singleton classic, i am not thread safe");
        }
    }
}
