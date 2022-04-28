using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CFCResourceManagement
{
    class clsSingleInstance
    {
        static Mutex mutex;
        public static bool Start(string applicationIdentifier)
        {
            bool isSingleInstance = false;
            mutex = new Mutex(true, applicationIdentifier, out isSingleInstance);
            return isSingleInstance;
        }
        public static void Stop()
        {
            mutex.ReleaseMutex();
        }
    }
}
