using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace AFTC_Voice_Developer
{
    public class ProfileHandler
    {
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private UIForm1 ui;
        
        public String profileName;
        public String file;
        public XmlDocument xmlDoc;
        public String xmlString;
        public XmlNodeList commands;

        private ComboBox cbProfiles;


        private FormSaving formSaving;
        private List<ProfileVO> profiles;
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public ProfileHandler(UIForm1 arg)
        {
            ui = arg;
            ui.log("ProfileHandler()");

            cbProfiles = ui.getProfilesCB();
            cbProfiles.SelectionChangeCommitted += new System.EventHandler(profileSelectionChangeHandler);
            getProfiles();
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private void profileSelectionChangeHandler(object sender, System.EventArgs e)
        {
            ui.log("ProfileHandler.profileSelectionChangeHandler()");
            //cbProfiles.Select(0, 0); // Doesn't work
            //cbProfiles.SelectionLength = 0; // Doesn't work
            ui.getListViewCommands().Focus();

            //Console.WriteLine(cbProfiles.SelectedIndex);
            ProfileVO vo = (ProfileVO)cbProfiles.Items[cbProfiles.SelectedIndex];
            Console.WriteLine(vo.displayName);
            load(vo.displayName);
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public void getProfiles()
        {
            ui.log("ProfileHandler.getProfiles()");


            profiles = new List<ProfileVO>();


            ui.log("------");
            string [] fileEntries = Directory.GetFiles("profiles");
            foreach(string fileName in fileEntries)
            {
                ProfileVO profile = new ProfileVO();
                profile.displayName = fileName.Replace("profiles\\", "");
                profile.displayName = profile.displayName.Replace(".xml", "");
                profile.fileName = fileName;
                profiles.Add(profile);

                ui.log("\t"+ profile.displayName);
            }
            ui.log("------");

            cbProfiles.DataSource = profiles;
            cbProfiles.DisplayMember = "displayName";
            cbProfiles.ValueMember = "fileName";
            //cbProfiles
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public void load(String arg)
        {
            ui.log("ProfileHandler.load("+arg+")");

            profileName = arg;
            file = "profiles/" + profileName + ".xml";
            //file = arg;
            //profileName = file.Replace("profiles\\","");
            //profileName = profileName.Replace(".xml", "");

            xmlDoc = new XmlDocument();
            //xmlDoc.Load("profiles/" + profileName + ".xml");
            xmlDoc.Load(file);
            xmlString = xmlDoc.InnerXml;

            commands = xmlDoc.SelectNodes("//command");
            //ui.grammarHandler.clear();
            ui.grammarHandler.grammarLoaded += new EventHandler(grammarLoadedHandler);
            ui.grammarHandler.loadCommands(commands, profileName);

            //ui.log("#### profileName = " + profileName);
            //ui.log("#### file = " + file);


            //cbProfiles.SelectedValue = "default";
            //cbProfiles.SelectedItem = "default";


            //foreach (ProfileVO vo in cbProfiles.Items)
            for (int i = 0; i < cbProfiles.Items.Count; i++)
            {
                //Console.WriteLine(cbProfiles.Items[i].GetType());

                ProfileVO vo = (ProfileVO)cbProfiles.Items[i];
                //ui.log("#### vo = " + vo.displayName);
                
                if (vo.displayName == profileName)
                {
                    cbProfiles.SelectedIndex = i;
                }
            }
            
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private void grammarLoadedHandler(object o, EventArgs e)
        {
            ui.log("ProfileHandler.grammarLoadedHandler()");
            //ui.setStatus("Profile: \"" + profileName + "\" loaded.");
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public void reload()
        {
            ui.log("profileHandler.reload()");
            load(profileName);
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private XDocument xDoc;

        public void save()
        {
            ui.log("profileHandler.save()");


            formSaving = new FormSaving();
            ui.Hide();
            formSaving.Show();

            Console.WriteLine("####### " + ui.grammarHandler.commands.Count);
            int NoOfCommands = ui.grammarHandler.commands.Count;
            int cnt = 0;
            int percent = 0;

            String xmlString = "";
            xmlString = "<xml>\n";
            foreach (CommandVO cvo in ui.grammarHandler.commands)
            {
                cnt++;
                percent = (100 / NoOfCommands) * cnt;
                formSaving.setProgress(percent);

                XDocument x = cvo.getXDoc();
                //foreach (XElement node in x.Root.Elements())
                foreach (XElement node in x.Elements())
                {
                    //Console.WriteLine("----------------------");
                    //Console.WriteLine(node.ToString());
                    //Console.WriteLine("----------------------");
                    xmlString += "\n";
                    xmlString += node.ToString();
                    xmlString += "\n";
                }
            }
            xmlString += "\n</xml>";

            xDoc = new XDocument();
            xDoc = XDocument.Parse(xmlString);


            /*
            Console.WriteLine("\n\n----------------------");
            Console.WriteLine(xmlString);
            Console.WriteLine("----------------------\n\n");
            */

            //String msg = "Profile \"" + profileName + "\" [" + file + "] has been updated!";
            //Console.WriteLine(msg);
            //MessageBox.Show(msg);
            //xDoc.Save(file);
            //xDoc.Save(file);

            

            FileStream fileStream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                xDoc.Save(fileStream);
            }
            finally
            {
                fileStream.Close();
            }


            ui.Show();
            formSaving.Hide();

            Console.Write("ProfileHandler.save(): Completed!");
            this.load(profileName);

        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        


    }
}