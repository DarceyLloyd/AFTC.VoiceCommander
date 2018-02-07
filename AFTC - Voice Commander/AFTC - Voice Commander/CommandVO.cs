using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC___Voice_Commander
{
    public class CommandVO
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


        // 1 voice command to command list

        public string speech = "";
        public float delayBetweenCommands = 0.2f;

        public List<CommandItemVO> commandItems;



        public CommandVO()
        {
            commandItems = new List<CommandItemVO>(10);
        }


        public void addCommandItem(CommandItemVO civo)
        {
            commandItems.Add(civo);
        }


        public void removeCommandItem(CommandItemVO civo)
        {
            commandItems.Remove(civo);
        }



        public CommandVO clone()
        {
            CommandVO copy = new CommandVO();
            copy.speech = this.speech;
            copy.delayBetweenCommands = this.delayBetweenCommands;
            
            foreach (CommandItemVO item in commandItems)
            {
                CommandItemVO itemCopy = new CommandItemVO();
                itemCopy.altPressed = item.altPressed;
                itemCopy.applicationParams = item.applicationParams;
                itemCopy.applicationPath = item.applicationPath;
                itemCopy.appVarIndex = item.appVarIndex;
                itemCopy.appVars = item.appVars;
                itemCopy.clipboard = item.clipboard;
                itemCopy.clipboardAutoPaste = item.clipboardAutoPaste;
                itemCopy.ctrlPressed = item.ctrlPressed;
                itemCopy.delayBeforeFocus = item.delayBeforeFocus;
                itemCopy.delayTime = item.delayTime;
                itemCopy.key = item.key;
                itemCopy.shiftPressed = item.shiftPressed;
                itemCopy.stopIfFocusNotFound = item.stopIfFocusNotFound;
                itemCopy.type = item.type;
                itemCopy.varToClipboardAutoPaste = item.varToClipboardAutoPaste;

                copy.commandItems.Add(itemCopy);
            }

            return copy;
        }


    }
}
