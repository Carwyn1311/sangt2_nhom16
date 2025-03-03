namespace demo_git
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
            label1 = new Label();
            textboxusername = new TextBox();
            label2 = new Label();
            textboxmatkhau = new TextBox();
            btnlogin = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 120);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            label1.Click += label1_Click;
            // 
            // textboxusername
            // 
            textboxusername.Location = new Point(193, 113);
            textboxusername.Name = "textboxusername";
            textboxusername.Size = new Size(125, 27);
            textboxusername.TabIndex = 1;
            textboxusername.TextChanged += textboxusername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 170);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "mật khẩu";
            label2.Click += label2_Click;
            // 
            // textboxmatkhau
            // 
            textboxmatkhau.Location = new Point(193, 167);
            textboxmatkhau.Name = "textboxmatkhau";
            textboxmatkhau.Size = new Size(125, 27);
            textboxmatkhau.TabIndex = 3;
            textboxmatkhau.TextChanged += textboxmatkhau_TextChanged;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(416, 135);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "đăng nhập";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 450);
            Controls.Add(btnlogin);
            Controls.Add(textboxmatkhau);
            Controls.Add(label2);
            Controls.Add(textboxusername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textboxusername;
        private Label label2;
        private TextBox textboxmatkhau;
        private Button btnlogin;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
