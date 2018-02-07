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
    public partial class FormClipboard : Form
    {
        private UIForm1 ui;
        private Boolean exitToMain = false;

        public FormClipboard(UIForm1 arg)
        {
            InitializeComponent();
            ui = arg;
        }

        private void FormClipboard_Load(object sender, EventArgs e)
        {
            ui.log("FormClipboard.FormClipboard_Load()");
            this.ActiveControl = tbSpeech;


            rtClipboard.Text = "";
            lblAccepted.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ui.log("FormClipboard.btnCancel_Click()");

            exitToMain = false;
            this.Close();
        }

        private void FormClipboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            ui.log("FormClipboard.FormClipboard_FormClosing(): exitToMain = " + exitToMain.ToString());

            if (!exitToMain)
            {
                FormNewCommand f = new FormNewCommand(ui);
                f.Show();
            }
            else
            {
                ui.Show();
            }
        }

        private void FormClipboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            ui.log("FormClipboard.FormClipboard_FormClosed()");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ui.log("FormClipboard.btnSave_Click()");

            if (commandRejected) { return; }



            if (tbSpeech.Text.Length == 0)
            {
                MessageBox.Show("Please enter a speech command!");
                this.ActiveControl = tbSpeech;
                return;
            }

            //MessageBox.Show("Value = " + nudKeyDuration.Value.ToString());
            //MessageBox.Show(float.Parse(nudKeyDuration.Value.ToString()).ToString());

            CommandVO newCommand = new CommandVO();
            newCommand.method = "clipboard";
            newCommand.speech = tbSpeech.Text;
            newCommand.clipboard = rtClipboard.Text;
            //newCommand.duration = float.Parse(nudKeyDuration.Value.ToString());
            newCommand.duration = 0;
            newCommand.clipboardAutoPaste = cbAutoPaste.Checked;

            ui.grammarHandler.addCommand(newCommand);
            

            exitToMain = true;
            this.Close();

            ui.profileHandler.save();
        }


        private bool commandRejected = false;

        private void tbSpeech_TextChanged(object sender, EventArgs e)
        {
            lblAccepted.Text = "CHECKING";
            lblAccepted.ForeColor = Color.FromArgb(255, 150, 0);

            if (ui.grammarHandler.doesCommandExist(tbSpeech.Text))
            {
                commandRejected = true;
                lblAccepted.Text = "Command already exists, please enter another.";
                lblAccepted.ForeColor = Color.FromArgb(200, 0, 0);
                btnSave.Hide();
            }
            else
            {
                commandRejected = false;
                lblAccepted.Text = "Command accepted.";
                lblAccepted.ForeColor = Color.FromArgb(0, 150, 0);
                btnSave.Show();
            }

            
        }
    }
}
