using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFTC_Voice_Developer
{

    public partial class FormNewCommand : Form
    {
        private UIForm1 ui;
        private List<ItemVO> items;
        private Boolean showMainApplicationExit = true;

        public FormNewCommand(UIForm1 arg)
        {
            InitializeComponent();
            ui = arg;

            items = new List<ItemVO>();
            items.Add(new ItemVO("Windows clipboard", 0));
            items.Add(new ItemVO("Key press", 1));
            items.Add( new ItemVO("Automated typing",2));
            items.Add(new ItemVO("Run application", 3));
            
            cbCommandType.DataSource = items;
            cbCommandType.DisplayMember = "Name";
            cbCommandType.ValueMember = "Id";

            cbCommandTypeChangeHandler(null, null);
            cbCommandType.SelectionChangeCommitted += new System.EventHandler(cbCommandTypeChangeHandler);
        }

        private void FormNewCommand_Load(object sender, EventArgs e)
        {

        }



        private void cbCommandTypeChangeHandler(object sender, System.EventArgs e)
        {
            ui.log("cbCommandTypeChangeHandler(): cbCommandType.SelectedIndex = " + cbCommandType.SelectedIndex.ToString());
            switch(cbCommandType.SelectedIndex)
            {
                case 0:
                    rtInfo.Text = "If you wish to copy & paste text into the active application, use this.";
                    break;
                case 1:
                    rtInfo.Text = "If you would like to have a single key press injected into the active application, use this.";
                    break;
                case 2:
                    rtInfo.Text = "If you would like to have text auto typed into the active application, use this.";
                    break;
                case 3:
                    rtInfo.Text = "If you would like to run an application, use this.";
                    break;
            }
            
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            ui.log("FormNewCommand.btnSelect_click(): cbCommandType.SelectedIndex = " + cbCommandType.SelectedIndex.ToString());

            showMainApplicationExit = false;
            this.Close();

            switch (cbCommandType.SelectedIndex)
            {
                case 0:
                    FormClipboard formClipboard = new FormClipboard(ui);
                    formClipboard.Show();
                    break;
                case 1:
                    FormKey formKey = new FormKey(ui);
                    formKey.Show();
                    break;
                case 2:
                    FormAutoType formAutoType = new FormAutoType(ui);
                    formAutoType.Show();
                    break;
                case 3:
                    FormApplication formApplication = new FormApplication(ui);
                    formApplication.Show();
                    break;
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ui.log("FormNewCommand.btnCancel_Click(): showMainApplicationExit = " + showMainApplicationExit.ToString());

            showMainApplicationExit = true;
            ui.Show();
            this.Close();
            ui.startListening();
        }

        private void FormNewCommand_FormClosing(object sender, FormClosingEventArgs e)
        {
            ui.log("FormNewCommand.FormNewCommand_FormClosing(): showMainApplicationExit = " + showMainApplicationExit.ToString());

            if (showMainApplicationExit == true)
            {
                ui.Show();
                ui.startListening();
            }
        }

        private void FormNewCommand_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        
    }
}
