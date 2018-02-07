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
    public partial class FormDictionaryEditorAdd : Form
    {
        private FormDictionaryEditor fde;

        public FormDictionaryEditorAdd(FormDictionaryEditor arg1)
        {
            InitializeComponent();

            fde = arg1;
        }

        private void FormDictionaryEditorAdd_Load(object sender, EventArgs e)
        {
            tbSpeech.Focus();
        }

        private void FormDictionaryEditorAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            fde.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fde.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fde.add(tbSpeech.Text);
            fde.Show();
            this.Close();
        }
    }
}
