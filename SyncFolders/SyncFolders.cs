using System;
using System.IO;
using System.Windows.Forms;

namespace SyncFolders
{
    public partial class SyncFolders : Form
    {
        public SyncFolders()
        {
            InitializeComponent();
        }

        private void FromThisButton_Click(object sender, EventArgs e)
        {
            var result = DirectoryDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FromThisBox.Text = DirectoryDialog.SelectedPath;

                DirWatcher.Path = FromThisBox.Text;
                DirWatcher.EnableRaisingEvents = !string.IsNullOrWhiteSpace(DirWatcher.Path) && !string.IsNullOrWhiteSpace(FromThisBox.Text) && !string.IsNullOrWhiteSpace(ToThisBox.Text);
            }
        }

        private void ToThisButton_Click(object sender, EventArgs e)
        {
            var result = DirectoryDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ToThisBox.Text = DirectoryDialog.SelectedPath;
            }
        }

        private void DirWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (!EnabledCheckbox.Checked || string.IsNullOrWhiteSpace(DirWatcher.Path) || string.IsNullOrWhiteSpace(FromThisBox.Text) || string.IsNullOrWhiteSpace(ToThisBox.Text))
            {
                return;
            }

            if (Directory.GetFiles(ToThisBox.Text, "*.*", SearchOption.AllDirectories).Length == 0)
            {
                CopyFilesRecursively(FromThisBox.Text, ToThisBox.Text);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(e.FullPath) && File.Exists(e.FullPath) && File.Exists($"{ToThisBox.Text}\\{Path.GetFileName(e.FullPath)}"))
                {
                    File.WriteAllBytes($"{ToThisBox.Text}\\{Path.GetFileName(e.FullPath)}", File.ReadAllBytes(e.FullPath));
                }
            }
        }

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            foreach (var dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                if (!Directory.Exists(dirPath.Replace(sourcePath, targetPath)))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }
            }

            foreach (var newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                if (!File.Exists(newPath.Replace(sourcePath, targetPath)))
                {
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
            }
        }

        private void SyncFolders_Load(object sender, EventArgs e)
        {
            DirWatcher.Created += DirWatcher_Changed;
            DirWatcher.Deleted += DirWatcher_Changed;
            DirWatcher.Changed += DirWatcher_Changed;
            DirWatcher.Renamed += DirWatcher_Changed;

            DirWatcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime |
                                      NotifyFilters.DirectoryName | NotifyFilters.FileName |
                                      NotifyFilters.LastWrite | NotifyFilters.Size;
        }

        private void FromThisBox_TextChanged(object sender, EventArgs e)
        {
            DirWatcher.Path = FromThisBox.Text;
            DirWatcher.EnableRaisingEvents = !string.IsNullOrWhiteSpace(DirWatcher.Path) && !string.IsNullOrWhiteSpace(FromThisBox.Text) && !string.IsNullOrWhiteSpace(ToThisBox.Text);
        }
    }
}
