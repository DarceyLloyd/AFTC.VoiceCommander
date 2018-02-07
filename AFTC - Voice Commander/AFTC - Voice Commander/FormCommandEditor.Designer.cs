namespace AFTC___Voice_Commander
{
    partial class FormCommandEditor
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
            this.lvCommandSequence = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbSpeech = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tbCommandDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCommandToSequence = new System.Windows.Forms.Button();
            this.lvCommands = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCommandSequence
            // 
            this.lvCommandSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCommandSequence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCommandSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCommandSequence.FullRowSelect = true;
            this.lvCommandSequence.GridLines = true;
            this.lvCommandSequence.HideSelection = false;
            this.lvCommandSequence.Location = new System.Drawing.Point(270, 120);
            this.lvCommandSequence.MultiSelect = false;
            this.lvCommandSequence.Name = "lvCommandSequence";
            this.lvCommandSequence.Size = new System.Drawing.Size(420, 300);
            this.lvCommandSequence.TabIndex = 53;
            this.lvCommandSequence.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Command editor";
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.BackColor = System.Drawing.Color.White;
            this.btnMoveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Location = new System.Drawing.Point(700, 120);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(70, 25);
            this.btnMoveUp.TabIndex = 56;
            this.btnMoveUp.Text = "UP";
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.BackColor = System.Drawing.Color.White;
            this.btnMoveDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Location = new System.Drawing.Point(700, 160);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(70, 25);
            this.btnMoveDown.TabIndex = 57;
            this.btnMoveDown.Text = "DOWN";
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(700, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 25);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(700, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 25);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSpeech
            // 
            this.tbSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpeech.Location = new System.Drawing.Point(140, 42);
            this.tbSpeech.MaxLength = 400;
            this.tbSpeech.Name = "tbSpeech";
            this.tbSpeech.Size = new System.Drawing.Size(630, 21);
            this.tbSpeech.TabIndex = 67;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(10, 43);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(118, 16);
            this.lbl2.TabIndex = 68;
            this.lbl2.Text = "Speech command";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Delay between commands";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(496, 434);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(60, 16);
            this.lbl3.TabIndex = 71;
            this.lbl3.Text = "seconds";
            // 
            // tbCommandDelay
            // 
            this.tbCommandDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommandDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommandDelay.Location = new System.Drawing.Point(440, 431);
            this.tbCommandDelay.MaxLength = 5;
            this.tbCommandDelay.Name = "tbCommandDelay";
            this.tbCommandDelay.Size = new System.Drawing.Size(50, 21);
            this.tbCommandDelay.TabIndex = 72;
            this.tbCommandDelay.Text = "0.2";
            this.tbCommandDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCommandDelay_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Available commands";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Command sequence";
            // 
            // btnAddCommandToSequence
            // 
            this.btnAddCommandToSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCommandToSequence.BackColor = System.Drawing.Color.White;
            this.btnAddCommandToSequence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCommandToSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommandToSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommandToSequence.Location = new System.Drawing.Point(10, 430);
            this.btnAddCommandToSequence.Name = "btnAddCommandToSequence";
            this.btnAddCommandToSequence.Size = new System.Drawing.Size(240, 25);
            this.btnAddCommandToSequence.TabIndex = 54;
            this.btnAddCommandToSequence.Text = "ADD COMMAND TO SEQUENCE";
            this.btnAddCommandToSequence.UseVisualStyleBackColor = false;
            this.btnAddCommandToSequence.Click += new System.EventHandler(this.btnInsertIntoClipboard_Click);
            // 
            // lvCommands
            // 
            this.lvCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCommands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCommands.FullRowSelect = true;
            this.lvCommands.GridLines = true;
            this.lvCommands.HideSelection = false;
            this.lvCommands.Location = new System.Drawing.Point(10, 120);
            this.lvCommands.MultiSelect = false;
            this.lvCommands.Name = "lvCommands";
            this.lvCommands.Size = new System.Drawing.Size(240, 300);
            this.lvCommands.TabIndex = 76;
            this.lvCommands.UseCompatibleStateImageBehavior = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(700, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 25);
            this.btnEdit.TabIndex = 77;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormCommandEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvCommands);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCommandDelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tbSpeech);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCommandToSequence);
            this.Controls.Add(this.lvCommandSequence);
            this.MaximumSize = new System.Drawing.Size(800, 2500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormCommandEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFTC - Windows Voice Commander";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCommandEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormCommandEditor_Load);
            this.Shown += new System.EventHandler(this.FormCommandEditor_Shown);
            this.Resize += new System.EventHandler(this.FormCommandEditor_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCommandSequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbSpeech;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tbCommandDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCommandToSequence;
        private System.Windows.Forms.ListView lvCommands;
        private System.Windows.Forms.Button btnEdit;
    }
}