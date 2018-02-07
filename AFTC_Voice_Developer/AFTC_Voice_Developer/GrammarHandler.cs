using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace AFTC_Voice_Developer
{
    public class GrammarHandler
    {

        private UIForm1 ui;
        //private Recognizer recognizer;
        private ListView lvCommands;

        public GrammarBuilder gb;
        public Grammar g;

        public XmlNodeList xmlCommands;
        public Choices speechCommands;
        //public CommandVO[] commands;
        public List<CommandVO> commands = new List<CommandVO>();

        public GrammarHandler(UIForm1 arg)
        {
            ui = arg;
            ui.log("GrammarHandler()");
        }


        public void init()
        {
            ui.log("GrammarHandler.init()");
            //recognizer = ui.recognizer;
            lvCommands = ui.getListViewCommands();
        }

        private Boolean intStringToBoolean(String s)
        {
            Boolean b = false;

            if (s == "1")
            {
                b = true;
            }
            else
            {
                b = false;
            }

            return b;
        }



        public void clear()
        {
            ui.log("GrammarHandler.clear()");

            if (speechCommands != null)
            {
                speechCommands = null;
            }
            speechCommands = new Choices();
            //commands.Clear();

            try
            {
                ui.recognizer.sre.RecognizeAsyncStop();
            }
            catch { }
            ui.recognizer.sre.UnloadAllGrammars();
        }



        public event EventHandler grammarLoaded;

        public void loadCommands(XmlNodeList arg,String profileName)
        {
            ui.log("GrammarHandler.loadCommands(xmlNodeList)");
            xmlCommands = arg;

            if (xmlCommands.Count == 0)
            {
                //MessageBox.Show("Please add some commands")
                lvCommands.Clear();
                ui.setStatus("Profile is empty, please createa some commands!");
                return;
            }

            if (commands != null)
            {
                commands.Clear();
            }

            

            
            // Reset
            //ui.recognizer.sre.Dispose();
            clear();
            
            
            // Configure ListView
            lvCommands.Clear();
            lvCommands.View = View.Details;
            lvCommands.GridLines = true;
            lvCommands.Sorting = SortOrder.Ascending;
            lvCommands.Columns.Add("Command", 500, HorizontalAlignment.Left);
            lvCommands.Columns.Add("Type", 146, HorizontalAlignment.Left);


            int cnt = 0;


            //Console.WriteLine("##### " + xmlCommands.Count);

            ui.log("---------------");
            foreach (XmlNode node in xmlCommands)
            {
                String speech = node.ChildNodes[0].InnerText.ToString();
                if (speech != "")
                {
                    cnt++;
                    speechCommands.Add(node.ChildNodes[0].InnerText.ToString());

                    //Console.WriteLine(command.InnerXml.ToString());
                    //Console.WriteLine(node.ChildNodes[0].InnerText);
                    //ui.log(node.ChildNodes[0].InnerText.ToString());

                    CommandVO command = new CommandVO();

                    command.method = node.Attributes[0].InnerText.ToString();
                    command.haltOnAppChange = intStringToBoolean(node.Attributes[1].InnerText.ToString());
                    command.duration = float.Parse(node.Attributes[2].InnerText.ToString());

                    command.speech = node.ChildNodes[0].InnerText;
                    command.window = node.ChildNodes[1].InnerText;
                    command.autoType = node.ChildNodes[2].InnerText;
                    command.clipboard = node.ChildNodes[3].InnerText;
                    //Console.WriteLine("node.ChildNodes[3].Attributes[0].ToString() = " + node.ChildNodes[3].Attributes[0].Value.ToString());
                    command.clipboardAutoPaste = intStringToBoolean(node.ChildNodes[3].Attributes[0].Value.ToString());
                    command.multiKey = node.ChildNodes[4].InnerText;
                    command.multiKeyCtrl = intStringToBoolean(node.ChildNodes[4].Attributes[0].Value.ToString());
                    command.multiKeyAlt = intStringToBoolean(node.ChildNodes[4].Attributes[1].Value.ToString());
                    command.multiKeyShift = intStringToBoolean(node.ChildNodes[4].Attributes[2].Value.ToString());

                    ListViewItem listViewItem = new ListViewItem(command.speech);
                    listViewItem.SubItems.Add(command.method);
                    lvCommands.Items.Add(listViewItem);

                    commands.Add(command);

                    //ui.log(command.speech + ": " + "\t" + "method:" + command.method.ToString() + "\t" + "haltOnAppChange:" + command.haltOnAppChange.ToString() + "\t" + "+delay:" + command.delay.ToString());
                    ui.log("Command added: [" + command.speech + "]");
                    //ui.log("command.clipboard: [\n" + command.clipboard + "\n]");

                    //Server.UrlDecode

                }
            }
            ui.log("---------------");


            ui.stopListening();

            gb = new GrammarBuilder(speechCommands);
            g = new Grammar(gb);
            ui.recognizer.sre.LoadGrammar(g);
            ui.recognizer.sre.RecognizeAsync(RecognizeMode.Multiple);


            ui.setStatus(cnt.ToString() + " commands loaded and ready!");


            EventHandler handler = grammarLoaded;
            if (null != handler) handler(this, EventArgs.Empty);
        }



        public void addCommand(CommandVO cvo)
        {
            commands.Add(cvo);
        }



        public CommandVO getCommandVO(String speech)
        {
            CommandVO cvo = null;

            foreach (CommandVO c in commands)
            {
                if (speech == c.speech)
                {
                    cvo = c;
                }
            }

            return cvo;
        }



        public void removeCommand(String s)
        {
            // Remove from list view
            foreach (ListViewItem i in lvCommands.Items)
            {
                if (i.Text == s)
                {
                    lvCommands.Items.Remove(i);
                }
            }

            // Remove from List CVO commands
            //foreach (CommandVO cvo in commands)
            int selectedIndex = -1;
            for (int i = 0;i < commands.Count;i++)
            {
                CommandVO cvo = commands[i];
                string speech = cvo.speech;
                if (speech == s)
                {
                    selectedIndex = i;
                    //commands.Remove(cvo);
                }
            }
            if (selectedIndex > -1)
            {
                commands.RemoveAt(selectedIndex);
            }

            ui.profileHandler.save();
        }


        public bool doesCommandExist(string c)
        {
            Boolean exists = false;
            foreach (XmlNode node in xmlCommands)
            {
                String speech = node.ChildNodes[0].InnerText.ToString();
                if (speech == c)
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
