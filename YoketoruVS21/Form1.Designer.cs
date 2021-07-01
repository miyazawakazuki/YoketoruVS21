
namespace YoketoruVS21
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.titleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(255, 87);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(259, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる２０２１";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(278, 234);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(221, 70);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.copyrightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightLabel.Location = new System.Drawing.Point(278, 379);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(207, 28);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright ©2021宮沢";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(38, 21);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(92, 28);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time 100";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.leftLabel.Location = new System.Drawing.Point(668, 31);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(58, 28);
            this.leftLabel.TabIndex = 4;
            this.leftLabel.Text = "★:10";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Location = new System.Drawing.Point(319, 169);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(141, 28);
            this.hiLabel.TabIndex = 5;
            this.hiLabel.Text = "HighScore 100";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Location = new System.Drawing.Point(97, 169);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(107, 28);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "Game over";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Location = new System.Drawing.Point(619, 169);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(56, 28);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "Clear";
            // 
            // titleButton
            // 
            this.titleButton.BackColor = System.Drawing.Color.Silver;
            this.titleButton.Font = new System.Drawing.Font("Yu Gothic UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleButton.Location = new System.Drawing.Point(319, 244);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(221, 70);
            this.titleButton.TabIndex = 8;
            this.titleButton.Text = "タイトル";
            this.titleButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Copyright ©2021宮沢";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button titleButton;
    }
}

