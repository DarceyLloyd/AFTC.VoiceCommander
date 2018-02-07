using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Web;

namespace AFTC_Voice_Developer
{
    public partial class UIForm1 : Form
    {
        /*
         * REF:
         * https://msdn.microsoft.com/en-us/library/office/system.speech.recognition.speechrecognizer.aspx
         * https://msdn.microsoft.com/en-us/library/office/hh361683%28v=office.14%29.aspx
         * http://www.csharp-examples.net/culture-names/
         */

        public ProfileHandler profileHandler;

        public GrammarHandler grammarHandler;
        public Recognizer recognizer;
        public WindowHandler windowHandler;
        public CommandHandler commandHandler;

        public FormManager formManager;

        /*
        public FormNewCommand formNewCommand;
        public FormClipboard formClipboard;
        public FormKey formKey;
        public FormAutoType formAutoType;
        public FormApplication formApplication;
        */
        public Boolean listening = true;

        //public globalKeyboardHook gkh;
        
       
        public UIForm1()
        {
            InitializeComponent();

            /*
            formNewCommand = new FormNewCommand(this);
            formClipboard = new FormClipboard(this);
            formKey = new FormKey(this);
            formAutoType = new FormAutoType(this);
            formApplication = new FormApplication(this);
            */

            formManager = new FormManager(this);

            profileHandler = new ProfileHandler(this);
            windowHandler = new WindowHandler(this);
            commandHandler = new CommandHandler(this);
            recognizer = new Recognizer(this);
            grammarHandler = new GrammarHandler(this);

            recognizer.init();

            /*
             * process flow
             * 1. Recognizer
             * 2. Command Handler lookup
             * 
             * 1. Form1 Load profile
             * 2. Command handler parse xml
             * 3. GrammarHandler process commands
             */

            //cbProfiles.SelectedIndexChanged  += new System.EventHandler(profileSelectionChangeHandler);
            


            loadProfile("default");
        }


        private void UIForm1_Load(object sender, EventArgs e)
        {
            
        }
        



        public void log(String s)
        {
            //rt1.Text += s + "\n";
            Console.WriteLine(s);
        }

        public void setStatus(String s)
        {
            rt1.Text = s;
        }
        public void clearStatus()
        {
            rt1.Text = "";
        }

        public void loadProfile(string file)
        {
            log("UIForm1.loadProfile("+file+")");

            profileHandler.load(file);
        }

        public ListView getListViewCommands()
        {
            return this.lvCommands;
        }

        public ComboBox getProfilesCB()
        {
            return this.cbProfiles;
        }






        public void setInputVolumeMetere(int i)
        {
            pb1.Value = i;
        }


        public void stopListening()
        {
            recognizer.sre.RecognizeAsyncStop();
            listening = false;
        }

        public void startListening()
        {
            try
            {
                recognizer.sre.RecognizeAsync(RecognizeMode.Multiple);
            } catch {}
            listening = true;
        }
       
        private void btnStopListening_Click(object sender, EventArgs e)
        {
            recognizer.sre.RecognizeAsyncStop();
            clearStatus();
            setStatus("Listening is now disabled.");
            listening = false;
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            try {
                recognizer.sre.RecognizeAsync(RecognizeMode.Multiple);
                clearStatus();
                setStatus("Listening is now enabled.");
                listening = true;
            }
            catch
            {
                clearStatus();
                setStatus("Listening is already enabled.");
                listening = true;
            }
            
            
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }



        public Int16 getConfidenceLevel()
        {
            return Int16.Parse(nudConfidence.Value.ToString());
        }



        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            if (listening)
            {
                btnStopListening_Click(null, null);
            }

            FormNewCommand formNewCommand = new FormNewCommand(this);
            formNewCommand.Show();
            this.Hide();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            profileHandler.save();
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(lvCommands.SelectedItems[0].Text.ToString());
            grammarHandler.removeCommand(lvCommands.SelectedItems[0].Text.ToString());
        }

        

    }
}
