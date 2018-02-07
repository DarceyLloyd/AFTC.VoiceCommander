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
    public partial class FormApplication : Form
    {
        private UIForm1 ui;

        public FormApplication(UIForm1 arg)
        {
            InitializeComponent();
            ui = arg;
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ui.Show();
            this.Close();
            ui.startListening();
        }

        private void FormApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            ui.Show();
            ui.startListening();
        }
    }
}
