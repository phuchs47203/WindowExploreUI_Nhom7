using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace WindowExplorerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedPath = e.Node.FullPath;
            showList_File_Folder(selectedPath, e.Node);
        }
        private void showList_File_Folder(string strPath, TreeNode node_parent)
        {
            try
            {
                node_parent.Nodes.Clear();
                if (Directory.Exists(strPath))
                {
                    string[] directories = Directory.GetDirectories(strPath);
                    foreach (string dir in directories)
                    {
                        TreeNode treeNode = new TreeNode(Path.GetFileName(dir));
                        node_parent.Nodes.Add(treeNode);
                    }

                    string[] listFileTxt = Directory.GetFiles(strPath, "*.txt");
                    foreach (string file in listFileTxt)
                    {
                        TreeNode treeNode = new TreeNode(Path.GetFileName(file));
                        node_parent.Nodes.Add(treeNode);
                    }
                    string[] listFilePNG = Directory.GetFiles(strPath, "*.png");
                    foreach (string file in listFilePNG)
                    {
                        TreeNode treeNode = new TreeNode(Path.GetFileName(file));
                        node_parent.Nodes.Add(treeNode);
                    }
                    string[] listFileJPG = Directory.GetFiles(strPath, "*.jpg");
                    foreach (string file in listFileJPG)
                    {
                        TreeNode treeNode = new TreeNode(Path.GetFileName(file));
                        node_parent.Nodes.Add(treeNode);
                    }
                }
                else
                {
                    if (strPath.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                        || strPath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            Image image = Image.FromFile(strPath);
                            Clipboard.SetImage(image);
                            richTextBox1.Text = "";
                            richTextBox1.Paste();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: ", ex.Message);
                        }
                    }
                    if (strPath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {

                            richTextBox1.Text = string.Empty;
                            richTextBox1.Text = File.ReadAllText(strPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: ", ex.Message);
                        }
                    }
                }

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access Denied");
            }
        }
    }
}
