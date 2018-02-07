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
    public partial class FormDictionaryEditor : Form
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public FormDictionaryEditor()
        {
            InitializeComponent();

            // Class specific debug
            t = new T(true);
            t.log("FormDictionaryEditor()");
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormDictionaryEditor_Load(object sender, EventArgs e)
        {
            t.log("FormDictionaryEditor.FormDictionaryEditor_Load()");

            String msg = "";
            msg = "- Try to keep the list to under 1500 items or you will either dramatically slow down the application or crash it all together." + "\n\n";
            msg += "- Add words which are in your commands to make your commands more accurate." + "\n\n";
            msg += "- Why does the dictionary already contain a lot of words?" + "\n";
            msg += "This allows the software to be as accurate as possible on first use without having to create or add your own dictionary words." + "\n\n";

            rtbInfo.Text = msg;

            lvDictionary.Clear();
            lvDictionary.Items.Clear();

            lvDictionary.View = View.Details;
            lvDictionary.GridLines = true;
            lvDictionary.Sorting = SortOrder.Ascending;
            //lvDictionary.HeaderStyle = ColumnHeaderStyle.None;
            //lvDictionary.Columns.Add("No", 50);
            lvDictionary.Columns.Add("Speech", lvDictionary.Width - 20, HorizontalAlignment.Left);
            lvDictionary.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            //lvDictionary.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);


            var lines = File.ReadLines(Vars.dictionaryPath);
            int cnt = 0;
            foreach (String line in lines)
            {
                if (line != "")
                {
                    cnt++;

                    //ListViewItem listViewItem = new ListViewItem(cnt.ToString());
                    ListViewItem listViewItem = new ListViewItem(line);
                    //listViewItem.SubItems.Add(line);
                    lvDictionary.Items.Add(listViewItem);
                }
            }

            updateCount();

            //lvDictionary.SortColumn = 0;
            lvDictionary.Sort();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void FormDictionaryEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vars.formMain.Show();
            //this.Close();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void updateCount()
        {
            lbCount.Text = "There are currently " + lvDictionary.Items.Count.ToString() + " dictionary entries.";
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

     

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormDictionaryEditorAdd fdeAdd = new FormDictionaryEditorAdd(this);
            fdeAdd.Show();
            this.Hide();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvDictionary.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select something to edit first!");
                return;
            }

            FormDictionaryEditorEdit fdeEdit = new FormDictionaryEditorEdit(this,lvDictionary.SelectedItems[0]);
            fdeEdit.Show();
            this.Hide();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnDelete_Click(object sender, EventArgs e)
        {
            remove();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void update(ListViewItem listViewItem,String speech)
        {
            lvDictionary.Items.Remove(listViewItem);

            ListViewItem updatedListViewItem = new ListViewItem(speech);
            lvDictionary.Items.Add(updatedListViewItem);
            updateCount();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void add(String s)
        {
            ListViewItem listViewItem = new ListViewItem(s);
            lvDictionary.Items.Add(listViewItem);
            updateCount();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void remove()
        {
            if (lvDictionary.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select something to delete first!");
                return;
            }

            if (lvDictionary.SelectedItems.Count == 1)
            {
                ListViewItem listViewItem = lvDictionary.SelectedItems[0];
                lvDictionary.Items.Remove(listViewItem);
            }

            if (lvDictionary.SelectedItems.Count > 1)
            {
                foreach (ListViewItem listViewItem in lvDictionary.SelectedItems)
                {
                    lvDictionary.Items.Remove(listViewItem);
                }
            }

            updateCount();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void btnSave_Click(object sender, EventArgs e)
        {
            String[] lines = new String[50000];
            int i = 0;
            foreach (ListViewItem lvi in lvDictionary.Items)
            {
                lines[i] = lvi.Text;
                i++;
            }

            t.log("FormDictionaryEditor.btnSave_Click(): saving " + i + " dictionary commands!");

            File.WriteAllLines("GrammarDictionary.txt", lines);


            Vars.formMain.grammarHandler.loadCommands();
            Vars.formMain.Show();
            this.Close();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

    }
}
