﻿namespace Project.V5
{
    partial class FormAbout
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 15);
            label1.TabIndex = 1;
            label1.Text = "Разработчик: Каранда Александр Романович";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 15);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Группа: АСОиУБ-24";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 39);
            label3.Name = "label3";
            label3.Size = new Size(282, 15);
            label3.TabIndex = 3;
            label3.Text = "Программа разработа в целях изучения языка C#";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 65);
            label4.Name = "label4";
            label4.Size = new Size(282, 15);
            label4.TabIndex = 4;
            label4.Text = "Тюменский Индустриальный Университет(с) 2024";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 80);
            label5.Name = "label5";
            label5.Size = new Size(264, 15);
            label5.TabIndex = 5;
            label5.Text = "Высшая Школа Цифровых Технологий(с) 2024";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 117);
            label6.Name = "label6";
            label6.Size = new Size(231, 15);
            label6.TabIndex = 6;
            label6.Text = "Внутреннее имя: Tyuiu.KarandaAR.Sprint7";
            label6.Click += label6_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 138);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAbout";
            Text = "О программе";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}