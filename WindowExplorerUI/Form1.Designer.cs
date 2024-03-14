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
            label1 = new Label();
            txtPath = new TextBox();
            button1 = new Button();
            displayResult = new ListView();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 0;
            label1.Text = "Path";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(91, 12);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(581, 23);
            txtPath.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(700, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // displayResult
            // 
            displayResult.Location = new Point(34, 52);
            displayResult.Name = "displayResult";
            displayResult.Size = new Size(1201, 467);
            displayResult.TabIndex = 3;
            displayResult.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 531);
            Controls.Add(displayResult);
            Controls.Add(button1);
            Controls.Add(txtPath);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Window Explorer UI Group 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPath;
        private Button button1;
        private ListView displayResult;
        private ImageList imageList1;
    }
}
