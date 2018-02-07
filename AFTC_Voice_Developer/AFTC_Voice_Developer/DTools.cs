using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC_Voice_Developer
{
    public class DTools
    {


        public static String boolToNumberString(Boolean b)
        {
            if (b)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }



        public static String boolToString(Boolean b)
        {
            if (b)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }



        public static String boolToYesNo(Boolean b)
        {
            if (b)
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }


    }
}
