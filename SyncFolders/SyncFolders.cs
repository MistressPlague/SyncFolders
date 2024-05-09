using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Libraries;

namespace SyncFolders
{
    public partial class SyncFolders : Form
    {
        public SyncFolders()
        {
            InitializeComponent();
            
            Instance = this;
        }

        public class Configuration
        {
            public bool Enabled
            { 
                get => Instance.EnabledCheckbox.Checked;
                set => Instance.EnabledCheckbox.Checked = value;
            }

            public bool DeleteFilter
            {
                get => Instance.DeleteFilterCheckBox.Checked;
                set => Instance.DeleteFilterCheckBox.Checked = value;
            }

            public string From
            {
                get => Instance.FromThisBox.Text;
                set => Instance.FromThisBox.Text = value;
            }

            public string[] To
            {
                get => Instance.ToTheseListBox.Items.ToArray();
                set
                {
                    foreach (var item in value)
                    {
                        if (!Instance.ToTheseListBox.Items.Contains(item))
                        {
                            Instance.ToTheseListBox.Items.Add(item);
                        }
                    }
                }
            }
        }

        public static ConfigLib<Configuration> Config;

        private void FromThisButton_Click(object sender, EventArgs e)
        {
            var result = DirectoryDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FromThisBox.Text = DirectoryDialog.SelectedPath;

                DirWatcher.Path = FromThisBox.Text;
                DirWatcher.EnableRaisingEvents = !string.IsNullOrWhiteSpace(DirWatcher.Path) && !string.IsNullOrWhiteSpace(FromThisBox.Text);
            }
        }

        private void DirWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (!EnabledCheckbox.Checked || string.IsNullOrWhiteSpace(DirWatcher.Path) || string.IsNullOrWhiteSpace(FromThisBox.Text) || ToTheseListBox.Items.Count == 0)
            {
                return;
            }

            DoSync(e.FullPath);
        }

        private void DoSync(string pathOfChangedFile = "")
        {
            foreach (var dir in Config.InternalConfig.To)
            {
                if (Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Length == 0)
                {
                    CopyFilesRecursively(FromThisBox.Text, dir);
                }
                else if (!string.IsNullOrEmpty(pathOfChangedFile))
                {
                    if (File.Exists(pathOfChangedFile) && File.Exists($"{dir}\\{Path.GetFileName(pathOfChangedFile)}"))
                    {
                        File.WriteAllBytes($"{dir}\\{Path.GetFileName(pathOfChangedFile)}", File.ReadAllBytes(pathOfChangedFile));
                    }
                }
                else
                {
                    CopyFilesRecursively(FromThisBox.Text, dir);
                }
                
                if (Config.InternalConfig.DeleteFilter)
                {
                    foreach (var file in Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Where(o => !File.Exists($"{FromThisBox.Text}\\{Path.GetFileName(o)}")))
                    {
                        File.Delete(file);
                    }
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
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        public static SyncFolders Instance;

        private void SyncFolders_Load(object sender, EventArgs e)
        {
            DirWatcher.EnableRaisingEvents = false;
            DirWatcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime |
                                      NotifyFilters.DirectoryName | NotifyFilters.FileName |
                                      NotifyFilters.LastWrite | NotifyFilters.Size;

            DirWatcher.Created += DirWatcher_Changed;
            DirWatcher.Deleted += DirWatcher_Changed;
            DirWatcher.Changed += DirWatcher_Changed;
            DirWatcher.Renamed += DirWatcher_Changed;

            Config = new ConfigLib<Configuration>($"{Environment.CurrentDirectory}\\{Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)}.json");

            if (Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location) != "SyncFolders")
                Text = "SyncFolders - " + Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location);
        }

        private void FromThisBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DirWatcher.Path = FromThisBox.Text;
                DirWatcher.EnableRaisingEvents = !string.IsNullOrWhiteSpace(DirWatcher.Path) && !string.IsNullOrWhiteSpace(FromThisBox.Text);
            }
            catch
            {
                
            }
        }

        private void SyncAllButton_Click(object sender, EventArgs e)
        {
            DoSync();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var result = DirectoryDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ToTheseListBox.Items.Add(DirectoryDialog.SelectedPath);
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (ToTheseListBox.SelectedIndex == -1)
            {
                return;
            }
            
            ToTheseListBox.Items.RemoveAt(ToTheseListBox.SelectedIndex);
        }
    }

    public static class Extensions
    {
        // create ToArray for ObjectCollection
        public static string[] ToArray(this ListBox.ObjectCollection collection)
        {
            var array = new string[collection.Count];
            collection.CopyTo(array, 0);
            return array;
        }
    }
}
