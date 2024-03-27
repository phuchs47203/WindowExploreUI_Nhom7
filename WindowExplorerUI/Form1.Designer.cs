namespace WindowExplorerUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("D:\\");
            TreeNode treeNode2 = new TreeNode("C:\\");
            imageList1 = new ImageList(components);
            treeView1 = new TreeView();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeNode1.Name = "D_disk";
            treeNode1.Text = "D:\\";
            treeNode2.Name = "C_disk";
            treeNode2.Text = "C:\\";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            treeView1.Size = new Size(163, 488);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(181, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(732, 488);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 512);
            Controls.Add(richTextBox1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Window Explorer UI Group 7";
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TreeView treeView1;
        private RichTextBox richTextBox1;
    }
}
