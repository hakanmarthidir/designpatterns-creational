using System.Collections.Concurrent;

namespace objectpool_pattern
{
    public class ObjectPoolBag<T> where T : new()
    {
        private readonly ConcurrentBag<T> _poolItems = new ConcurrentBag<T>();
        private int _counter = 0;
        private int _maxcount = 2;

        public T AcquireReusable()
        {
            T poolItem;

            if (_poolItems.TryTake(out poolItem))
            {

                _counter--;
                return poolItem;
            }
            else
            {
                T item = new T();
                _poolItems.Add(item);
                _counter++;
                return item;
            }

        }

        public void ReleaseObject(T releaseItem)
        {
            if (this._counter < _maxcount)
            {
                _poolItems.Add(releaseItem);
                _counter++;
            }
        }
    }
}
