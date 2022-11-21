
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
            this.lblFailure.Location = new System.Drawing.Point(120, 22);
            this.lblFailure.Name = "lblFailure";
            this.lblFailure.Size = new System.Drawing.Size(710, 29);
            this.lblFailure.TabIndex = 1;
            this.lblFailure.Text = "You\'ve Failed To Answer Correctly";
            this.lblFailure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Font = new System.Drawing.Font("Wide Latin", 12F);
            this.lblLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.lblLost.Location = new System.Drawing.Point(191, 83);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(566, 29);
            this.lblLost.TabIndex = 2;
            this.lblLost.Text = "So You Lost Your Winnings";
            this.lblLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(7)))));
            this.btnPlayAgain.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(296, 423);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(356, 91);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Play Again?";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            // 
            // Loser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.BackgroundImage = global::FinalProject.Properties.Resources.WWTBAMUS2020Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(951, 544);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.lblFailure);
            this.DoubleBuffered = true;
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