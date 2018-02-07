using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AFTC___Voice_Commander
{
    public class CommandExecutionHandler
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName, // class name 
            string lpWindowName // window name 
        );

        [DllImport("user32.dll")]
        public static extern int SendMessage(
            int hWnd, // handle to destination window 
            uint Msg, // message 
            int wParam, // first message parameter 
            int lParam // second message parameter 
        );

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(
            int hWnd // handle to window
        );

        [DllImport("user32.dll")]
        static extern IntPtr GetActiveWindow();
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormMain fm;

        public CommandHandlerOpenApplication commandHandlerOpenApplication;

        private CommandVO cvo;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public CommandExecutionHandler()
        {
            // Class specific debug
            t = new T(false);
            t.log("CommandExecutionHandler()");

            fm = Vars.formMain;
            commandHandlerOpenApplication = new CommandHandlerOpenApplication();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void processCommand(String command)
        {
            t.log("CommandExecutionHandler.processCommand("+command+")");

            cvo = fm.commandManager.getCommand(command);
            if (cvo != null)
            {
                t.log("CommandExecutionHandler.processCommand(" + command + "): Command found!");
                
                /*
                IntPtr handle = GetActiveWindow();
                SendKeys.Send("Darcey.Lloyd@gmail.com");
                 */

                t.log("CommandExecutionHandler.processCommand(): cvo.commandItems.Count = " + cvo.commandItems.Count);

                if (cvo.commandItems.Count > 0)
                {
                    startTimedCommandItemExecution();
                }
            }
            else
            {
                t.log("CommandExecutionHandler.processCommand(" + command + "): Command not found!");
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        
        
        private Timer timer;
        private int tickCount = 0;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void startTimedCommandItemExecution()
        {
            t.log("CommandExecutionHandler.startTimedCommandItemExecution()");

            timer = new Timer();
            timer.Interval = int.Parse((cvo.delayBetweenCommands * 1000).ToString());
            timer.Tick += new EventHandler(timerTickHandler);
            timer.Start();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void timerTickHandler(Object myObject,EventArgs myEventArgs)
        {
            t.log("CommandExecutionHandler.startTimedCommandItemExecution(): tickCount = " + tickCount);
            tickCount++;

            if (tickCount > cvo.commandItems.Count)
            {
                timer.Stop();
                tickCount = 0;
            }
            else
            {
                CommandItemVO civo = cvo.commandItems[(tickCount - 1)];
                t.log("CommandExecutionHandler.startTimedCommandItemExecution(): civo.type = " + civo.type);

                IntPtr handle;

                switch(civo.type)
                {
                    case "clipboard":
                        
                        Clipboard.SetText(civo.clipboard);
                        if (civo.clipboardAutoPaste)
                        {
                            handle = GetActiveWindow();
                            SendKeys.Send("^(v)");
                        }
                        
                        break;

                    case "key":
                        t.log("\t\t" + "civo.key = " + civo.key);
                        KeyStringBuilder ksb = new KeyStringBuilder();
                        String keyString = ksb.getKeyString(civo.ctrlPressed, civo.altPressed, civo.shiftPressed,civo.key);
                        
                        handle = GetActiveWindow();
                        SendKeys.Send(keyString);

                        break;

                    case "run application":
                        t.log("\t\t" + "civo.applicationPath = " + civo.applicationPath);
                        t.log("\t\t" + "civo.applicationParams = " + civo.applicationParams);
                        Process proc = Process.Start(civo.applicationPath, civo.applicationParams);
                        break;
                }
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



    }
}
