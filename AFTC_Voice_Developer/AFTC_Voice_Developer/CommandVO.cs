using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC_Voice_Developer
{
    public class CommandVO
    {

        /*
<command haltOnAppChange="1" duration="0.1">
    <speech>press alt</speech>
    <window></window>
    <type>Text to type out character by character</type>
    <clipboard autoPaste="1">CLIPBOARD TEXT</clipboard>
    <key ctrl="0" alt="0" shift="0"><key>
    <application>
        <path></path>
        <command_string></command_string>
    </application>
</command>
         */

        public String method = "";
        public Boolean haltOnAppChange = false;
        public float duration = 0.1f;

        public String speech = "";
        public String window = "";
        public String autoType = "";
        public String clipboard = "";
        public Boolean clipboardAutoPaste = false;
        public String multiKey = "";
        public String multiKeyCode = "";
        public Boolean multiKeyCtrl = false;
        public Boolean multiKeyAlt = false;
        public Boolean multiKeyShift = false;
        public String applicationPath = "";
        public String applicationCommandString = "";

        public XDocument getXDoc()
        {
            XDocument xDoc = new XDocument(
               new XElement("command", 
                        new XAttribute("method", this.method), 
                        new XAttribute("haltOnAppChange", DTools.boolToNumberString(this.haltOnAppChange)), 
                        new XAttribute("duration", this.duration.ToString()),
                   new XElement("speech", this.speech),
                   new XElement("window", this.window),
                   new XElement("type", this.autoType),
                   new XElement("clipboard", this.clipboard, 
                       new XAttribute("autoPaste", DTools.boolToNumberString(this.clipboardAutoPaste))
                   ),
                   new XElement("key", this.multiKey,
                       new XAttribute("ctrl", DTools.boolToNumberString(this.multiKeyCtrl)),
                       new XAttribute("alt", DTools.boolToNumberString(this.multiKeyAlt)),
                       new XAttribute("shift", DTools.boolToNumberString(this.multiKeyShift)), 
                       new XAttribute("keyCode", multiKeyCode)
                   ),
                   new XElement("application",
                       new XElement("path", applicationPath),
                       new XElement("command_string", applicationCommandString)
                   )
               )
           );

            return xDoc;
        }
    }
}
