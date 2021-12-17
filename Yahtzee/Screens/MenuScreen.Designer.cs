
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
            this.startButton = new System.Windows.Forms.Button();
            this.howToPlayButton = new System.Windows.Forms.Button();
            this.highscoreButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(250, 450);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 50);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // howToPlayButton
            // 
            this.howToPlayButton.Location = new System.Drawing.Point(450, 450);
            this.howToPlayButton.Name = "howToPlayButton";
            this.howToPlayButton.Size = new System.Drawing.Size(100, 50);
            this.howToPlayButton.TabIndex = 2;
            this.howToPlayButton.Text = "How to Play";
            this.howToPlayButton.UseVisualStyleBackColor = true;
            this.howToPlayButton.Click += new System.EventHandler(this.howToPlayButton_Click);
            // 
            // highscoreButton
            // 
            this.highscoreButton.Location = new System.Drawing.Point(650, 450);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(100, 50);
            this.highscoreButton.TabIndex = 3;
            this.highscoreButton.Text = "Highscores";
            this.highscoreButton.UseVisualStyleBackColor = true;
            this.highscoreButton.Click += new System.EventHandler(this.highscoreButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(850, 450);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 50);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Yahtzee.Properties.Resources.MenuScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.howToPlayButton);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button howToPlayButton;
        private System.Windows.Forms.Button highscoreButton;
        private System.Windows.Forms.Button exitButton;
    }
}
