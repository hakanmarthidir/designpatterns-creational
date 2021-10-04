using System.Collections.Concurrent;
using System.Collections.Generic;

namespace objectpool_pattern
{
    public class ObjectPool<T> where T : new()
    {
        private static List<T> _available = new List<T>();
        private List<T> _inUse = new List<T>();

        private int _counter = 0;
        private int _maxcount = 2;


        //Singleton Pattern-----
        private ObjectPool() { }

        private static volatile ObjectPool<T> _instance = null;
        public static ObjectPool<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_available)
                    {
                        if (_instance == null)
                        {
                            _instance = new ObjectPool<T>();

                        }
                    }
                }
                return _instance;
            }
        }


        //ObjectPool Methods
        public T AcquireReusable()
        {
            lock (_available)
            {
                if (_available.Count != 0 && _available.Count < _maxcount)
                {
                    T poolItem = _available[0];
                    _inUse.Add(poolItem);
                    _available.RemoveAt(0);
                    _counter--;
                    return poolItem;
                }
                else
                {
                    T newPoolItem = new T();
                    _inUse.Add(newPoolItem);
                    return newPoolItem;
                }
            }
        }

        public void ReleaseObject(T releaseItem)
        {
            lock (_available)
            {
                if (_counter < _maxcount)
                {
                    _available.Add(releaseItem);
                    _counter++;
                    _inUse.Remove(releaseItem);
                }
            }
        }
    }
}
