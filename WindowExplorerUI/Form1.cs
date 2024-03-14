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
        public struct FileIcon
        {
            public IntPtr icon;
            public IntPtr icon_;
            public uint attrub;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string nameIcon;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string tpName;
        }
        FileIcon fileIcon = new FileIcon();
        public IntPtr file_img;
        public static extern IntPtr GetFileInfor(string pathStr, uint fileatt, ref FileIcon psfi, uint sizefl, uint flag);
        private void button1_Click(object sender, EventArgs e)
        {
            string pathString = getPathFromTxt();
            if(pathString !=  null )
            {
                Execute_Find(pathString);
            }
        }

        public void Execute_Find(string pathString)
        {
            try
            {
                displayResult.Items.Clear();
                DirectoryInfo directory = new DirectoryInfo(pathString);
                foreach(DirectoryInfo directoryInfo2 in directory.GetDirectories())
                {
                    ListViewItem list = new ListViewItem();
                    list.Text = directoryInfo2.Name;
                    list.ImageIndex = 1;
                    displayResult.Items.Add(list);
                }
                foreach(FileInfo directoryInfo2 in directory.GetFiles())
                {
                    ListViewItem list = new ListViewItem();
                    list.Text = directoryInfo2.Name;
                    file_img = GetFileInfor(directory.FullName, 0, ref fileIcon, (uint)Marshal.SizeOf(fileIcon), 0x100 | 0x1);
                    if(file_img != IntPtr.Zero)
                    {
                        Icon fileIcon_ = Icon.FromHandle(fileIcon.icon);
                        imageList1.Images.Add(fileIcon_);
                        list.ImageIndex = imageList1.Images.Count - 1;
                    }
                    displayResult.Items.Add(list);
                }
                txtPath.Text = "";
                txtPath.Controls.Clear();           
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /*foreach (string str in pathString.Split('\\')
                {
                    if(str != "")
                    {
                        
                    }
                }*/
        private string getPathFromTxt()
        {
            string path = "";
            if(txtPath.Text.Trim() != "")
            {
                path = txtPath.Text.Trim();
            }
            /*else
            {
                MessageBox.Show("Please add a path", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }*/
            return path;
        }
    }
}
