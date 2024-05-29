using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public class SingletonLogger
    {
        private static SingletonLogger _instance;
        private static readonly object _lock = new object();
        public List<string> LogMessages = new List<string>();
        public SingletonLogger()
        {
            LogMessages = new List<string>();
        }
        public static SingletonLogger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonLogger();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            LogMessages.Add(message);
            Console.WriteLine($"Log entry: {message}");
        }

    }
}
