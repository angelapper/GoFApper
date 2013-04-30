using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFApper.Singleton
{
    public class SingletonClass
    {
        static readonly SingletonClass staticIns = new SingletonClass();
        Int32 initialTimes = 0;

        public static SingletonClass Instance
        {
            get
            {
                return staticIns;
            }
        }

        public SingletonClass()
        {
            initialTimes++;
        }

        public Int32 InstaceCount
        {
            get
            {
                return initialTimes;
            }
        }
    }
}
