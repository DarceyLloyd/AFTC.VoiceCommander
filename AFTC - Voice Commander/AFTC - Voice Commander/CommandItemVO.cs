using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC___Voice_Commander
{
    public class CommandItemVO
    {

        /*
        <?xml version="1.0" encoding="utf-8" ?>
        <xml>

          <command>
            <speech>Test 1</speech>
            <command_sequence>
              <item type="run application">
                <path></path>
                <params></params>
              </item>
              <item type="clipboard" autoPaste="0"></item>
              <item type="clipboard to var" var="0"/>
              <item type="var to clipboard" var="0"/>
              <item type="output var" var="0"/>
              <item type="key" ctrl="0" alt="0" shift="0" useKeyCode="0" keyCode="" duration="0.1"></item>
              <item type="auto type" duration="0.1"></item>
              <item type="focus on application" delayBeforeFocus="0" stopIfNotFound="1"></item>
            </command_sequence>
          </command>

        </xml>
        */

        public string type = "";        

        public string applicationPath = "";
        public string applicationParams = "";

        public string clipboard = "";
        public bool clipboardAutoPaste = false;

        public string[] appVars = new String[9]; // 10
        public int appVarIndex = 0;
        public bool varToClipboardAutoPaste = false;

        public string key = "";
        public bool ctrlPressed = false;
        public bool altPressed = false;
        public bool shiftPressed = false;

        public string focus = "";
        public float delayBeforeFocus = 0.1f;
        public bool stopIfFocusNotFound = true;


        public float delayTime = 0.0f;
    }
}
