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
    public partial class FormSaving : Form
    {
        public FormSaving()
        {
            InitializeComponent();
            lblProgress.Text = "";
        }


        public void setProgress(int i)
        {
            pbProgress.Value = i;
            lblProgress.Text = i.ToString() + "%";
        }
    }
}
