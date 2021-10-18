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
            this.ToThisButton = new System.Windows.Forms.Button();
            this.ToThisBox = new System.Windows.Forms.TextBox();
            this.DirWatcher = new System.IO.FileSystemWatcher();
            this.DirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.EnabledCheckbox = new System.Windows.Forms.CheckBox();
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
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To This:";
            // 
            // ToThisButton
            // 
            this.ToThisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToThisButton.Location = new System.Drawing.Point(243, 67);
            this.ToThisButton.Name = "ToThisButton";
            this.ToThisButton.Size = new System.Drawing.Size(75, 23);
            this.ToThisButton.TabIndex = 4;
            this.ToThisButton.Text = "Browse";
            this.ToThisButton.UseVisualStyleBackColor = true;
            this.ToThisButton.Click += new System.EventHandler(this.ToThisButton_Click);
            // 
            // ToThisBox
            // 
            this.ToThisBox.BackColor = System.Drawing.Color.Black;
            this.ToThisBox.ForeColor = System.Drawing.Color.Magenta;
            this.ToThisBox.Location = new System.Drawing.Point(101, 69);
            this.ToThisBox.Name = "ToThisBox";
            this.ToThisBox.Size = new System.Drawing.Size(136, 20);
            this.ToThisBox.TabIndex = 3;
            // 
            // DirWatcher
            // 
            this.DirWatcher.IncludeSubdirectories = true;
            this.DirWatcher.SynchronizingObject = this;
            this.DirWatcher.Changed += new System.IO.FileSystemEventHandler(this.DirWatcher_Changed);
            // 
            // EnabledCheckbox
            // 
            this.EnabledCheckbox.AutoSize = true;
            this.EnabledCheckbox.Location = new System.Drawing.Point(15, 12);
            this.EnabledCheckbox.Name = "EnabledCheckbox";
            this.EnabledCheckbox.Size = new System.Drawing.Size(65, 17);
            this.EnabledCheckbox.TabIndex = 6;
            this.EnabledCheckbox.Text = "Enabled";
            this.EnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // SyncFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(334, 105);
            this.Controls.Add(this.EnabledCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToThisButton);
            this.Controls.Add(this.ToThisBox);
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

        #endregion

        private System.Windows.Forms.TextBox FromThisBox;
        private System.Windows.Forms.Button FromThisButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToThisButton;
        private System.Windows.Forms.TextBox ToThisBox;
        private System.IO.FileSystemWatcher DirWatcher;
        private System.Windows.Forms.FolderBrowserDialog DirectoryDialog;
        private System.Windows.Forms.CheckBox EnabledCheckbox;
    }
}

