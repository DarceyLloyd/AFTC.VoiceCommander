using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AFTC___Voice_Commander
{
    public partial class FormCommandEditor : Form
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormMain fm;
        public CommandVO cvoToEdit;
        public FormCommandEditorCommandManager fceCommandManager;
        public FormCommandEditorListController fceListController;

        private FormNewClipboardCommand formNewClipboardCommand;
        private FormNewKeyCommand formNewKeyCommand;
        private FormNewApplicationCommand formNewApplicationCommand;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public FormCommandEditor(CommandVO cvoToEdit = null)
        {
            InitializeComponent();

            // Class specific debug
            t = new T(true);
            t.log("FormCommandEditor(cvoToEdit=null)");

            fm = Vars.formMain;

            this.cvoToEdit = cvoToEdit;

            // Populate winforms as we have a CVO to edit
            if (cvoToEdit != null)
            {
                this.tbSpeech.Text = cvoToEdit.speech;
                this.tbCommandDelay.Text = cvoToEdit.delayBetweenCommands.ToString();
            }


            // Populate lvCommands
            lvCommands.Clear();
            lvCommands.Items.Clear();

            lvCommands.View = View.Details;
            //lvCommands.Height = 70;
            lvCommands.GridLines = true;
            lvCommands.Sorting = SortOrder.Ascending;
            lvCommands.HeaderStyle = ColumnHeaderStyle.None;
            lvCommands.Columns.Add("Command name", lvCommands.Width);
            //lvProfiles.Columns.Add("Type", 146, HorizontalAlignment.Left);
            lvCommands.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);

            lvCommands.Items.Add("1. Insert text into clipboard");
            lvCommands.Items.Add("2. Combination key");
            lvCommands.Items.Add("3. Open application");


            // TO DO
            /*
            lvCommands.Items.Add("4. Get application focus");
            lvCommands.Items.Add("5. Delay");
            lvCommands.Items.Add("6. Clipboard to variable");
            lvCommands.Items.Add("7. Variable to clipboard");
            */


            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormCommandEditor_Load(object sender, EventArgs e)
        {
            t.log("FormCommandEditor.FormCommandEditor_Load()");

            fceCommandManager = new FormCommandEditorCommandManager(this);
            fceListController = new FormCommandEditorListController(this, this.lvCommandSequence);
            fceListController.updateCommandListView();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormCommandEditor_Shown(object sender, EventArgs e)
        {
            // DEV
            /*
            FormNewKeyCommand f = new FormNewKeyCommand(this);
            this.Hide();
            f.Show();
             */
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormCommandEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vars.formMain.Show();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void tbCommandDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers only and 1 .
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -





        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnInsertIntoClipboard_Click(object sender, EventArgs e)
        {
            t.log("FormCommandEditor.btnInsertIntoClipboard_Click()");

            if (lvCommands.SelectedItems.Count < 1){
                MessageBox.Show("Please select a command to add first!");
                return;
            }

            String selectedCommandToAdd = lvCommands.SelectedItems[0].Text;
            t.log(selectedCommandToAdd);

            switch (selectedCommandToAdd)
            {
                case "1. Insert text into clipboard":
                    formNewClipboardCommand = new FormNewClipboardCommand(this);
                    this.Hide();
                    formNewClipboardCommand.Show();
                    break;

                case "2. Combination key":
                    formNewKeyCommand = new FormNewKeyCommand(this);
                    this.Hide();
                    formNewKeyCommand.Show();
                    break;

                case "3. Open application":
                    formNewApplicationCommand = new FormNewApplicationCommand(this);
                    this.Hide();
                    formNewApplicationCommand.Show();
                    break;
            }

            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormCommandEditor_Resize(object sender, EventArgs e)
        {
            lvCommands.Height = this.Height - (lvCommands.Location.Y + 90);
            lvCommandSequence.Height = this.Height - (lvCommandSequence.Location.Y + 90);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        private Boolean checkIfCommandExists()
        {
            // Check command doesnt already exist
            foreach (CommandVO cvo in fm.commandManager.commands)
            {
                if (cvo.speech == tbSpeech.Text)
                {
                    

                    return true;
                }
            }
            return false;
        }



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnSave_Click(object sender, EventArgs e)
        {
            t.log("FormCommandEditor.btnSave_Click()");

            if (tbSpeech.Text.Length == 0)
            {
                MessageBox.Show("Please enter a speech command before saving!");
                return;
            }


            // Check if we are updating the same command or not
            if (cvoToEdit != null)
            {
                if (cvoToEdit.speech == tbSpeech.Text)
                {
                    // Same command, no check required
                }
                else
                {
                    // command has been renamed, check for duplicates
                    if (checkIfCommandExists())
                    {
                        MessageBox.Show("A command already exists using that speech, please enter a different speech command.");
                        return;
                    }
                }
            }
            else
            {
                // Command is new, check for duplicates
                if (checkIfCommandExists())
                {
                    MessageBox.Show("A command already exists using that speech, please enter a different speech command.");
                    return;
                }
            }


            


            CommandVO newCommandVO = fceCommandManager.cvo;
            t.log("FormCommandEditor.btnSave_Click(): newCommandVO.commandItems.Count = " + newCommandVO.commandItems.Count);

            newCommandVO.speech = tbSpeech.Text;
            newCommandVO.delayBetweenCommands = float.Parse(tbCommandDelay.Text);

            if (cvoToEdit == null)
            {
                // New command mode
                fm.commandManager.addCommand(newCommandVO);
            }
            else
            {
                // Edit command mode (delete selected in update and then add new)
                fm.commandManager.updateCommand(newCommandVO);
            }
            
            fm.grammarHandler.loadCommands();

            fm.Show();
            this.Close();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            t.log("FormCommandEditor.btnMoveUp_Click()");

            if (lvCommandSequence.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a command to move first!");
                return;
            }


            int selectedCommandIndex = lvCommandSequence.SelectedIndices[0];
            t.log("FormCommandEditor.btnMoveUp_Click(): selectedCommandIndex = " + selectedCommandIndex);

            // Prevent moving anything with index less than 0
            if (selectedCommandIndex == 0)
            {
                MessageBox.Show("You can't move the selected command any higher in the sequence as it is the first command!");
                return;
            }


        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            t.log("FormCommandEditor.btnMoveDown_Click()");

            if (lvCommandSequence.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a command to move first!");
                return;
            }

            int selectedCommandIndex = lvCommandSequence.SelectedIndices[0];
            t.log("FormCommandEditor.btnMoveDown_Click(): lvCommandSequence.Items.Count = " + lvCommandSequence.Items.Count);
            t.log("FormCommandEditor.btnMoveDown_Click(): selectedCommandIndex = " + selectedCommandIndex);
            

            // Prevent moving anything at last index to last index + 1
            if (selectedCommandIndex == (lvCommandSequence.Items.Count - 1))
            {
                MessageBox.Show("You can't move the selected command any lower in the sequence as it is the last command!");
                return;
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnDelete_Click(object sender, EventArgs e)
        {
            t.log("FormCommandEditor.btnDelete_Click()");

            if (lvCommandSequence.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a command to delete first!");
                return;
            }


            int selectedCommandIndex = lvCommandSequence.SelectedIndices[0];
            this.fceCommandManager.removeCommandAtIndex(selectedCommandIndex);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -





        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnEdit_Click(object sender, EventArgs e)
        {
            t.log("FormCommandEditor.btnEdit_Click()");

            if (lvCommandSequence.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a command to edit first!");
                return;
            }

            int commandItemIndexToEdit = lvCommandSequence.SelectedIndices[0];
            t.log("commandItemIndexToEdit = " + commandItemIndexToEdit);

            CommandItemVO civo = fceCommandManager.getCommandItem(commandItemIndexToEdit);
            t.log("civo.type = " + civo.type);

            //return;

            switch (civo.type)
            {
                case "clipboard":
                    formNewClipboardCommand = new FormNewClipboardCommand(this,civo);
                    this.Hide();
                    formNewClipboardCommand.Show();
                    break;

                case "key":
                    formNewKeyCommand = new FormNewKeyCommand(this,civo);
                    this.Hide();
                    formNewKeyCommand.Show();
                    break;

                case "run application":
                    formNewApplicationCommand = new FormNewApplicationCommand(this);
                    this.Hide();
                    formNewApplicationCommand.Show();
                    break;
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



    }
}
