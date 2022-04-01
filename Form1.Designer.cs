namespace Computer_Programme
{
    partial class Form1
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
            this.question = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.tickBox = new System.Windows.Forms.Button();
            this.engWord = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.RosyBrown;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(100, 100);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(800, 40);
            this.question.TabIndex = 2;
            this.question.Text = "Intro: This Programme will ask you Multiple choice questions, Press the checkbox " +
    "to continue";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(190, 219);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(100, 50);
            this.option1.TabIndex = 3;
            this.option1.TabStop = true;
            this.option1.Text = "Example 1";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.CheckedChanged += new System.EventHandler(this.option1_CheckedChanged);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(459, 219);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(100, 50);
            this.option2.TabIndex = 4;
            this.option2.TabStop = true;
            this.option2.Text = "Example 2";
            this.option2.UseVisualStyleBackColor = false;
            this.option2.CheckedChanged += new System.EventHandler(this.option2_CheckedChanged);
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(712, 219);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(100, 50);
            this.option3.TabIndex = 5;
            this.option3.TabStop = true;
            this.option3.Text = "Example 3";
            this.option3.UseVisualStyleBackColor = false;
            this.option3.CheckedChanged += new System.EventHandler(this.option3_CheckedChanged);
            // 
            // tickBox
            // 
            this.tickBox.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickBox.Location = new System.Drawing.Point(472, 347);
            this.tickBox.Name = "tickBox";
            this.tickBox.Size = new System.Drawing.Size(75, 57);
            this.tickBox.TabIndex = 6;
            this.tickBox.Text = "✓";
            this.tickBox.UseVisualStyleBackColor = false;
            this.tickBox.Click += new System.EventHandler(this.tickBox_Click);
            // 
            // engWord
            // 
            this.engWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.engWord.Location = new System.Drawing.Point(100, 150);
            this.engWord.Name = "engWord";
            this.engWord.Size = new System.Drawing.Size(800, 80);
            this.engWord.TabIndex = 7;
            this.engWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progress
            // 
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.Location = new System.Drawing.Point(712, 38);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(256, 48);
            this.progress.TabIndex = 8;
            this.progress.Text = "Question: 0 / 10";
            this.progress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLeft
            // 
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.Location = new System.Drawing.Point(12, 38);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(256, 48);
            this.timeLeft.TabIndex = 9;
            this.timeLeft.Text = "Time left:  50 secs";
            this.timeLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(980, 457);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.engWord);
            this.Controls.Add(this.tickBox);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Māori quiz";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.Button tickBox;
        public System.Windows.Forms.Label engWord;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLeft;
    }
}

