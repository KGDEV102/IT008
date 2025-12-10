namespace Bai_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinToolStripMenuItem = new ToolStripMenuItem();
            lưuNộiDungVănBanToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            điToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBoxFont = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripComboBox2 = new ToolStripComboBox();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStripComboBoxFont.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, điToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnToolStripMenuItem, mởTậpTinToolStripMenuItem, lưuNộiDungVănBanToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBảnToolStripMenuItem
            // 
            tạoVănBảnToolStripMenuItem.Image = (Image)resources.GetObject("tạoVănBảnToolStripMenuItem.Image");
            tạoVănBảnToolStripMenuItem.Name = "tạoVănBảnToolStripMenuItem";
            tạoVănBảnToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            tạoVănBảnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoVănBảnToolStripMenuItem.Size = new Size(293, 26);
            tạoVănBảnToolStripMenuItem.Text = "Tạo văn bản mới ";
            tạoVănBảnToolStripMenuItem.Click += tạoVănBảnToolStripMenuItem_Click;
            // 
            // mởTậpTinToolStripMenuItem
            // 
            mởTậpTinToolStripMenuItem.Image = (Image)resources.GetObject("mởTậpTinToolStripMenuItem.Image");
            mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            mởTậpTinToolStripMenuItem.Size = new Size(293, 26);
            mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            mởTậpTinToolStripMenuItem.Click += mởTậpTinToolStripMenuItem_Click;
            // 
            // lưuNộiDungVănBanToolStripMenuItem
            // 
            lưuNộiDungVănBanToolStripMenuItem.Image = (Image)resources.GetObject("lưuNộiDungVănBanToolStripMenuItem.Image");
            lưuNộiDungVănBanToolStripMenuItem.Name = "lưuNộiDungVănBanToolStripMenuItem";
            lưuNộiDungVănBanToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            lưuNộiDungVănBanToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            lưuNộiDungVănBanToolStripMenuItem.Size = new Size(293, 26);
            lưuNộiDungVănBanToolStripMenuItem.Text = "Lưu nội dung văn bản";
            lưuNộiDungVănBanToolStripMenuItem.Click += lưuNộiDungVănBanToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(293, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // điToolStripMenuItem
            // 
            điToolStripMenuItem.Name = "điToolStripMenuItem";
            điToolStripMenuItem.Size = new Size(92, 24);
            điToolStripMenuItem.Text = "Định dạng";
            điToolStripMenuItem.Click += điToolStripMenuItem_Click;
            // 
            // toolStripComboBoxFont
            // 
            toolStripComboBoxFont.ImageScalingSize = new Size(20, 20);
            toolStripComboBoxFont.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripComboBox1, toolStripComboBox2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStripComboBoxFont.Location = new Point(0, 28);
            toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            toolStripComboBoxFont.Size = new Size(800, 28);
            toolStripComboBoxFont.TabIndex = 1;
            toolStripComboBoxFont.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 25);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 25);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            toolStripComboBox1.TextChanged += toolStripComboBox1_TextChanged;
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            toolStripComboBox2.SelectedIndexChanged += toolStripComboBox2_SelectedIndexChanged;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 25);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 25);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 25);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 56);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 394);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStripComboBoxFont);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripComboBoxFont.ResumeLayout(false);
            toolStripComboBoxFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem điToolStripMenuItem;
        private ToolStripMenuItem tạoVănBảnToolStripMenuItem;
        private ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private ToolStripMenuItem lưuNộiDungVănBanToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStrip toolStripComboBoxFont;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private RichTextBox richTextBox1;
    }
}
