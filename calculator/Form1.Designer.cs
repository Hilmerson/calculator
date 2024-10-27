namespace calculator
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
            textBox1 = new TextBox();
            lblResult = new Label();
            button1 = new Button();
            btnDivide = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 62);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(105, 196);
            button1.Name = "button1";
            button1.Size = new Size(38, 23);
            button1.TabIndex = 3;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnEquals;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(105, 80);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(38, 23);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperatorHandler;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(105, 167);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(38, 23);
            btnPlus.TabIndex = 5;
            btnPlus.Tag = "";
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnOperatorHandler;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(105, 138);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(38, 23);
            btnMinus.TabIndex = 6;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperatorHandler;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(105, 109);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(38, 23);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperatorHandler;
            // 
            // button2
            // 
            button2.Location = new Point(43, 108);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 8;
            button2.Tag = "8";
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNumberHandler;
            // 
            // button3
            // 
            button3.Location = new Point(74, 166);
            button3.Name = "button3";
            button3.Size = new Size(25, 23);
            button3.TabIndex = 9;
            button3.Tag = "3";
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnNumberHandler;
            // 
            // button4
            // 
            button4.Location = new Point(12, 137);
            button4.Name = "button4";
            button4.Size = new Size(25, 23);
            button4.TabIndex = 10;
            button4.Tag = "4";
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNumberHandler;
            // 
            // button5
            // 
            button5.Location = new Point(74, 195);
            button5.Name = "button5";
            button5.Size = new Size(25, 23);
            button5.TabIndex = 11;
            button5.Tag = ".";
            button5.Text = ".";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnNumberHandler;
            // 
            // button6
            // 
            button6.Location = new Point(43, 195);
            button6.Name = "button6";
            button6.Size = new Size(25, 23);
            button6.TabIndex = 12;
            button6.Tag = "0";
            button6.Text = "0";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnNumberHandler;
            // 
            // button7
            // 
            button7.Location = new Point(74, 108);
            button7.Name = "button7";
            button7.Size = new Size(25, 23);
            button7.TabIndex = 13;
            button7.Tag = "9";
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnNumberHandler;
            // 
            // button8
            // 
            button8.Location = new Point(12, 108);
            button8.Name = "button8";
            button8.Size = new Size(25, 23);
            button8.TabIndex = 14;
            button8.Tag = "7";
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnNumberHandler;
            // 
            // button9
            // 
            button9.Location = new Point(74, 137);
            button9.Name = "button9";
            button9.Size = new Size(25, 23);
            button9.TabIndex = 15;
            button9.Tag = "6";
            button9.Text = "6";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnNumberHandler;
            // 
            // button10
            // 
            button10.Location = new Point(43, 137);
            button10.Name = "button10";
            button10.Size = new Size(25, 23);
            button10.TabIndex = 16;
            button10.Tag = "5";
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnNumberHandler;
            // 
            // button11
            // 
            button11.Location = new Point(43, 166);
            button11.Name = "button11";
            button11.Size = new Size(25, 23);
            button11.TabIndex = 17;
            button11.Tag = "2";
            button11.Text = "2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnNumberHandler;
            // 
            // button12
            // 
            button12.Location = new Point(12, 166);
            button12.Name = "button12";
            button12.Size = new Size(25, 23);
            button12.TabIndex = 18;
            button12.Tag = "1";
            button12.Text = "1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnNumberHandler;
            // 
            // button13
            // 
            button13.Location = new Point(61, 79);
            button13.Name = "button13";
            button13.Size = new Size(38, 23);
            button13.TabIndex = 19;
            button13.Text = "C";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnClear;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(167, 243);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnDivide);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblResult;
        private Button button1;
        private Button btnDivide;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}
