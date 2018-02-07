using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC_Voice_Developer
{
    public class ProfileVO
    {

        private String _displayName;
        public String displayName
        {
            set { _displayName = value; }
            get { return _displayName; }
        }


        private String _fileName;
        public String fileName
        {
            set { _fileName = value; }
            get { return fileName; }
        }

    }
}
