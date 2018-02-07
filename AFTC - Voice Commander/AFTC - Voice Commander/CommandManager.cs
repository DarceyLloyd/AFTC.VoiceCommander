using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFTC___Voice_Commander
{
    public class CommandManager
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormMain fm;
        public List<CommandVO> commands;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public CommandManager()
        {
            // Class specific debug
            t = new T(true);
            t.log("CommandManager()");

            fm = Vars.formMain;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void getCommandsFromLoadedProfile()
        {
            t.log("CommandManager.getCommandsFromLoadedProfile()");

            fm.setStatus("Parsing profile commands...");

            commands = new List<CommandVO>();
            
            XmlNodeList xmlCommandsList = fm.profileManager.xmlDoc.SelectNodes("//command");
            //t.log("\t" + "xmlCommandsList.Count = " + xmlCommandsList.Count);
            //t.log("\t" + "xmlCommandsList.GetType = " + xmlCommandsList.GetType());
            

            t.log("------------------------------------------------------------");
            foreach (XmlNode commandRootNode in xmlCommandsList)
            {
                //t.log("\t" + commandRootNode.ChildNodes[0].InnerText.ToString());

                // Parse the outer VO (ID = String speech)
                CommandVO cvo = new CommandVO();
                cvo.speech = commandRootNode.ChildNodes[0].InnerText.ToString();

                // Parse the inner VO (list)
                XmlNodeList xmlCommandItems = commandRootNode.SelectNodes("command_sequence/item");
                //t.log("\t\t" + "CommandItem: " + xmlCommandItems.ToString());

                t.log("\n");
                t.log("\t\t" + "command = " + cvo.speech);


                //Console.WriteLine("###### " + commandRootNode.ChildNodes[1].OuterXml.ToString());
                foreach (XmlNode commandItemNode in xmlCommandItems)
                {
                    //t.log("\t\t" + "CommandItem: " + commandItemNode.OuterXml.ToString());
                    //t.log("\t\t\t" + "XML = " + commandItemNode.OuterXml.ToString());

                    String commandItemType = commandItemNode.Attributes[0].Value.ToString();
                    
                    CommandItemVO civo = new CommandItemVO();
                    civo.type = commandItemType;
                    

                    int index = -1;
                    
                    t.log("\t\t" + "commandItemType = " + commandItemType);
                    switch (commandItemType)
                    {
                        case "run application":
                            t.log("\t\t\t" + commandItemNode.ChildNodes[0].InnerXml.ToString());
                            civo.applicationPath = commandItemNode.ChildNodes[0].InnerXml.ToString();

                            t.log("\t\t\t" + commandItemNode.ChildNodes[1].InnerXml.ToString());
                            civo.applicationParams = commandItemNode.ChildNodes[1].InnerXml.ToString();
                            break;

                        case "clipboard":
                            t.log("\t\t\t" + "commandItemNode.InnerText = " + commandItemNode.InnerText.ToString());
                            t.log("\t\t\t" + "commandItemNode.Attributes[1].Value = " + commandItemNode.Attributes[1].Value.ToString());
                            
                            civo.clipboard = commandItemNode.InnerText.ToString();
                            civo.clipboardAutoPaste = DTools.intStringToBoolean(commandItemNode.Attributes[1].Value.ToString());

                            
                            break;

                        case "clipboard to var":
                            index = int.Parse(commandItemNode.Attributes[1].Value.ToString());
                            civo.appVarIndex = index;
                            civo.appVars[index] = Clipboard.GetText();
                            //t.log("\t\t\t" + "index = " + index.ToString());
                            //t.log("\t\t\t" + "civo.appVars[index] = " + civo.appVars[index].ToString());
                            break;

                        case "var to clipboard":
                            //index = int.Parse(commandItemNode.Attributes[1].Value.ToString());
                            //Clipboard.SetText(civo.appVars[index]);
                            break;

                        case "output var":
                            //index = int.Parse(commandItemNode.Attributes[1].Value.ToString());
                            break;

                        case "key":
                            civo.key = commandItemNode.ChildNodes[0].InnerText.ToString();
                            civo.ctrlPressed = DTools.intStringToBoolean(commandItemNode.Attributes[1].Value.ToString());
                            civo.altPressed = DTools.intStringToBoolean(commandItemNode.Attributes[2].Value.ToString());
                            civo.shiftPressed = DTools.intStringToBoolean(commandItemNode.Attributes[3].Value.ToString());
                            break;

                        case "focus on application":
                            break;

                        case "delay":
                            t.log("\t\t\t" + "commandItemNode.Attributes[1].Value = " + commandItemNode.Attributes[1].Value.ToString());
                            civo.delayTime = float.Parse(commandItemNode.Attributes[1].Value);
                            break;
                    }


                    cvo.addCommandItem(civo);
                } // commandItemNode for loop end

                
                //t.log("\t----------------------------------");

                commands.Add(cvo);

            } // rootCommandNode for loop end
            t.log("------------------------------------------------------------");

            //Console.WriteLine(commands.ToString());

            fm.setStatus("Profile commands parsed...");

            fm.fmCommandListController.updateCommandListView();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void addCommand(CommandVO cvo)
        {
            t.log("CommandManager.addCommand(cvo)");

            commands.Add(cvo);

            fm.fmCommandListController.updateCommandListView();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void updateCommand(CommandVO newCommand)
        {
            t.log("CommandManager.updateCommand(newCommand)");

            String selectedItemSpeechCommand = fm.fmCommandListController.getSelectedItemSpeechCommand();
            CommandVO cvoToRemove = this.getCommand(selectedItemSpeechCommand);
            commands.Remove(cvoToRemove);
            cvoToRemove = null;
            commands.Add(newCommand);
            
            fm.fmCommandListController.updateCommandListView();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void deleteCommand()
        {
            t.log("CommandManager.deleteCommand()");

            String selectedItemSpeechCommand = fm.fmCommandListController.getSelectedItemSpeechCommand();
            CommandVO cvoToRemove = this.getCommand(selectedItemSpeechCommand);
            commands.Remove(cvoToRemove);
            cvoToRemove = null;

            fm.fmCommandListController.updateCommandListView();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public bool doesCommandExist(string speech)
        {
            Boolean exists = false;
            foreach (CommandVO cvo in commands)
            {
                if (cvo.speech == speech)
                {
                    exists = true;
                }
            }
            return exists;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public CommandVO getCommand(String speech)
        {
            CommandVO cvo = null;

            foreach (CommandVO c in commands)
            {
                if (c.speech == speech)
                {
                    cvo = c;
                }
            }

            return cvo;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -








    }
}
