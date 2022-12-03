
namespace FinalProject
{
    partial class QuestionScreen
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
            this.rtxtQuestion = new System.Windows.Forms.RichTextBox();
            this.rtxtQuestion2 = new System.Windows.Forms.RichTextBox();
            this.rtxtQuestion4 = new System.Windows.Forms.RichTextBox();
            this.rtxtQuestion1 = new System.Windows.Forms.RichTextBox();
            this.rtxtQuestion3 = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLifeLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtQuestion
            // 
            this.rtxtQuestion.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtxtQuestion.Location = new System.Drawing.Point(493, 323);
            this.rtxtQuestion.Name = "rtxtQuestion";
            this.rtxtQuestion.Size = new System.Drawing.Size(600, 100);
            this.rtxtQuestion.TabIndex = 0;
            this.rtxtQuestion.Text = "";
            // 
            // rtxtQuestion2
            // 
            this.rtxtQuestion2.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtxtQuestion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.rtxtQuestion2.Location = new System.Drawing.Point(824, 494);
            this.rtxtQuestion2.Name = "rtxtQuestion2";
            this.rtxtQuestion2.Size = new System.Drawing.Size(600, 50);
            this.rtxtQuestion2.TabIndex = 1;
            this.rtxtQuestion2.Text = "B:";
            // 
            // rtxtQuestion4
            // 
            this.rtxtQuestion4.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtxtQuestion4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.rtxtQuestion4.Location = new System.Drawing.Point(824, 608);
            this.rtxtQuestion4.Name = "rtxtQuestion4";
            this.rtxtQuestion4.Size = new System.Drawing.Size(600, 50);
            this.rtxtQuestion4.TabIndex = 2;
            this.rtxtQuestion4.Text = "D:";
            // 
            // rtxtQuestion1
            // 
            this.rtxtQuestion1.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtxtQuestion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.rtxtQuestion1.Location = new System.Drawing.Point(157, 494);
            this.rtxtQuestion1.Name = "rtxtQuestion1";
            this.rtxtQuestion1.Size = new System.Drawing.Size(600, 50);
            this.rtxtQuestion1.TabIndex = 3;
            this.rtxtQuestion1.Text = "A:";
            // 
            // rtxtQuestion3
            // 
            this.rtxtQuestion3.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtxtQuestion3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.rtxtQuestion3.Location = new System.Drawing.Point(157, 608);
            this.rtxtQuestion3.Name = "rtxtQuestion3";
            this.rtxtQuestion3.Size = new System.Drawing.Size(600, 50);
            this.rtxtQuestion3.TabIndex = 4;
            this.rtxtQuestion3.Text = "C:";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.progressBar.ForeColor = System.Drawing.Color.Black;
            this.progressBar.Location = new System.Drawing.Point(157, 694);
            this.progressBar.Maximum = 15;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1267, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 5;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.WWTBAMUS2020Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(642, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 308);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLifeLine
            // 
            this.btnLifeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.btnLifeLine.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLifeLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLifeLine.Location = new System.Drawing.Point(1068, 119);
            this.btnLifeLine.Name = "btnLifeLine";
            this.btnLifeLine.Size = new System.Drawing.Size(356, 91);
            this.btnLifeLine.TabIndex = 7;
            this.btnLifeLine.Text = "Life Line";
            this.btnLifeLine.UseVisualStyleBackColor = false;
            // 
            // QuestionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1564, 746);
            this.Controls.Add(this.btnLifeLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.rtxtQuestion3);
            this.Controls.Add(this.rtxtQuestion1);
            this.Controls.Add(this.rtxtQuestion4);
            this.Controls.Add(this.rtxtQuestion2);
            this.Controls.Add(this.rtxtQuestion);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "QuestionScreen";
            this.Text = "Question Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtQuestion;
        private System.Windows.Forms.RichTextBox rtxtQuestion2;
        private System.Windows.Forms.RichTextBox rtxtQuestion4;
        private System.Windows.Forms.RichTextBox rtxtQuestion1;
        private System.Windows.Forms.RichTextBox rtxtQuestion3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLifeLine;
    }
}