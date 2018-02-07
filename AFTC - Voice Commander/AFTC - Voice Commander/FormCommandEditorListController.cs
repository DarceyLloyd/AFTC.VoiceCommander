using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFTC___Voice_Commander
{
    public class FormCommandEditorListController
    {


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        public FormCommandEditor fce;
        public ListView lvCommands;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public FormCommandEditorListController(FormCommandEditor formCommandEditor, ListView listView)
        {
            // Class specific debug
            t = new T(true);
            t.log("FormCommandEditorListController()");
            
            fce = formCommandEditor;
            lvCommands = listView;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void updateCommandListView()
        {
            t.log("FormCommandEditorListController.updateCommandListView");

            lvCommands.Clear();
            lvCommands.View = View.Details;
            lvCommands.GridLines = true;
            //lvCommands.Sorting = SortOrder.Ascending;
            lvCommands.Columns.Add("No", 40, HorizontalAlignment.Left);
            lvCommands.Columns.Add("Command", 160, HorizontalAlignment.Left);

            if (fce.fceCommandManager.cvo.commandItems.Count > 14) {
                lvCommands.Columns.Add("Information", 200, HorizontalAlignment.Left);
            }
            else
            {
                lvCommands.Columns.Add("Information", 220, HorizontalAlignment.Left);
            }
            //lvCommands.HeaderStyle = ColumnHeaderStyle.None;
            //lvCommands.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);


            // fceCommandManager either holds a new CVO or a cloned CVO (any CVO work goes on there!)
            t.log("FormCommandEditorListController.updateCommandListView: commandItems.Count = " + fce.fceCommandManager.cvo.commandItems.Count);
            

            int count = 0;

            foreach (CommandItemVO civo in fce.fceCommandManager.cvo.commandItems)
            {
                count ++;

                ListViewItem listViewItem;
                String commandType = "";
                switch (civo.type)
                {
                    case "clipboard":
                        commandType = "Insert text into clipboard";

                        //t.log("FormCommandEditorListController.updateCommandListView: " + civo.type);
                        listViewItem = new ListViewItem(count.ToString());
                        listViewItem.SubItems.Add(commandType);
                        listViewItem.SubItems.Add(DTools.stringCut(civo.clipboard, 28) + "...");
                        lvCommands.Items.Add(listViewItem);

                        break;


                    case "key":
                        commandType = "Combination key";

                        //t.log("FormCommandEditorListController.updateCommandListView: " + civo.type);
                        listViewItem = new ListViewItem(count.ToString());
                        listViewItem.SubItems.Add(commandType);
                        listViewItem.SubItems.Add(civo.key);
                        lvCommands.Items.Add(listViewItem);

                        break;

                    case "run application":
                        commandType = "Run application";

                        //t.log("FormCommandEditorListController.updateCommandListView: " + civo.type);
                        listViewItem = new ListViewItem(count.ToString());
                        listViewItem.SubItems.Add(commandType);
                        listViewItem.SubItems.Add(civo.applicationPath);
                        lvCommands.Items.Add(listViewItem);

                        break;
                }

               
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        

    }
}
