using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFTC_Voice_Developer
{
    public class CommandHandler
    {
        //https://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.aspx
        



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private UIForm1 ui;
        private CommandVO[] commands;
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public CommandHandler(UIForm1 arg)
        {
            ui = arg;
            ui.log("CommandHandler()");
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public void processCommand(String command)
        {
            //ui.log("CommandHandler.processCommand(s:" + command + ")");

            CommandVO cvo = ui.grammarHandler.getCommandVO(command);

            String commandType = "";
            if (cvo.autoType.Length > 0){
                commandType = "auto type";
            } else if (cvo.clipboard.Length > 0){
                commandType = "clipboard";
            }
            else if (cvo.multiKey.Length > 0) {
                commandType = "multi key";
            }
            else
            {
                commandType = "application";
            }

            Console.WriteLine("Command Type = " + commandType);



            switch (commandType)
            {
                case "clipboard":
                    new ProcessClipboardCommand(cvo);
                    break;
                
                /*
                case "move left":
                    SendKeys.Send("{LEFT}");
                    break;
                case "move right":
                    SendKeys.Send("{RIGHT}");
                    break;
                case "move up":
                    SendKeys.Send("{UP}");
                    break;
                case "move down":
                    SendKeys.Send("{DOWN}");
                    break;
                case "press alt":
                    SendKeys.Send("%");
                    break;
                case "press f":
                    SendKeys.Send("f");
                    break;
                */
            }
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -







    }
}
