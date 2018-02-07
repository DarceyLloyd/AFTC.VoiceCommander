using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC_Voice_Developer
{
    public class ItemVO
    {

        private String _Name;
        public String Name
        {
            set { _Name = value; }
            get { return _Name; }
        }


        private int _id;
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public ItemVO(string name, int id) 
        {
            _Name = name; 
            _id = id;
        }


    }
}
