namespace AFTC_Voice_Developer
{
    partial class UIForm1
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
            this.btnStopListening = new System.Windows.Forms.Button();
            this.rt1 = new System.Windows.Forms.RichTextBox();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.lvCommands = new System.Windows.Forms.ListView();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.btnEditCommand = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.nudConfidence = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidence)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStopListening
            // 
            this.btnStopListening.BackColor = System.Drawing.Color.White;
            this.btnStopListening.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopListening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopListening.Location = new System.Drawing.Point(511, 3);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(143, 23);
            this.btnStopListening.TabIndex = 1;
            this.btnStopListening.Text = "STOP LISTENING";
            this.btnStopListening.UseVisualStyleBackColor = false;
            this.btnStopListening.Click += new System.EventHandler(this.btnStopListening_Click);
            // 
            // rt1
            // 
            this.rt1.BackColor = System.Drawing.Color.White;
            this.rt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt1.Location = new System.Drawing.Point(3, 32);
            this.rt1.Name = "rt1";
            this.rt1.ReadOnly = true;
            this.rt1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rt1.Size = new System.Drawing.Size(651, 39);
            this.rt1.TabIndex = 1;
            this.rt1.Text = "";
            this.rt1.WordWrap = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(152, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(353, 23);
            this.pb1.TabIndex = 2;
            // 
            // btnStartListening
            // 
            this.btnStartListening.BackColor = System.Drawing.Color.White;
            this.btnStartListening.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartListening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartListening.Location = new System.Drawing.Point(3, 3);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(143, 23);
            this.btnStartListening.TabIndex = 0;
            this.btnStartListening.Text = "START LISTENING";
            this.btnStartListening.UseVisualStyleBackColor = false;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // lvCommands
            // 
            this.lvCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCommands.FullRowSelect = true;
            this.lvCommands.GridLines = true;
            this.lvCommands.HideSelection = false;
            this.lvCommands.Location = new System.Drawing.Point(8, 8);
            this.lvCommands.Name = "lvCommands";
            this.lvCommands.Size = new System.Drawing.Size(646, 491);
            this.lvCommands.TabIndex = 50;
            this.lvCommands.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.BackColor = System.Drawing.Color.White;
            this.btnAddCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommand.Location = new System.Drawing.Point(8, 505);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(75, 24);
            this.btnAddCommand.TabIndex = 7;
            this.btnAddCommand.Text = "ADD";
            this.btnAddCommand.UseVisualStyleBackColor = false;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // btnEditCommand
            // 
            this.btnEditCommand.BackColor = System.Drawing.Color.White;
            this.btnEditCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCommand.Location = new System.Drawing.Point(98, 505);
            this.btnEditCommand.Name = "btnEditCommand";
            this.btnEditCommand.Size = new System.Drawing.Size(75, 24);
            this.btnEditCommand.TabIndex = 8;
            this.btnEditCommand.Text = "EDIT";
            this.btnEditCommand.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.BackColor = System.Drawing.Color.White;
            this.btnDeleteProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.Location = new System.Drawing.Point(538, 8);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(116, 24);
            this.btnDeleteProfile.TabIndex = 25;
            this.btnDeleteProfile.Text = "DELETE PROFILE";
            this.btnDeleteProfile.UseVisualStyleBackColor = false;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.White;
            this.btnSaveProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProfile.Location = new System.Drawing.Point(538, 505);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(116, 24);
            this.btnSaveProfile.TabIndex = 24;
            this.btnSaveProfile.Text = "SAVE PROFILE";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.BackColor = System.Drawing.Color.White;
            this.btnDeleteCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCommand.Location = new System.Drawing.Point(188, 505);
            this.btnDeleteCommand.Name = "btnDeleteCommand";
            this.btnDeleteCommand.Size = new System.Drawing.Size(75, 24);
            this.btnDeleteCommand.TabIndex = 11;
            this.btnDeleteCommand.Text = "DELETE";
            this.btnDeleteCommand.UseVisualStyleBackColor = false;
            this.btnDeleteCommand.Click += new System.EventHandler(this.btnDeleteCommand_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(3, 79);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(278, 16);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "Minimum speech command acceptance level";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(343, 79);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(20, 16);
            this.lbl3.TabIndex = 15;
            this.lbl3.Text = "%";
            // 
            // nudConfidence
            // 
            this.nudConfidence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudConfidence.Location = new System.Drawing.Point(287, 77);
            this.nudConfidence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConfidence.Name = "nudConfidence";
            this.nudConfidence.Size = new System.Drawing.Size(50, 22);
            this.nudConfidence.TabIndex = 2;
            this.nudConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudConfidence.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudConfidence.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Activity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Profiles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Selected profile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Commands";
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.BackColor = System.Drawing.Color.White;
            this.btnNewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProfile.Location = new System.Drawing.Point(416, 7);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(116, 24);
            this.btnNewProfile.TabIndex = 23;
            this.btnNewProfile.Text = "NEW PROFILE";
            this.btnNewProfile.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Controls.Add(this.rt1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.nudConfidence);
            this.panel1.Controls.Add(this.btnStartListening);
            this.panel1.Controls.Add(this.btnStopListening);
            this.panel1.Location = new System.Drawing.Point(13, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 106);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbProfiles);
            this.panel2.Controls.Add(this.btnNewProfile);
            this.panel2.Controls.Add(this.btnDeleteProfile);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(13, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 41);
            this.panel2.TabIndex = 25;
            // 
            // cbProfiles
            // 
            this.cbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.Location = new System.Drawing.Point(129, 7);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(281, 24);
            this.cbProfiles.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lvCommands);
            this.panel3.Controls.Add(this.btnAddCommand);
            this.panel3.Controls.Add(this.btnEditCommand);
            this.panel3.Controls.Add(this.btnDeleteCommand);
            this.panel3.Controls.Add(this.btnSaveProfile);
            this.panel3.Location = new System.Drawing.Point(13, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 536);
            this.panel3.TabIndex = 51;
            // 
            // UIForm1
            // 
            this.AcceptButton = this.btnStopListening;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 773);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(700, 807);
            this.MinimumSize = new System.Drawing.Size(700, 807);
            this.Name = "UIForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice to Key Injector - Darcey@AllForTheCode.co.uk";
            this.Load += new System.EventHandler(this.UIForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidence)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStopListening;
        private System.Windows.Forms.RichTextBox rt1;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.ListView lvCommands;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.Button btnEditCommand;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnDeleteCommand;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.NumericUpDown nudConfidence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbProfiles;
    }
}

