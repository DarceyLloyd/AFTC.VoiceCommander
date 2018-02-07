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
    public partial class FormHelp : Form
    {
        private T t;


        public FormHelp()
        {
            InitializeComponent();

            // Class specific debug
            t = new T(false);
            t.log("FormHelp()");

        }

        private void FormHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vars.formMain.Show();
            Vars.formMain.startListening();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            t.log("FormHelp.btnClose_Click()");

            Vars.formMain.Show();
            Vars.formMain.startListening();
            this.Close();
        }

        

        private void FormHelp_Load(object sender, EventArgs e)
        {
            t.log("FormHelp.FormHelp_Load()");

            rtbHelp.Text = File.ReadAllText("help.txt");
        }
    }
}
