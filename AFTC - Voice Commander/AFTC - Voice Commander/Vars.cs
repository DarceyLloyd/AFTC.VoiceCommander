using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC___Voice_Commander
{
    class Vars
    {

        public static FormMain formMain;

        public static String dictionaryPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AFTC_Voice_Commander", "DefaultDictionary.txt");
        public static String profilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AFTC_Voice_Commander", "profiles");

    }
}
