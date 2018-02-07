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
    public partial class FormKey : Form
    {
        private UIForm1 ui;

        public FormKey(UIForm1 arg)
        {
            InitializeComponent();
            ui = arg;
        }

        private void FormKey_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ui.Show();
            this.Close();
            ui.startListening();
        }

        private void FormKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            ui.Show();
            ui.startListening();
        }
    }
}
