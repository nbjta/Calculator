namespace Calculator
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
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            buttonEqual = new Button();
            textBoxResult = new TextBox();
            textBoxFormula = new TextBox();
            SuspendLayout();
            // 
            // buttonOne
            // 
            buttonOne.Location = new Point(60, 369);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(112, 34);
            buttonOne.TabIndex = 0;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Location = new Point(189, 369);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(112, 34);
            buttonTwo.TabIndex = 1;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonThree
            // 
            buttonThree.Location = new Point(319, 369);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(112, 34);
            buttonThree.TabIndex = 2;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonThree_Click;
            // 
            // button4
            // 
            button4.Location = new Point(60, 314);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(189, 314);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(319, 314);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(60, 256);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(189, 256);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(319, 256);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(451, 256);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(112, 34);
            buttonMinus.TabIndex = 9;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(451, 314);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(112, 34);
            buttonPlus.TabIndex = 10;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(451, 369);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(112, 34);
            buttonEqual.TabIndex = 11;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(60, 151);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(503, 31);
            textBoxResult.TabIndex = 12;
            // 
            // textBoxFormula
            // 
            textBoxFormula.Location = new Point(60, 92);
            textBoxFormula.Name = "textBoxFormula";
            textBoxFormula.Size = new Size(503, 31);
            textBoxFormula.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 450);
            Controls.Add(textBoxFormula);
            Controls.Add(textBoxResult);
            Controls.Add(buttonEqual);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonMinus;
        private Button buttonPlus;
        private Button buttonEqual;
        private TextBox textBoxResult;
        private TextBox textBoxFormula;
    }
}
