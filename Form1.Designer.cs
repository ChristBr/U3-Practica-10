﻿namespace U3_Practica_10
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(189, 83);
            label1.Name = "label1";
            label1.Size = new Size(128, 35);
            label1.TabIndex = 0;
            label1.Text = "Z = X² + X³";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 156);
            label2.Name = "label2";
            label2.Size = new Size(24, 28);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(183, 156);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 2;
            label3.Text = "X²";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(312, 156);
            label4.Name = "label4";
            label4.Size = new Size(32, 28);
            label4.TabIndex = 3;
            label4.Text = "X³";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(445, 156);
            label5.Name = "label5";
            label5.Size = new Size(23, 28);
            label5.TabIndex = 4;
            label5.Text = "Z";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Lavender;
            listBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(27, 192);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(86, 172);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Lavender;
            listBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 24;
            listBox2.Location = new Point(159, 192);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(86, 172);
            listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.Lavender;
            listBox3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 24;
            listBox3.Location = new Point(286, 192);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(86, 172);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.Lavender;
            listBox4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 24;
            listBox4.Location = new Point(415, 192);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(86, 172);
            listBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.GhostWhite;
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(198, 409);
            button1.Name = "button1";
            button1.Size = new Size(150, 37);
            button1.TabIndex = 9;
            button1.Text = "Calcular valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(71, 31);
            label6.Name = "label6";
            label6.Size = new Size(389, 35);
            label6.TabIndex = 10;
            label6.Text = "Calcula los valores de la ecuación";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(540, 473);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Valores de ecuación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button1;
        private Label label6;
    }
}