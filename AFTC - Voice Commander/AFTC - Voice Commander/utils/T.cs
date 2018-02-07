using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC___Voice_Commander
{
    public class T
    {

        public Boolean enabled = false;

        public T(Boolean enabled)
        {
            this.enabled = enabled;
        }



        public void log(String s)
        {
            if (enabled)
            {
                Console.WriteLine(s);
            }
        }


    }
}
