using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AFTC___Voice_Commander
{
    public partial class FormMain : Form
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public ProfileManager profileManager;
        public CommandManager commandManager;
        public FormMainCommandListController fmCommandListController;
        public SpeechRecognizer speechRecognizer;
        public GrammarHandler grammarHandler;
        public CommandExecutionHandler commandExecutionHandler;

        private FormCommandEditor formCommandEditor;

        private T t;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public FormMain()
        {
            InitializeComponent();

            // Class specific debug
            t = new T(true);
            t.log("FormMain()");

            // Var ini & instantiation
            Vars.formMain = this;

            profileManager = new ProfileManager(this.lvProfiles,this.lblActiveProfile);
            commandManager = new CommandManager();
            fmCommandListController = new FormMainCommandListController(this.lvCommands);

            commandExecutionHandler = new CommandExecutionHandler();

            grammarHandler = new GrammarHandler();
            speechRecognizer = new SpeechRecognizer();
            
            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormMain_Load(object sender, EventArgs e)
        {
            t.log("FormMain.FormMain_Load()");

            setStatus("Starting up, please wait...");



            // Ensure application folders and exist in the MyDocuments app folder
            

            Directory.CreateDirectory(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AFTC_Voice_Commander"));
            Directory.CreateDirectory(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AFTC_Voice_Commander","profiles"));

            String defaultProfile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AFTC_Voice_Commander","profiles","default.xml");
            //t.log("FormMain.FormMain_Load(): defaultProfile = " + defaultProfile);
            if (!File.Exists(defaultProfile))
            {
                t.log("FormMain.FormMain_Load(): copying default profile to users my documents folder");
                System.IO.File.Copy("profiles/default.xml", defaultProfile, true);
            }


            String defaultDictionary = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AFTC_Voice_Commander", "DefaultDictionary.txt");
            //t.log("FormMain.FormMain_Load(): defaultDictionary = " + defaultDictionary);
            if (!File.Exists(defaultDictionary))
            {
                t.log("FormMain.FormMain_Load(): copying default dictionary to users my documents folder");
                System.IO.File.Copy("DefaultDictionary.txt", defaultDictionary, true);
            }
            //return;




            profileManager.getProfiles();

            // TO DO, remember selected and use for each run session
            profileManager.setSelected("default");

            profileManager.loadProfile();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormMain_Shown(object sender, EventArgs e)
        {
            t.log("FormMain.FormMain_Shown()");

            //btnOpenDictionary_Click(null, null);
            //btnHelp_Click(null, null);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -








        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void setStatus(String s)
        {
            clearStatus();
            rtStatus.Text = s;
        }
        public void clearStatus()
        {
            rtStatus.Text = "";
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void setInputVolumeMetere(int i)
        {
            pbMicLevel.Value = i;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void stopListening()
        {
            t.log("FormMain.stopListening()");
            speechRecognizer.stopListening();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void startListening()
        {
            t.log("FormMain.startListening()");
            speechRecognizer.startListening();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnLoadProfile_Click()");
            profileManager.loadProfile();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnStartListening_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnStartListening_Click()");
            speechRecognizer.startListening();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnStopListening_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnStopListening_Click()");
            speechRecognizer.stopListening();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnNewProfile_Click()");
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnDeleteProfile_Click()");
            profileManager.deleteProfile();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            t.log("\n\n\nFormMain.btnAddCommand_Click()");

            speechRecognizer.stopListening();
            this.Hide();
            
            formCommandEditor = new FormCommandEditor();
            formCommandEditor.Show();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnEditCommand_Click(object sender, EventArgs e)
        {
            t.log("\n\n\nFormMain.btnEditCommand_Click()");

            if (lvCommands.SelectedItems.Count<1)
            {
                MessageBox.Show("Please select a command to edit first!");
                return;
            }

            speechRecognizer.stopListening();
            this.Hide();

            CommandVO selectedCommandVO = commandManager.getCommand(lvCommands.SelectedItems[0].Text);
            CommandVO cvoToEdit = selectedCommandVO.clone();
            //int selectedCommandVOIndex = lvCommands.SelectedIndices[0];

            formCommandEditor = new FormCommandEditor(cvoToEdit);
            formCommandEditor.Show();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnDeleteCommand_Click()");

            commandManager.deleteCommand();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public Int16 getConfidenceLevel()
        {
            return Int16.Parse(nudConfidence.Value.ToString());
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -





        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormMain_Resize(object sender, EventArgs e)
        {
            lvProfiles.Height = this.Height - (lvProfiles.Location.Y + 80);
            lvCommands.Height = this.Height - (lvCommands.Location.Y + 80);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnHelp_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnHelp_Click()");

            speechRecognizer.stopListening();
            this.Hide();
            FormHelp fh = new FormHelp();
            fh.Show();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnSave_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnSave_Click()");

            profileManager.saveProfile();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnOpenDictionary_Click(object sender, EventArgs e)
        {
            t.log("FormMain.btnOpenDictionary_Click()");

            speechRecognizer.stopListening();

            FormDictionaryEditor fde = new FormDictionaryEditor();
            fde.Show();
            this.Hide();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -






        




    }
}
