﻿using System.Security.Cryptography.X509Certificates;

namespace CalculatorDelegate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.present = new System.Windows.Forms.Label();
            this.past = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.present);
            this.panel1.Controls.Add(this.past);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 139);
            this.panel1.TabIndex = 0;
            // 
            // present
            // 
            this.present.AutoSize = true;
            this.present.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.present.ForeColor = System.Drawing.Color.White;
            this.present.Location = new System.Drawing.Point(16, 43);
            this.present.MaximumSize = new System.Drawing.Size(700, 86);
            this.present.MinimumSize = new System.Drawing.Size(700, 86);
            this.present.Name = "present";
            this.present.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.present.Size = new System.Drawing.Size(700, 86);
            this.present.TabIndex = 0;
            // 
            // past
            // 
            this.past.AutoSize = true;
            this.past.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.past.ForeColor = System.Drawing.Color.White;
            this.past.Location = new System.Drawing.Point(16, 11);
            this.past.MaximumSize = new System.Drawing.Size(700, 32);
            this.past.MinimumSize = new System.Drawing.Size(700, 32);
            this.past.Name = "past";
            this.past.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.past.Size = new System.Drawing.Size(700, 32);
            this.past.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(386, 534);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 138);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1.Location = new System.Drawing.Point(24, 534);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(161, 138);
            this.num1.TabIndex = 4;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2.Location = new System.Drawing.Point(203, 534);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(161, 138);
            this.num2.TabIndex = 5;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num8.Location = new System.Drawing.Point(203, 246);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(161, 138);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num7.Location = new System.Drawing.Point(24, 246);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(161, 138);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num9.Location = new System.Drawing.Point(386, 246);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(161, 138);
            this.num9.TabIndex = 6;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num5.Location = new System.Drawing.Point(203, 390);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(161, 138);
            this.num5.TabIndex = 11;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num4.Location = new System.Drawing.Point(24, 390);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(161, 138);
            this.num4.TabIndex = 10;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num6.Location = new System.Drawing.Point(386, 390);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(161, 138);
            this.num6.TabIndex = 9;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equals.Location = new System.Drawing.Point(659, 466);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(83, 206);
            this.equals.TabIndex = 12;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(570, 466);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(83, 206);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(570, 248);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(172, 62);
            this.divide.TabIndex = 15;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiply.Location = new System.Drawing.Point(570, 318);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(172, 62);
            this.multiply.TabIndex = 16;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(570, 388);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(172, 62);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(570, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 73);
            this.button4.TabIndex = 19;
            this.button4.Text = "<=";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(386, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 73);
            this.button1.TabIndex = 20;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(203, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 73);
            this.button2.TabIndex = 21;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(24, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 73);
            this.button5.TabIndex = 22;
            this.button5.Text = "%";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(6, 30, 54);
            this.ClientSize = new System.Drawing.Size(757, 695);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel panel1;
        public Button button3;
        public Button num1;
        public Button num2;
        public Button num8;
        public Button num7;
        public Button num9;
        public Button num5;
        public Button num4;
        public Button num6;
        public Button equals;
        public Button plus;
        public Button divide;
        public Button multiply;
        public Button minus;
        public Button button4;
        public Button button1;
        public Button button2;
        public Button button5;
        public Label present;
        public Label past;
    }
}