namespace AFTC___Voice_Commander
{
    partial class FormNewClipboardCommand
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
            this.rtClipboard = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAutoPaste = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Clipboard command editor";
            // 
            // rtClipboard
            // 
            this.rtClipboard.AcceptsTab = true;
            this.rtClipboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtClipboard.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtClipboard.Location = new System.Drawing.Point(10, 70);
            this.rtClipboard.Name = "rtClipboard";
            this.rtClipboard.Size = new System.Drawing.Size(760, 330);
            this.rtClipboard.TabIndex = 57;
            this.rtClipboard.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "The following text will be placed within the windows clipboard (copy buffer)";
            // 
            // cbAutoPaste
            // 
            this.cbAutoPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAutoPaste.AutoSize = true;
            this.cbAutoPaste.Checked = true;
            this.cbAutoPaste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoPaste.Location = new System.Drawing.Point(211, 426);
            this.cbAutoPaste.Name = "cbAutoPaste";
            this.cbAutoPaste.Size = new System.Drawing.Size(343, 17);
            this.cbAutoPaste.TabIndex = 59;
            this.cbAutoPaste.Text = "Auto paste clipboard (Auto press CTRL + V) after content insertion?";
            this.cbAutoPaste.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(660, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 25);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(10, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 25);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormNewClipboardCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbAutoPaste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtClipboard);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormNewClipboardCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFTC - Windows Voice Commander";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewClipboardCommand_FormClosing);
            this.Resize += new System.EventHandler(this.FormNewClipboardCommand_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtClipboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAutoPaste;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}