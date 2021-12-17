
namespace Yahtzee
{
    partial class HighscoreScreen
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
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.highScoreLabel.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.highScoreLabel.Location = new System.Drawing.Point(400, 60);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(400, 540);
            this.highScoreLabel.TabIndex = 0;
            this.highScoreLabel.Text = "label1";
            this.highScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(550, 500);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(100, 40);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::Yahtzee.Properties.Resources.hiscore__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.highScoreLabel);
            this.DoubleBuffered = true;
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Button menuButton;
    }
}
