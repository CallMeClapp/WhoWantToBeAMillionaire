
namespace FinalProject
{
    partial class Loser
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
            this.lblFailure = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFailure
            // 
            this.lblFailure.AutoSize = true;
            this.lblFailure.Font = new System.Drawing.Font("Wide Latin", 12F);
            this.lblFailure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.lblFailure.Location = new System.Drawing.Point(80, 65);
            this.lblFailure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFailure.Name = "lblFailure";
            this.lblFailure.Size = new System.Drawing.Size(476, 19);
            this.lblFailure.TabIndex = 1;
            this.lblFailure.Text = "You\'ve Failed To Answer Correctly";
            this.lblFailure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Font = new System.Drawing.Font("Wide Latin", 12F);
            this.lblLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.lblLost.Location = new System.Drawing.Point(127, 95);
            this.lblLost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(379, 19);
            this.lblLost.TabIndex = 2;
            this.lblLost.Text = "So You Lost Your Winnings";
            this.lblLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.btnPlayAgain.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(197, 184);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(237, 59);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Play Again?";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click_1);
            // 
            // Loser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(634, 354);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.lblFailure);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loser";
            this.Text = "Loser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFailure;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}