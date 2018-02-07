using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace AFTC___Voice_Commander
{
    public class ProfileManager
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormMain fm;
        private ListView lvProfiles;
        private Label lblActiveProfile;
        public List<string> profiles;

        public String selectedProfile;
        public String activeProfile;
        public XmlDocument xmlDoc;

        private FormProfileSave fps;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public ProfileManager(ListView arg1, Label arg2)
        {
            // Class specific debug
            t = new T(false);
            t.log("ProfileManager()");

            lvProfiles = arg1;
            lblActiveProfile = arg2;

            fm = Vars.formMain;

            profiles = new List<string>();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void getProfiles()
        {
            t.log("ProfileManager.getProfiles()");


            lvProfiles.Clear();
            lvProfiles.Items.Clear();
            
            lvProfiles.View = View.Details;
            lvProfiles.GridLines = true;
            lvProfiles.Sorting = SortOrder.Ascending;
            lvProfiles.HeaderStyle = ColumnHeaderStyle.None;
            lvProfiles.Columns.Add("Profile name",450);
            //lvProfiles.Columns.Add("Type", 146, HorizontalAlignment.Left);
            lvProfiles.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            

            //String[] fileEntries = Directory.GetFiles("profiles");
            String[] fileEntries = Directory.GetFiles(Vars.profilePath);

            foreach (string fileName in fileEntries)
            {
                //t.log("\t" + fileName);
                //String displayName = fileName.Replace("profiles\\", "");
                String displayName = fileName.Replace(Vars.profilePath+"\\", "");
                displayName = displayName.Replace(".xml", "");

                ListViewItem listViewItem = new ListViewItem(displayName);
                listViewItem.SubItems.Add(displayName);
                lvProfiles.Items.Add(listViewItem);
            }

        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void loadProfile()
        {
            t.log("ProfileManager.loadProfile(): " + lvProfiles.SelectedItems[0].Text);

            fm.setStatus("Loading profile, please wait...");

            selectedProfile = lvProfiles.SelectedItems[0].Text;
            String profileToLoad = Vars.profilePath + "\\" + selectedProfile + ".xml";
            t.log("ProfileManager.loadProfile(): profileToLoad = " + profileToLoad);

            xmlDoc = new XmlDocument();
            try { 
                xmlDoc.Load(profileToLoad);
            }
            catch (Exception e)
            {
                t.log("####################################");
                t.log("profileToLoad: " + profileToLoad);
                t.log(e.Message);
                fm.setStatus(e.Message);
                t.log("####################################");
                return;
            }
           
            //t.log("ProfileManager.loadProfile(): XML Loaded\n" + xmlDoc.InnerXml.ToString());

            fm.setStatus("Profile loaded!");

            lblActiveProfile.Text = "The current active profile is '" + selectedProfile + "'";

            activeProfile = selectedProfile;

            fm.commandManager.getCommandsFromLoadedProfile();
            //fm.grammarHandler.loadCommands();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void saveProfile()
        {
            t.log("ProfileManager.saveProfile()");

            fm.speechRecognizer.stopListening();
            fm.setStatus("Saving profile, please wait...");


            fps = new FormProfileSave(this);
            fm.Hide();
            fps.Show();
        }



        public void saveProfileProceed()
        {
            t.log("ProfileManager.saveProfileProceed()");


            int NoOfCommands = fm.commandManager.commands.Count;
            int cnt = 0;
            int percent = 0;

            String xmlString = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n";
            xmlString += "<xml>" + "\n\n";

            foreach (CommandVO cvo in fm.commandManager.commands)
            {
                cnt++;

                xmlString += "\t" + "<command>" + "\n";
                xmlString += "\t\t" + "<speech>" + cvo.speech + "</speech>" + "\n";
                xmlString += "\t\t" + "<command_sequence delayBetweenCommands=\"" + cvo.delayBetweenCommands + "\">" + "\n";

                for (int i = 0; i < cvo.commandItems.Count;i++ )
                {
                    CommandItemVO civo = cvo.commandItems[i];
                    t.log("civo.type = " + civo.type);

                    switch (civo.type)
                    {
                        case "run application":
                            xmlString += "\t\t\t" + "<item type=\"" + civo.type + "\">\n";
                            xmlString += "\t\t\t\t" + "<path>" + civo.applicationPath + "</path>\n";
                            xmlString += "\t\t\t\t" + "<params>" + civo.applicationParams + "</params>\n";
                            xmlString += "\t\t\t" + "</item>" + "\n";
                            break;
                        case "clipboard":
                            xmlString += "\t\t\t" + "<item type=\"" + civo.type + "\" autoPaste=\"" + DTools.boolToNumberString(civo.clipboardAutoPaste) + "\">";
                            xmlString += "<![CDATA[" + civo.clipboard + "]]>";
                            xmlString += "</item>" + "\n";
                            break;
                        case "clipboard to var":
                            xmlString += "\t\t\t" + "<item type=\"" + civo.type + "\" var=\"" + civo.appVarIndex + "\"></item>\n";
                            break;
                        case "var to clipboard":
                            xmlString += "\t\t\t" + "<item type=\"" + civo.type + "\" var=\"" + civo.appVarIndex + "\"></item>\n";
                            break;
                        case "key":
                            xmlString += "\t\t\t" + "<item type=\"" + civo.type + "\" ";
                            xmlString += "ctrl=\"" + DTools.boolToNumberString(civo.ctrlPressed) + "\" ";
                            xmlString += "alt=\"" + DTools.boolToNumberString(civo.altPressed) + "\" ";
                            xmlString += "shift=\"" + DTools.boolToNumberString(civo.shiftPressed) + "\">";
                            xmlString += civo.key;
                            xmlString += "</item>" + "\n";
                            break;
                        case "delay":
                            xmlString += "\t\t\t" + "<item type=\"" + civo.type + "\" duration=\"" + civo.delayTime.ToString() + "\"></item>\n";
                            break;
                        case "focus on application":
                            xmlString += "\t\t\t" + "<item type=\"" + civo.type + "\" ";
                            xmlString += "delayBeforeFocus=\"" + civo.delayBeforeFocus.ToString() + "\" ";
                            xmlString += "stopIfFocusNotFound=\"" + DTools.boolToNumberString(civo.stopIfFocusNotFound) + "\" ";
                            xmlString += "/>\n";
                            break;
                    }

                    
                }

                xmlString += "\t\t" + "</command_sequence>" + "\n";
                xmlString += "\t" + "</command>" + "\n\n";
            }

            xmlString += "</xml>" + "\n";

            //XDocument xDoc = XDocument.Load(xmlString);

            t.log(xmlString);

            
            //FileStream fileStream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);


            String profilePath = Vars.profilePath + "/" + activeProfile + ".xml";

            try
            {
                //xDoc.Save(fileStream);
                File.WriteAllText(profilePath, xmlString, Encoding.UTF8);
                fm.setStatus("Profile saved!");
                fm.speechRecognizer.startListening();
            }
            catch
            {
                fm.setStatus("Unable to save profile!");
            }

            fm.Show();

            fps.Close();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void newProfile()
        {
            t.log("ProfileManager.newProfile()");

            fm.setStatus("This feature is under construction!");
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void deleteProfile()
        {
            t.log("ProfileManager.deleteProfile()");

            if (lvProfiles.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a profile to delete first!");
                return;
            }
            selectedProfile = lvProfiles.SelectedItems[0].Text;

            if (selectedProfile == "default")
            {
                fm.setStatus("The default profile cannot be deleted!");
                return;
            }

            String f = "profiles/"+selectedProfile+".xml";
            File.Delete(f);
            getProfiles();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void setSelected(String profileName)
        {
            t.log("ProfileManager.setSelected("+profileName+")");

            foreach (ListViewItem item in lvProfiles.Items)
            {
                //t.log("FormMain.FormMain_Load(): " + item.Text);
                if (item.Text == profileName)
                {
                    item.Selected = true;
                }
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        

    }
}
