using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_14_Lock
{
    class ComboLock : Lock
    {
        private int comboCode = 0252;
     

        public ComboLock()
        {
        }

        public bool OpenCombo(int codeInput)
        {
            if (codeInput == comboCode)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        }

        public void ChangeCode(int newNum)
        {
            if(status == false)
            {
                comboCode = newNum;
            }
            else
            {
               status = true;
            }
        }
       
    }
}
