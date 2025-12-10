namespace Bai_5
{
    partial class formAdd
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
            label1 = new Label();
            label2 = new Label();
            mssv_text = new TextBox();
            name_text = new TextBox();
            label3 = new Label();
            khoa_text = new ComboBox();
            dtb_text = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 81);
            label1.Name = "label1";
            label1.Size = new Size(182, 50);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 151);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên";
            label2.Click += label2_Click;
            // 
            // mssv_text
            // 
            mssv_text.Location = new Point(358, 87);
            mssv_text.Name = "mssv_text";
            mssv_text.Size = new Size(278, 27);
            mssv_text.TabIndex = 2;
            // 
            // name_text
            // 
            name_text.Location = new Point(358, 151);
            name_text.Name = "name_text";
            name_text.Size = new Size(278, 27);
            name_text.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 218);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 4;
            label3.Text = "Khoa";
            label3.Click += label3_Click;
            // 
            // khoa_text
            // 
            khoa_text.FormattingEnabled = true;
            khoa_text.Location = new Point(358, 222);
            khoa_text.Name = "khoa_text";
            khoa_text.Size = new Size(278, 28);
            khoa_text.TabIndex = 5;
            khoa_text.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dtb_text
            // 
            dtb_text.Location = new Point(358, 286);
            dtb_text.Name = "dtb_text";
            dtb_text.Size = new Size(183, 27);
            dtb_text.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(153, 282);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 6;
            label4.Text = "Điểm trung bình";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(436, 351);
            button1.Name = "button1";
            button1.Size = new Size(133, 38);
            button1.TabIndex = 8;
            button1.Text = "Thêm mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(602, 351);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 9;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // formAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtb_text);
            Controls.Add(label4);
            Controls.Add(khoa_text);
            Controls.Add(label3);
            Controls.Add(name_text);
            Controls.Add(mssv_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAdd";
            Text = "formAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox mssv_text;
        private TextBox name_text;
        private Label label3;
        private ComboBox khoa_text;
        private TextBox dtb_text;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}