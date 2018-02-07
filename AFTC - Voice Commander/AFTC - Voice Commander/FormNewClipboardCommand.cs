using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFTC___Voice_Commander
{
    public partial class FormNewClipboardCommand : Form
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormCommandEditor formCommandEditor;
        private CommandItemVO commandItemVOToEdit;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public FormNewClipboardCommand(FormCommandEditor formCommandEditor, CommandItemVO commandItemVOToEdit = null)
        {
            InitializeComponent();

            // Class specific debug
            t = new T(true);
            t.log("FormNewClipboardCommand()");

            this.formCommandEditor = formCommandEditor;
            this.commandItemVOToEdit = commandItemVOToEdit;

            if (commandItemVOToEdit != null)
            {
                rtClipboard.Text = commandItemVOToEdit.clipboard;
                if (commandItemVOToEdit.clipboardAutoPaste){
                    cbAutoPaste.Checked = true;
                }
                else
                {
                    cbAutoPaste.Checked = false;
                }
                
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnCancel_Click(object sender, EventArgs e)
        {
            formCommandEditor.Show();
            this.Close();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormNewClipboardCommand_FormClosing(object sender, FormClosingEventArgs e)
        {
            formCommandEditor.Show();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormNewClipboardCommand_Resize(object sender, EventArgs e)
        {
            rtClipboard.Width = this.Width - (rtClipboard.Location.X + 30);
            rtClipboard.Height = this.Height - (rtClipboard.Location.Y + 100);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.commandItemVOToEdit == null)
            {
                // Save new civo
                CommandItemVO civo = new CommandItemVO();
                civo.type = "clipboard";
                civo.clipboard = rtClipboard.Text;
                civo.clipboardAutoPaste = cbAutoPaste.Checked;

                formCommandEditor.fceCommandManager.addCommandItem(civo);

                btnCancel_Click(null, null);
            }
            else
            {
                // Update civo (done as we are editing a reference to the variable which are the same
                commandItemVOToEdit.clipboard = rtClipboard.Text;
                commandItemVOToEdit.clipboardAutoPaste = cbAutoPaste.Checked;
                formCommandEditor.fceListController.updateCommandListView();
                btnCancel_Click(null, null);
            }

            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
    }
}
