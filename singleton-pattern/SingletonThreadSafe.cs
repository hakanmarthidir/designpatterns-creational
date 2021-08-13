using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    public class SingletonThreadSafe
    {
        //private static readonly object _lock = typeof(SingletonThreadSafe);
        private static readonly object _lock = new object();
        private static readonly object _streamlock = new object();

        private static SingletonThreadSafe _threadSafeSingleton = null;
        private static TextWriter _textWriter = null;

        private SingletonThreadSafe()
        {

        }

        public static SingletonThreadSafe GetInstance()
        {

            lock (_lock)
            {
                if (_threadSafeSingleton == null)
                {
                    _threadSafeSingleton = new SingletonThreadSafe();
                }
            }

            return _threadSafeSingleton;
        }    


        public void MakeSomething(string text)
        {
            try
            {
                lock (_streamlock)
                {
                    if (_textWriter == null)
                    {
                        _textWriter = new StreamWriter("text.txt", true);
                    }

                    _textWriter.WriteLine(text);

                    if (_textWriter != null)
                    {
                        _textWriter.Close();
                        _textWriter = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
