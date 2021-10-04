using System;
using Microsoft.Extensions.ObjectPool;

namespace objectpool_pattern
{
    //Sample 1 - with provider
    public class DefaultMicrosoftPoolProvider
    {
        private DefaultObjectPoolProvider _defaultObjectPoolProvider;
        private Microsoft.Extensions.ObjectPool.ObjectPool<DesignObject> _objectPool;
        public DefaultMicrosoftPoolProvider()
        {
            this._defaultObjectPoolProvider = new DefaultObjectPoolProvider();
            this._objectPool = _defaultObjectPoolProvider.Create(new DefaultPooledObjectPolicy<DesignObject>());
            //max retained defualt is Environment. ProcessorCount * 2
        }

        public DesignObject AcquireReusable()
        {
            return this._objectPool.Get();
        }

        public void ReleaseObject(DesignObject designObject)
        {
            this._objectPool.Return(designObject);
        }
    }

    //Sample 2 - with custom interface implementation
    //Custom Policy
    public class MyCustomPoolPolicy : IPooledObjectPolicy<DesignObject>
    {
        public DesignObject Create()
        {
            return new DesignObject() { CreatedDate = DateTime.Now.AddMinutes(30) };
        }

        public bool Return(DesignObject obj)
        {
            return true;
        }
    }
    //use custom policy
    public class MyCustomPool
    {
        private Microsoft.Extensions.ObjectPool.ObjectPool<DesignObject> _objectPool;
        public MyCustomPool()
        {
            this._objectPool = new DefaultObjectPool<DesignObject>(new MyCustomPoolPolicy(), 2);
        }

        public DesignObject AcquireReusable()
        {
            return this._objectPool.Get();
        }

        public void ReleaseObject(DesignObject designObject)
        {
            this._objectPool.Return(designObject);
        }
    }


    //Sample 3 - with pool
    public class DefaultMicrosoftPool
    {

        private DefaultObjectPool<DesignObject> _objectPool;

        public DefaultMicrosoftPool()
        {
            _objectPool = new DefaultObjectPool<DesignObject>(new DefaultPooledObjectPolicy<DesignObject>(), 2);
        }

        public DesignObject AcquireReusable()
        {
            return this._objectPool.Get();
        }

        public void ReleaseObject(DesignObject designObject)
        {
            this._objectPool.Return(designObject);
        }
    }


}
