using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFTC___Voice_Commander
{
    public class KeyStringBuilder
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private String startModifier = "";
        private String endModifier = "";
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public KeyStringBuilder()
        {
            t = new T(true);
            t.log("KeyStringBuilder()");
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public String getKeyString(Boolean ctrl,Boolean alt,Boolean shift,String key)
        {
            String keyString = "";

            // SHIFT = +
            // CTRL = ^
            // ALT = %

            if (key == "(" || key == ")")
            {
                key = "";
                MessageBox.Show("The key you have choosen is not allowed, please try another key...");
            }

            if (key == "{SPACE}")
            {
                key = " ";
            }

            if (key == "{BLANK}")
            {
                key = "";
            }

            if (key == "NONE")
            {
                key = "";
            }


            if (shift && ctrl && alt)
            {
                startModifier = "+^%(";
                endModifier = ")";
            }

            if (shift && !ctrl && !alt)
            {
                startModifier = "+(";
                endModifier = ")";
            }

            if (!shift && ctrl && !alt)
            {
                startModifier = "^(";
                endModifier = ")";
            }

            if (!shift && !ctrl && alt)
            {
                startModifier = "%(";
                endModifier = ")";
            }

            if (!shift && !ctrl && !alt)
            {
                startModifier = "";
                endModifier = "";
            }

            if (!shift && ctrl && alt)
            {
                startModifier = "^%(";
                endModifier = ")";
            }


            if (shift && ctrl && !alt)
            {
                startModifier = "^+(";
                endModifier = ")";
            }

            if (shift && !ctrl && alt)
            {
                startModifier = "%+(";
                endModifier = ")";
            }


            keyString = startModifier + key + endModifier;
            t.log("KeyStringBuilder.getKeyString(): keyString = " + keyString);

            return keyString;

        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

    }
}
