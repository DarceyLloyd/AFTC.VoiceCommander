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
    public partial class FormAutoType : Form
    {
        private UIForm1 ui;

        public FormAutoType(UIForm1 arg)
        {
            InitializeComponent();
            ui = arg;
        }

        private void FormAutoType_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ui.Show();
            this.Close();
            ui.startListening();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAutoType_FormClosed(object sender, FormClosedEventArgs e)
        {
            ui.Show();
            ui.startListening();
        }

       
    }
}
