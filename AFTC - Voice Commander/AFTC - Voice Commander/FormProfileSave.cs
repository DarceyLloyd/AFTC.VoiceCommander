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
    public partial class FormProfileSave : Form
    {
        private ProfileManager pm;
        private Timer t;

        public FormProfileSave(ProfileManager pm)
        {
            InitializeComponent();

            this.pm = pm;
        }

        private void FormProfileSave_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += OnTimedEvent;
            t.Enabled = true;
            t.Start();
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            t.Stop();
            pm.saveProfileProceed();
        }


        private void FormProfileSave_Shown(object sender, EventArgs e)
        {
            
        }

        private void label1_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }
    }
}
