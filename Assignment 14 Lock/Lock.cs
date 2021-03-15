using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_14_Lock
{
    class Lock
    {
        protected bool status = false;

        public void OpenLock()
        {
             status = true;
        }

        public void CloseLock()
        {
            status = false;
        }

        public bool isLocked()
        {
            return status;
        }
    }
}
