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
    public partial class FormDictionaryEditorEdit : Form
    {
        private FormDictionaryEditor fde;
        private ListViewItem listViewItem;

        public FormDictionaryEditorEdit(FormDictionaryEditor arg1,ListViewItem arg2)
        {
            InitializeComponent();
            fde = arg1;
            listViewItem = arg2;
            tbSpeech.Text = arg2.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fde.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fde.update(listViewItem,tbSpeech.Text);
            fde.Show();
            this.Close();
        }

        private void FormDictionaryEditorEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            fde.Show();
        }




    }
}
