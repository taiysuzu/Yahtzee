
namespace Yahtzee
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.howToPlayButton = new System.Windows.Forms.Button();
            this.highscoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "yahtzee";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(306, 319);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // howToPlayButton
            // 
            this.howToPlayButton.Location = new System.Drawing.Point(472, 319);
            this.howToPlayButton.Name = "howToPlayButton";
            this.howToPlayButton.Size = new System.Drawing.Size(75, 23);
            this.howToPlayButton.TabIndex = 2;
            this.howToPlayButton.Text = "How to Play";
            this.howToPlayButton.UseVisualStyleBackColor = true;
            this.howToPlayButton.Click += new System.EventHandler(this.howToPlayButton_Click);
            // 
            // highscoreButton
            // 
            this.highscoreButton.Location = new System.Drawing.Point(620, 319);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(75, 23);
            this.highscoreButton.TabIndex = 3;
            this.highscoreButton.Text = "Highscores";
            this.highscoreButton.UseVisualStyleBackColor = true;
            this.highscoreButton.Click += new System.EventHandler(this.highscoreButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.howToPlayButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button howToPlayButton;
        private System.Windows.Forms.Button highscoreButton;
    }
}
