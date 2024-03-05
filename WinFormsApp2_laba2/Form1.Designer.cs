namespace WinFormsApp2_laba2
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
            firstword = new Label();
            secondword = new Label();
            button1 = new Button();
            first = new TextBox();
            second = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // firstword
            // 
            firstword.AutoSize = true;
            firstword.Location = new Point(17, 56);
            firstword.Name = "firstword";
            firstword.Size = new Size(168, 20);
            firstword.TabIndex = 0;
            firstword.Text = "Введите первое слово:";
            firstword.Click += label1_Click;
            // 
            // secondword
            // 
            secondword.AutoSize = true;
            secondword.Location = new Point(17, 107);
            secondword.Name = "secondword";
            secondword.Size = new Size(166, 20);
            secondword.TabIndex = 1;
            secondword.Text = "Ввелите второе слово:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 156);
            button1.Name = "button1";
            button1.Size = new Size(343, 35);
            button1.TabIndex = 2;
            button1.Text = "Выполнить задание";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyUp += button2_KeyUp;
            // 
            // first
            // 
            first.Location = new Point(198, 56);
            first.Name = "first";
            first.Size = new Size(157, 27);
            first.TabIndex = 0;
            first.KeyUp += button2_KeyUp;
            // 
            // second
            // 
            second.Location = new Point(198, 107);
            second.Name = "second";
            second.Size = new Size(157, 27);
            second.TabIndex = 1;
            second.KeyUp += button2_KeyUp;
            // 
            // button2
            // 
            button2.Location = new Point(17, 12);
            button2.Name = "button2";
            button2.Size = new Size(338, 29);
            button2.TabIndex = 3;
            button2.Text = "Задание";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.KeyUp += button2_KeyUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 211);
            Controls.Add(button2);
            Controls.Add(second);
            Controls.Add(first);
            Controls.Add(button1);
            Controls.Add(secondword);
            Controls.Add(firstword);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstword;
        private Label secondword;
        private Button button1;
        private TextBox first;
        private TextBox second;
        private Button button2;
    }
}
