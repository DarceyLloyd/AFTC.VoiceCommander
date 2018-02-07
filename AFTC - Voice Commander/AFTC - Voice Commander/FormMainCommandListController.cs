using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFTC___Voice_Commander
{
    public class FormMainCommandListController
    {

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormMain fm;
        private ListView lvCommands;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public FormMainCommandListController(ListView arg1)
        {
            // Class specific debug
            t = new T(false);
            t.log("FormMainCommandListController()");

            lvCommands = arg1;
            fm = Vars.formMain;
            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void updateCommandListView()
        {
            t.log("FormMainCommandListController.updateCommandListView");

            fm.setStatus("Populating command list...");


            lvCommands.Clear();
            //lvCommands.Height = 50;
            //DTools.ListViewHideHorizontalScrollBar(lvCommands);
            lvCommands.View = View.Details;
            lvCommands.GridLines = true;
            lvCommands.Sorting = SortOrder.Ascending;
            //lvCommands.Columns.Add("No", 30, HorizontalAlignment.Left);

            if (fm.commandManager.commands.Count < 20)
            {
                lvCommands.Columns.Add("Command", 270 , HorizontalAlignment.Left);
            }
            else
            {
                lvCommands.Columns.Add("Command", 270 - 20, HorizontalAlignment.Left);
            }

            
            //lvCommands.Columns.Add("Type", 146, HorizontalAlignment.Left);
            lvCommands.HeaderStyle = ColumnHeaderStyle.None;
            lvCommands.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);

            t.log("FormMainCommandListController.updateCommandListView: commands.Count = " + fm.commandManager.commands.Count);

            int c = 0;
            foreach (CommandVO cvo in fm.commandManager.commands)
            {
                t.log("FormMainCommandListController.updateCommandListView: " + cvo.speech);
                c++;
                ListViewItem listViewItem = new ListViewItem(cvo.speech);
                //ListViewItem listViewItem = new ListViewItem(c.ToString());
                //listViewItem.SubItems.Add(cvo.speech);
                lvCommands.Items.Add(listViewItem);
            }

            fm.grammarHandler.loadCommands();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public String getSelectedItemSpeechCommand()
        {
            String selectedSpeechCommand = "";

            if (lvCommands.SelectedItems.Count < 1)
            {
                selectedSpeechCommand = "";
            }
            else
            {
                selectedSpeechCommand = lvCommands.SelectedItems[0].Text;
            }

            return selectedSpeechCommand;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

    }
}
