﻿namespace Computer_Programme
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.input = new System.Windows.Forms.TextBox();
            this.engWord = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.tickBox = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.Label();
            this.timeLeft = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Enabled = false;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(433, 281);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(129, 31);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // engWord
            // 
            this.engWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engWord.ForeColor = System.Drawing.SystemColors.Control;
            this.engWord.Location = new System.Drawing.Point(100, 155);
            this.engWord.Name = "engWord";
            this.engWord.Size = new System.Drawing.Size(800, 80);
            this.engWord.TabIndex = 8;
            this.engWord.Text = "(After 80 seconds of attempting the questions, quiz will end)";
            this.engWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(167)))));
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.SystemColors.Control;
            this.question.Location = new System.Drawing.Point(100, 100);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(800, 40);
            this.question.TabIndex = 9;
            this.question.Text = "Intro: This Programme will ask you for the Maori word with the corresponding mean" +
    "ing,";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tickBox
            // 
            this.tickBox.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickBox.Location = new System.Drawing.Point(456, 338);
            this.tickBox.Name = "tickBox";
            this.tickBox.Size = new System.Drawing.Size(75, 57);
            this.tickBox.TabIndex = 10;
            this.tickBox.Text = "✓";
            this.tickBox.UseVisualStyleBackColor = false;
            this.tickBox.Click += new System.EventHandler(this.tickBox_Click);
            // 
            // progress
            // 
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.SystemColors.Control;
            this.progress.Location = new System.Drawing.Point(706, 27);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(256, 48);
            this.progress.TabIndex = 11;
            this.progress.Text = "Question: 0 / 10";
            this.progress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeLeft
            // 
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLeft.Location = new System.Drawing.Point(12, 27);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(256, 48);
            this.timeLeft.TabIndex = 12;
            this.timeLeft.Text = "Time left:  80 seconds";
            this.timeLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tickBox);
            this.Controls.Add(this.question);
            this.Controls.Add(this.engWord);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Maori Quiz - Level 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        public System.Windows.Forms.Label engWord;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button tickBox;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Timer timer;
    }
}