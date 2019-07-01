using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace malkeet_russian
{
    class Russian
    {
        public int Spinner;
        public int Shootawaychance = 2;
        public int Firedshots = 6;
        public int loadbulleteshift(int load)//puts the bullete to first pos when its in the sixsth
        {
            if (load == 6)
            {
                load = 1;
            }
            else
            {
                load++;
            }
            return load;
        }
        
    }
}
