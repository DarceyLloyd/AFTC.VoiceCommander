namespace AFTC_Voice_Developer
{
    partial class FormClipboard
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
            this.rtClipboard = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpeech = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbAutoPaste = new System.Windows.Forms.CheckBox();
            this.lblAccepted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtClipboard
            // 
            this.rtClipboard.AcceptsTab = true;
            this.rtClipboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtClipboard.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtClipboard.Location = new System.Drawing.Point(15, 96);
            this.rtClipboard.Name = "rtClipboard";
            this.rtClipboard.Size = new System.Drawing.Size(663, 427);
            this.rtClipboard.TabIndex = 57;
            this.rtClipboard.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Text for windows copy buffer";
            // 
            // tbSpeech
            // 
            this.tbSpeech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpeech.Location = new System.Drawing.Point(12, 28);
            this.tbSpeech.MaxLength = 500;
            this.tbSpeech.Name = "tbSpeech";
            this.tbSpeech.Size = new System.Drawing.Size(666, 22);
            this.tbSpeech.TabIndex = 55;
            this.tbSpeech.TextChanged += new System.EventHandler(this.tbSpeech_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Speech command";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 529);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 24);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(562, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 24);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbAutoPaste
            // 
            this.cbAutoPaste.AutoSize = true;
            this.cbAutoPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoPaste.Location = new System.Drawing.Point(257, 532);
            this.cbAutoPaste.Name = "cbAutoPaste";
            this.cbAutoPaste.Size = new System.Drawing.Size(169, 20);
            this.cbAutoPaste.TabIndex = 58;
            this.cbAutoPaste.Text = "Auto Paste (CTRL V)";
            this.cbAutoPaste.UseVisualStyleBackColor = true;
            // 
            // lblAccepted
            // 
            this.lblAccepted.AutoSize = true;
            this.lblAccepted.Location = new System.Drawing.Point(9, 53);
            this.lblAccepted.Name = "lblAccepted";
            this.lblAccepted.Size = new System.Drawing.Size(120, 13);
            this.lblAccepted.TabIndex = 62;
            this.lblAccepted.Text = "Command already exists";
            // 
            // FormClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(690, 565);
            this.Controls.Add(this.lblAccepted);
            this.Controls.Add(this.cbAutoPaste);
            this.Controls.Add(this.rtClipboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSpeech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormClipboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipboard command setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClipboard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClipboard_FormClosed);
            this.Load += new System.EventHandler(this.FormClipboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtClipboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSpeech;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbAutoPaste;
        private System.Windows.Forms.Label lblAccepted;
    }
}