namespace SyncFolders
{
    partial class SyncFolders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncFolders));
            this.FromThisBox = new System.Windows.Forms.TextBox();
            this.FromThisButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DirWatcher = new System.IO.FileSystemWatcher();
            this.DirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.EnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.SyncAllButton = new System.Windows.Forms.Button();
            this.DeleteFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.ToTheseListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DirWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // FromThisBox
            // 
            this.FromThisBox.BackColor = System.Drawing.Color.Black;
            this.FromThisBox.ForeColor = System.Drawing.Color.Magenta;
            this.FromThisBox.Location = new System.Drawing.Point(101, 39);
            this.FromThisBox.Name = "FromThisBox";
            this.FromThisBox.Size = new System.Drawing.Size(136, 20);
            this.FromThisBox.TabIndex = 0;
            this.FromThisBox.TextChanged += new System.EventHandler(this.FromThisBox_TextChanged);
            // 
            // FromThisButton
            // 
            this.FromThisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FromThisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromThisButton.Location = new System.Drawing.Point(243, 38);
            this.FromThisButton.Name = "FromThisButton";
            this.FromThisButton.Size = new System.Drawing.Size(75, 23);
            this.FromThisButton.TabIndex = 1;
            this.FromThisButton.Text = "Browse";
            this.FromThisButton.UseVisualStyleBackColor = true;
            this.FromThisButton.Click += new System.EventHandler(this.FromThisButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sync From This:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To These";
            // 
            // DirWatcher
            // 
            this.DirWatcher.EnableRaisingEvents = true;
            this.DirWatcher.IncludeSubdirectories = true;
            this.DirWatcher.SynchronizingObject = this;
            this.DirWatcher.Changed += new System.IO.FileSystemEventHandler(this.DirWatcher_Changed);
            // 
            // EnabledCheckbox
            // 
            this.EnabledCheckbox.AutoSize = true;
            this.EnabledCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnabledCheckbox.Location = new System.Drawing.Point(15, 12);
            this.EnabledCheckbox.Name = "EnabledCheckbox";
            this.EnabledCheckbox.Size = new System.Drawing.Size(65, 17);
            this.EnabledCheckbox.TabIndex = 6;
            this.EnabledCheckbox.Text = "Enabled";
            this.EnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // SyncAllButton
            // 
            this.SyncAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SyncAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncAllButton.Location = new System.Drawing.Point(243, 12);
            this.SyncAllButton.Name = "SyncAllButton";
            this.SyncAllButton.Size = new System.Drawing.Size(75, 23);
            this.SyncAllButton.TabIndex = 7;
            this.SyncAllButton.Text = "Sync All";
            this.SyncAllButton.UseVisualStyleBackColor = true;
            this.SyncAllButton.Click += new System.EventHandler(this.SyncAllButton_Click);
            // 
            // DeleteFilterCheckBox
            // 
            this.DeleteFilterCheckBox.AutoSize = true;
            this.DeleteFilterCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFilterCheckBox.Location = new System.Drawing.Point(86, 12);
            this.DeleteFilterCheckBox.Name = "DeleteFilterCheckBox";
            this.DeleteFilterCheckBox.Size = new System.Drawing.Size(139, 17);
            this.DeleteFilterCheckBox.TabIndex = 8;
            this.DeleteFilterCheckBox.Text = "Delete Files Not In From";
            this.DeleteFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToTheseListBox
            // 
            this.ToTheseListBox.BackColor = System.Drawing.Color.Black;
            this.ToTheseListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToTheseListBox.ForeColor = System.Drawing.Color.Magenta;
            this.ToTheseListBox.FormattingEnabled = true;
            this.ToTheseListBox.Location = new System.Drawing.Point(15, 100);
            this.ToTheseListBox.Name = "ToTheseListBox";
            this.ToTheseListBox.Size = new System.Drawing.Size(303, 171);
            this.ToTheseListBox.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(298, 77);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(20, 20);
            this.AddButton.TabIndex = 10;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinusButton.BackgroundImage")));
            this.MinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusButton.FlatAppearance.BorderSize = 0;
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Location = new System.Drawing.Point(272, 77);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(20, 20);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // SyncFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(334, 288);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ToTheseListBox);
            this.Controls.Add(this.DeleteFilterCheckBox);
            this.Controls.Add(this.SyncAllButton);
            this.Controls.Add(this.EnabledCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromThisButton);
            this.Controls.Add(this.FromThisBox);
            this.ForeColor = System.Drawing.Color.Magenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SyncFolders";
            this.Text = "SyncFolders";
            this.Load += new System.EventHandler(this.SyncFolders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DirWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button MinusButton;

        private System.Windows.Forms.ListBox ToTheseListBox;
        private System.Windows.Forms.Button AddButton;

        #endregion

        private System.Windows.Forms.TextBox FromThisBox;
        private System.Windows.Forms.Button FromThisButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher DirWatcher;
        private System.Windows.Forms.FolderBrowserDialog DirectoryDialog;
        private System.Windows.Forms.CheckBox EnabledCheckbox;
        private System.Windows.Forms.Button SyncAllButton;
        private System.Windows.Forms.CheckBox DeleteFilterCheckBox;
    }
}

