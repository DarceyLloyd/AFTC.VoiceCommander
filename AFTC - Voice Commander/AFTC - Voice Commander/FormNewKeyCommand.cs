using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace AFTC___Voice_Commander
{
    public partial class FormNewKeyCommand : Form
    {
        //https://msdn.microsoft.com/en-us/library/system.windows.forms.keys.aspx
        //https://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send%28v=vs.110%29.aspx
        //https://msdn.microsoft.com/en-us/library/windows/desktop/dd375731%28v=vs.85%29.aspx
        //http://www.asciitable.com/
        //A = 65 a = 97

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormCommandEditor fce;
        private CommandItemVO commandItemVOToEdit;
        private String keyString = "";
        private String key = "";
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public FormNewKeyCommand(FormCommandEditor formCommandEditor, CommandItemVO commandItemVOToEdit = null)
        {
            InitializeComponent();

            t = new T(true);
            t.log("FormNewKeyCommand()");

            this.fce = formCommandEditor;
            this.commandItemVOToEdit = commandItemVOToEdit;

            populateKeySelectionDropDown();

            if (commandItemVOToEdit != null)
            {
                cbCtrl.Checked = commandItemVOToEdit.ctrlPressed;
                cbAlt.Checked = commandItemVOToEdit.altPressed;
                cbShift.Checked = commandItemVOToEdit.shiftPressed;
                tbKey.Text = commandItemVOToEdit.key;
            }   
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private int count = 0;
        private void addLvKeyItem(String key, String info)
        {
            count++;
            ListViewItem listViewItem = new ListViewItem(count.ToString());
            listViewItem.SubItems.Add(info);
            listViewItem.SubItems.Add(key);
            lvKeys.Items.Add(listViewItem);
        }
        private void populateKeySelectionDropDown()
        {

            lvKeys.Clear();
            lvKeys.View = View.Details;
            lvKeys.GridLines = true;
            //lvCommands.Sorting = SortOrder.Ascending;
            lvKeys.Columns.Add("No", 40, HorizontalAlignment.Left);
            lvKeys.Columns.Add("Information", (500 - 40 - 100 - 20), HorizontalAlignment.Left);
            lvKeys.Columns.Add("Key", 100, HorizontalAlignment.Left);

            count = 0;
            int i = 0;

            addLvKeyItem("NONE","No key will be pressed apart from CTRL, ALT or Shift");

            for (i = 0; i <= 9; i++)
            {
                String str = i.ToString();
                addLvKeyItem(str, "Press the " + str + " key");
            }

            for (i = 97; i <= 122; i++)
            {
                Char c = (Char)i;
                String str = c.ToString();
                addLvKeyItem(str, "Press the " + str + " key");
            }



            addLvKeyItem("`", "Press the ` key");
            addLvKeyItem("-", "Press the - key");
            addLvKeyItem("+", "Press the + key");
            addLvKeyItem("[", "Press the [ key");
            addLvKeyItem("]", "Press the ] key");
            addLvKeyItem(";", "Press the ; key");
            addLvKeyItem("'", "Press the ' key");
            addLvKeyItem("#", "Press the # key");
            addLvKeyItem(",", "Press the , key");
            addLvKeyItem(".", "Press the . key");
            addLvKeyItem("/", "Press the / key");
            addLvKeyItem("\\", "Press the \\ key");

            addLvKeyItem(" ", "Press the SPACE key");

            addLvKeyItem("{LEFT}", "Press the ARROW LEFT key");
            addLvKeyItem("{RIGHT}", "Press the ARROW RIGHT key");
            addLvKeyItem("{UP}", "Press the ARROW UP key");
            addLvKeyItem("{DOWN}", "Press the ARROW DOWN key");

            addLvKeyItem("{BACKSPACE}", "Press the BACKSPACE key");
            addLvKeyItem("{BREAK}", "Press the BREAK key");
            addLvKeyItem("{CAPSLOCK}", "Press the CAPS LOCK key");
            addLvKeyItem("{DELETE}", "Press the DELETE key");
            addLvKeyItem("{DEL}", "Press the DEL key");
            addLvKeyItem("{END}", "Press the END key");
            addLvKeyItem("{ENTER}", "Press the ENTER key");
            addLvKeyItem("{ESC}", "Press the ESC key");
            addLvKeyItem("{HELP}", "Press the HELP key");
            addLvKeyItem("{HOME}", "Press the HOME key");
            addLvKeyItem("{INSERT}", "Press the INSERT key");
            addLvKeyItem("{NUMLOCK}", "Press the NUMLOCK key");
            addLvKeyItem("{PGDN}", "Press the PGDN key");
            addLvKeyItem("{PGUP}", "Press the PGUP key");
            addLvKeyItem("{PRTSC}", "Press the PRTSC key");
            addLvKeyItem("{SCROLLLOCK}", "Press the SCROLLLOCK key");
            addLvKeyItem("{TAB}", "Press the TAB key");
            addLvKeyItem("{F1}", "Press the F1 key");
            addLvKeyItem("{F2}", "Press the F2 key");
            addLvKeyItem("{F3}", "Press the F3 key");
            addLvKeyItem("{F4}", "Press the F4 key");
            addLvKeyItem("{F5}", "Press the F5 key");
            addLvKeyItem("{F6}", "Press the F6 key");
            addLvKeyItem("{F7}", "Press the F7 key");
            addLvKeyItem("{F8}", "Press the F8 key");
            addLvKeyItem("{F9}", "Press the F9 key");
            addLvKeyItem("{F10}", "Press the F10 key");
            addLvKeyItem("{F11}", "Press the F11 key");
            addLvKeyItem("{F12}", "Press the F12 key");
            addLvKeyItem("{F13}", "Press the F13 key");
            addLvKeyItem("{F14}", "Press the F14 key");
            addLvKeyItem("{F15}", "Press the F15 key");
            addLvKeyItem("{F16}", "Press the F16 key");
            addLvKeyItem("{ADD}", "Press the Keypad add key");
            addLvKeyItem("{SUBTRACT}", "Press the Keypad subtract key");
            addLvKeyItem("{MULTIPLY}", "Press the Keypad multiply key");
            addLvKeyItem("{DIVIDE}", "Press the Keypad divide key");
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormNewKeyCommand_Load(object sender, EventArgs e)
        {
            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormNewKeyCommand_FormClosing(object sender, FormClosingEventArgs e)
        {
            fce.Show();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnCancel_Click(object sender, EventArgs e)
        {
            fce.Show();
            this.Close();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnGetKeyFromAsciiCode_Click(object sender, EventArgs e)
        {
            /*
            int ascii = Convert.ToInt16(tbAsciiCode.Text);
            Char ch = (Char)ascii;
            tbAsciiCodeResult.Text = ch.ToString();
             */
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -





        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void generateKeyString()
        {
            if (lvKeys.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a key first!");
                return;
            }

            string value = lvKeys.SelectedItems[0].SubItems[1].ToString();

            KeyStringBuilder ksb = new KeyStringBuilder();
            keyString = ksb.getKeyString(cbCtrl.Checked, cbAlt.Checked, cbShift.Checked,value);
            key = value;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        private void cbKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void cbShift_CheckStateChanged(object sender, EventArgs e)
        {
            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void cbCtrl_CheckStateChanged(object sender, EventArgs e)
        {
            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void cbAlt_CheckStateChanged(object sender, EventArgs e)
        {
            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnSave_Click(object sender, EventArgs e)
        {
            //ListViewItem lv = lvKeys.SelectedItems[0].SubItems;
            //MessageBox.Show(lv.SubItems[0].ToString());
            //MessageBox.Show(lvKeys.SelectedItems[0].SubItems[1].ToString());
            //return;

            if (tbKey.Text == "")
            {
                MessageBox.Show("Please select a key to press, select NONE if you just want to press CTRL, ALT or SHIFT.");
                return;
            }


            CommandItemVO civo = new CommandItemVO();
            civo.type = "key";
            civo.key = tbKey.Text; 
            civo.ctrlPressed = cbCtrl.Checked;
            civo.altPressed = cbAlt.Checked;
            civo.shiftPressed = cbShift.Checked;

            fce.fceCommandManager.addCommandItem(civo);

            btnCancel_Click(null, null);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void lvKeys_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvKeys.SelectedItems.Count < 1)
            {
                return;
            }

            //MessageBox.Show(lvKeys.SelectedItems[0].SubItems[2].Text.ToString());
            tbKey.Text = lvKeys.SelectedItems[0].SubItems[2].Text.ToString();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

        

       

        

        

        
    }
}
