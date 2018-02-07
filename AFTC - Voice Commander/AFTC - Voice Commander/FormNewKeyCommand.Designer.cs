namespace AFTC___Voice_Commander
{
    partial class FormNewKeyCommand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbCtrl = new System.Windows.Forms.CheckBox();
            this.cbAlt = new System.Windows.Forms.CheckBox();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvKeys = new System.Windows.Forms.ListView();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Key command editor";
            // 
            // cbCtrl
            // 
            this.cbCtrl.AutoSize = true;
            this.cbCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCtrl.Location = new System.Drawing.Point(523, 160);
            this.cbCtrl.Name = "cbCtrl";
            this.cbCtrl.Size = new System.Drawing.Size(57, 19);
            this.cbCtrl.TabIndex = 58;
            this.cbCtrl.Text = "CTRL";
            this.cbCtrl.UseVisualStyleBackColor = true;
            this.cbCtrl.CheckStateChanged += new System.EventHandler(this.cbCtrl_CheckStateChanged);
            // 
            // cbAlt
            // 
            this.cbAlt.AutoSize = true;
            this.cbAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlt.Location = new System.Drawing.Point(523, 190);
            this.cbAlt.Name = "cbAlt";
            this.cbAlt.Size = new System.Drawing.Size(47, 19);
            this.cbAlt.TabIndex = 59;
            this.cbAlt.Text = "ALT";
            this.cbAlt.UseVisualStyleBackColor = true;
            this.cbAlt.CheckStateChanged += new System.EventHandler(this.cbAlt_CheckStateChanged);
            // 
            // cbShift
            // 
            this.cbShift.AutoSize = true;
            this.cbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShift.Location = new System.Drawing.Point(523, 130);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(60, 19);
            this.cbShift.TabIndex = 60;
            this.cbShift.Text = "SHIFT";
            this.cbShift.UseVisualStyleBackColor = true;
            this.cbShift.CheckStateChanged += new System.EventHandler(this.cbShift_CheckStateChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(530, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 25);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(10, 43);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(97, 16);
            this.lbl2.TabIndex = 133;
            this.lbl2.Text = "Available keys";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(530, 425);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 25);
            this.btnAdd.TabIndex = 135;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lvKeys
            // 
            this.lvKeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvKeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKeys.FullRowSelect = true;
            this.lvKeys.GridLines = true;
            this.lvKeys.HideSelection = false;
            this.lvKeys.Location = new System.Drawing.Point(10, 70);
            this.lvKeys.MultiSelect = false;
            this.lvKeys.Name = "lvKeys";
            this.lvKeys.Size = new System.Drawing.Size(500, 380);
            this.lvKeys.TabIndex = 136;
            this.lvKeys.UseCompatibleStateImageBehavior = false;
            this.lvKeys.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvKeys_ItemSelectionChanged);
            // 
            // tbKey
            // 
            this.tbKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbKey.Location = new System.Drawing.Point(520, 100);
            this.tbKey.Name = "tbKey";
            this.tbKey.ReadOnly = true;
            this.tbKey.Size = new System.Drawing.Size(100, 20);
            this.tbKey.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 138;
            this.label2.Text = "Key to press";
            // 
            // FormNewKeyCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lvKeys);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.cbAlt);
            this.Controls.Add(this.cbCtrl);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "FormNewKeyCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFTC - Windows Voice Commander";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewKeyCommand_FormClosing);
            this.Load += new System.EventHandler(this.FormNewKeyCommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCtrl;
        private System.Windows.Forms.CheckBox cbAlt;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvKeys;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label2;
    }
}