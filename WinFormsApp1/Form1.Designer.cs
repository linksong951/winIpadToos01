using System.Threading;

namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(145, 59);
            button1.TabIndex = 0;
            button1.Text = "截图翻译";
            button1.UseVisualStyleBackColor = true;
            button1.Click += WinKeyCtrl_Alt_D;
            // 
            // button2
            // 
            button2.Location = new Point(12, 77);
            button2.Name = "button2";
            button2.Size = new Size(145, 59);
            button2.TabIndex = 1;
            button2.Text = "win默认截屏";
            button2.UseVisualStyleBackColor = true;
            button2.Click += WinKeyShift_Win_S;
            // 
            // button3
            // 
            button3.Location = new Point(12, 207);
            button3.Name = "button3";
            button3.Size = new Size(145, 59);
            button3.TabIndex = 2;
            button3.Text = "静音";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Win_Mute;
            // 
            // button5
            // 
            button5.Location = new Point(12, 142);
            button5.Name = "button5";
            button5.Size = new Size(145, 59);
            button5.TabIndex = 4;
            button5.Text = "返回桌面";
            button5.UseVisualStyleBackColor = true;
            button5.Click += WinKeyWin_D;
            // 
            // button6
            // 
            button6.Location = new Point(12, 272);
            button6.Name = "button6";
            button6.Size = new Size(145, 61);
            button6.TabIndex = 5;
            button6.Text = "Win搜索";
            button6.UseVisualStyleBackColor = true;
            button6.Click += WinKeyWIn_S;
            // 
            // button4
            // 
            button4.Location = new Point(12, 339);
            button4.Name = "button4";
            button4.Size = new Size(145, 59);
            button4.TabIndex = 6;
            button4.Text = "关闭";
            button4.UseVisualStyleBackColor = true;
            button4.Click += WinKeyAlt_F4;
            // 
            // button7
            // 
            button7.Location = new Point(12, 404);
            button7.Name = "button7";
            button7.Size = new Size(145, 59);
            button7.TabIndex = 7;
            button7.Text = "最小化";
            button7.UseVisualStyleBackColor = true;
            button7.Click += MinimizedAction;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(169, 496);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button4;
        private Button button7;
    }
}
