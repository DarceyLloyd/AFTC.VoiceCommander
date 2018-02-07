using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AFTC___Voice_Commander
{
    public static class DTools
    {

        /*
        public static Boolean logEnabled = true;
        public static void log(String s)
        {
            if (logEnabled)
            {
                Console.WriteLine(s);
            }
        }
         */


        public static bool StringQueryLike(this string toSearch, string toFind)
        {
            return new Regex(@"\A" + new Regex(@"\.|\$|\^|\{|\[|\(|\||\)|\*|\+|\?|\\").Replace(toFind, ch => @"\" + ch).Replace('_', '.').Replace("%", ".*") + @"\z", RegexOptions.Singleline).IsMatch(toSearch);
        }
        

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


        public static Boolean intStringToBoolean(String s)
        {
            Boolean b = false;

            if (s == "1")
            {
                b = true;
            }
            else
            {
                b = false;
            }

            return b;
        }



        public static String stringCut(this string str, int maxLength)
        {
            return str.Substring(0, Math.Min(str.Length, maxLength));
        }


    }
}
