namespace AFTC_Voice_Developer
{
    partial class FormNewCommand
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbCommandType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(328, 152);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(116, 24);
            this.btnSelect.TabIndex = 23;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbCommandType
            // 
            this.cbCommandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommandType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCommandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCommandType.FormattingEnabled = true;
            this.cbCommandType.Location = new System.Drawing.Point(8, 32);
            this.cbCommandType.Name = "cbCommandType";
            this.cbCommandType.Size = new System.Drawing.Size(440, 24);
            this.cbCommandType.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Please choose your command type";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(8, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 24);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rtInfo
            // 
            this.rtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtInfo.Location = new System.Drawing.Point(8, 64);
            this.rtInfo.MaxLength = 500;
            this.rtInfo.Name = "rtInfo";
            this.rtInfo.ReadOnly = true;
            this.rtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtInfo.Size = new System.Drawing.Size(440, 73);
            this.rtInfo.TabIndex = 30;
            this.rtInfo.TabStop = false;
            this.rtInfo.Text = "";
            // 
            // FormNewCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 189);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtInfo);
            this.Controls.Add(this.cbCommandType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNewCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add command";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewCommand_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNewCommand_FormClosed);
            this.Load += new System.EventHandler(this.FormNewCommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbCommandType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox rtInfo;
    }
}