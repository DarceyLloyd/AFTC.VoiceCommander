namespace AFTC___Voice_Commander
{
    partial class FormMain
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
            this.pbMicLevel = new System.Windows.Forms.ProgressBar();
            this.rtStatus = new System.Windows.Forms.RichTextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.nudConfidence = new System.Windows.Forms.NumericUpDown();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvCommands = new System.Windows.Forms.ListView();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.btnEditCommand = new System.Windows.Forms.Button();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.lvProfiles = new System.Windows.Forms.ListView();
            this.lblActiveProfile = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenDictionary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidence)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Activity";
            // 
            // pbMicLevel
            // 
            this.pbMicLevel.Location = new System.Drawing.Point(10, 156);
            this.pbMicLevel.Name = "pbMicLevel";
            this.pbMicLevel.Size = new System.Drawing.Size(470, 10);
            this.pbMicLevel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbMicLevel.TabIndex = 21;
            // 
            // rtStatus
            // 
            this.rtStatus.BackColor = System.Drawing.Color.White;
            this.rtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtStatus.Location = new System.Drawing.Point(10, 40);
            this.rtStatus.Name = "rtStatus";
            this.rtStatus.ReadOnly = true;
            this.rtStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtStatus.Size = new System.Drawing.Size(470, 40);
            this.rtStatus.TabIndex = 19;
            this.rtStatus.TabStop = false;
            this.rtStatus.Text = "";
            this.rtStatus.WordWrap = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(10, 90);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(278, 16);
            this.lbl2.TabIndex = 23;
            this.lbl2.Text = "Minimum speech command acceptance level";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(340, 90);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(20, 16);
            this.lbl3.TabIndex = 24;
            this.lbl3.Text = "%";
            // 
            // nudConfidence
            // 
            this.nudConfidence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudConfidence.Location = new System.Drawing.Point(290, 88);
            this.nudConfidence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConfidence.Name = "nudConfidence";
            this.nudConfidence.Size = new System.Drawing.Size(50, 22);
            this.nudConfidence.TabIndex = 22;
            this.nudConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudConfidence.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // btnStartListening
            // 
            this.btnStartListening.BackColor = System.Drawing.Color.White;
            this.btnStartListening.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartListening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartListening.Location = new System.Drawing.Point(10, 121);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(90, 25);
            this.btnStartListening.TabIndex = 18;
            this.btnStartListening.Text = "START";
            this.btnStartListening.UseVisualStyleBackColor = false;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // btnStopListening
            // 
            this.btnStopListening.BackColor = System.Drawing.Color.White;
            this.btnStopListening.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopListening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopListening.Location = new System.Drawing.Point(120, 121);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(90, 25);
            this.btnStopListening.TabIndex = 20;
            this.btnStopListening.Text = "STOP";
            this.btnStopListening.UseVisualStyleBackColor = false;
            this.btnStopListening.Click += new System.EventHandler(this.btnStopListening_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Profiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Commands";
            // 
            // lvCommands
            // 
            this.lvCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCommands.FullRowSelect = true;
            this.lvCommands.GridLines = true;
            this.lvCommands.HideSelection = false;
            this.lvCommands.Location = new System.Drawing.Point(500, 40);
            this.lvCommands.MultiSelect = false;
            this.lvCommands.Name = "lvCommands";
            this.lvCommands.Size = new System.Drawing.Size(270, 380);
            this.lvCommands.TabIndex = 52;
            this.lvCommands.UseCompatibleStateImageBehavior = false;
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.BackColor = System.Drawing.Color.White;
            this.btnNewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProfile.Location = new System.Drawing.Point(300, 250);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(80, 25);
            this.btnNewProfile.TabIndex = 53;
            this.btnNewProfile.Text = "NEW";
            this.btnNewProfile.UseVisualStyleBackColor = false;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.BackColor = System.Drawing.Color.White;
            this.btnDeleteProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.Location = new System.Drawing.Point(400, 250);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteProfile.TabIndex = 54;
            this.btnDeleteProfile.Text = "DELETE";
            this.btnDeleteProfile.UseVisualStyleBackColor = false;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCommand.BackColor = System.Drawing.Color.White;
            this.btnAddCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommand.Location = new System.Drawing.Point(500, 430);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(70, 25);
            this.btnAddCommand.TabIndex = 55;
            this.btnAddCommand.Text = "ADD";
            this.btnAddCommand.UseVisualStyleBackColor = false;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // btnEditCommand
            // 
            this.btnEditCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCommand.BackColor = System.Drawing.Color.White;
            this.btnEditCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCommand.Location = new System.Drawing.Point(600, 430);
            this.btnEditCommand.Name = "btnEditCommand";
            this.btnEditCommand.Size = new System.Drawing.Size(70, 25);
            this.btnEditCommand.TabIndex = 56;
            this.btnEditCommand.Text = "EDIT";
            this.btnEditCommand.UseVisualStyleBackColor = false;
            this.btnEditCommand.Click += new System.EventHandler(this.btnEditCommand_Click);
            // 
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCommand.BackColor = System.Drawing.Color.White;
            this.btnDeleteCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCommand.Location = new System.Drawing.Point(700, 430);
            this.btnDeleteCommand.Name = "btnDeleteCommand";
            this.btnDeleteCommand.Size = new System.Drawing.Size(70, 25);
            this.btnDeleteCommand.TabIndex = 57;
            this.btnDeleteCommand.Text = "DELETE";
            this.btnDeleteCommand.UseVisualStyleBackColor = false;
            this.btnDeleteCommand.Click += new System.EventHandler(this.btnDeleteCommand_Click);
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.BackColor = System.Drawing.Color.White;
            this.btnLoadProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProfile.Location = new System.Drawing.Point(10, 250);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(80, 25);
            this.btnLoadProfile.TabIndex = 58;
            this.btnLoadProfile.Text = "LOAD";
            this.btnLoadProfile.UseVisualStyleBackColor = false;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // lvProfiles
            // 
            this.lvProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProfiles.FullRowSelect = true;
            this.lvProfiles.GridLines = true;
            this.lvProfiles.HideSelection = false;
            this.lvProfiles.Location = new System.Drawing.Point(10, 290);
            this.lvProfiles.MultiSelect = false;
            this.lvProfiles.Name = "lvProfiles";
            this.lvProfiles.Size = new System.Drawing.Size(470, 165);
            this.lvProfiles.TabIndex = 59;
            this.lvProfiles.UseCompatibleStateImageBehavior = false;
            // 
            // lblActiveProfile
            // 
            this.lblActiveProfile.AutoSize = true;
            this.lblActiveProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveProfile.Location = new System.Drawing.Point(10, 220);
            this.lblActiveProfile.Name = "lblActiveProfile";
            this.lblActiveProfile.Size = new System.Drawing.Size(140, 16);
            this.lblActiveProfile.TabIndex = 60;
            this.lblActiveProfile.Text = "The active profile is \"\".";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.White;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(700, 10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 25);
            this.btnHelp.TabIndex = 61;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(200, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenDictionary
            // 
            this.btnOpenDictionary.BackColor = System.Drawing.Color.White;
            this.btnOpenDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDictionary.Location = new System.Drawing.Point(230, 121);
            this.btnOpenDictionary.Name = "btnOpenDictionary";
            this.btnOpenDictionary.Size = new System.Drawing.Size(250, 25);
            this.btnOpenDictionary.TabIndex = 63;
            this.btnOpenDictionary.Text = "OPEN DICTIONARY EDITOR";
            this.btnOpenDictionary.UseVisualStyleBackColor = false;
            this.btnOpenDictionary.Click += new System.EventHandler(this.btnOpenDictionary_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btnOpenDictionary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblActiveProfile);
            this.Controls.Add(this.lvProfiles);
            this.Controls.Add(this.btnLoadProfile);
            this.Controls.Add(this.btnAddCommand);
            this.Controls.Add(this.btnEditCommand);
            this.Controls.Add(this.btnDeleteCommand);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvCommands);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMicLevel);
            this.Controls.Add(this.rtStatus);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.nudConfidence);
            this.Controls.Add(this.btnStartListening);
            this.Controls.Add(this.btnStopListening);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 2500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFTC - Windows Voice Commander";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbMicLevel;
        private System.Windows.Forms.RichTextBox rtStatus;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.NumericUpDown nudConfidence;
        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.Button btnStopListening;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvCommands;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.Button btnEditCommand;
        private System.Windows.Forms.Button btnDeleteCommand;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.ListView lvProfiles;
        private System.Windows.Forms.Label lblActiveProfile;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenDictionary;
    }
}