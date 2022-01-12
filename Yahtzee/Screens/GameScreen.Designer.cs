
namespace Yahtzee
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.diceBox1 = new System.Windows.Forms.PictureBox();
            this.diceBox4 = new System.Windows.Forms.PictureBox();
            this.diceBox5 = new System.Windows.Forms.PictureBox();
            this.diceBox6 = new System.Windows.Forms.PictureBox();
            this.diceBox3 = new System.Windows.Forms.PictureBox();
            this.diceBox2 = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameEntryLabel = new System.Windows.Forms.Label();
            this.test_Endgame = new System.Windows.Forms.Button();
            this.nameInputButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // diceBox1
            // 
            this.diceBox1.Location = new System.Drawing.Point(646, 246);
            this.diceBox1.Name = "diceBox1";
            this.diceBox1.Size = new System.Drawing.Size(74, 70);
            this.diceBox1.TabIndex = 1;
            this.diceBox1.TabStop = false;
            // 
            // diceBox4
            // 
            this.diceBox4.Location = new System.Drawing.Point(646, 358);
            this.diceBox4.Name = "diceBox4";
            this.diceBox4.Size = new System.Drawing.Size(74, 70);
            this.diceBox4.TabIndex = 2;
            this.diceBox4.TabStop = false;
            // 
            // diceBox5
            // 
            this.diceBox5.Location = new System.Drawing.Point(791, 358);
            this.diceBox5.Name = "diceBox5";
            this.diceBox5.Size = new System.Drawing.Size(74, 70);
            this.diceBox5.TabIndex = 3;
            this.diceBox5.TabStop = false;
            // 
            // diceBox6
            // 
            this.diceBox6.Location = new System.Drawing.Point(935, 358);
            this.diceBox6.Name = "diceBox6";
            this.diceBox6.Size = new System.Drawing.Size(74, 70);
            this.diceBox6.TabIndex = 4;
            this.diceBox6.TabStop = false;
            // 
            // diceBox3
            // 
            this.diceBox3.Location = new System.Drawing.Point(935, 246);
            this.diceBox3.Name = "diceBox3";
            this.diceBox3.Size = new System.Drawing.Size(74, 70);
            this.diceBox3.TabIndex = 5;
            this.diceBox3.TabStop = false;
            // 
            // diceBox2
            // 
            this.diceBox2.Location = new System.Drawing.Point(791, 246);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(74, 70);
            this.diceBox2.TabIndex = 6;
            this.diceBox2.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.FlatAppearance.BorderSize = 0;
            this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollButton.Location = new System.Drawing.Point(791, 512);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 7;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // nameInput
            // 
            this.nameInput.Enabled = false;
            this.nameInput.Location = new System.Drawing.Point(550, 290);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 8;
            this.nameInput.Visible = false;
            // 
            // nameEntryLabel
            // 
            this.nameEntryLabel.BackColor = System.Drawing.Color.Firebrick;
            this.nameEntryLabel.Enabled = false;
            this.nameEntryLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEntryLabel.ForeColor = System.Drawing.Color.White;
            this.nameEntryLabel.Location = new System.Drawing.Point(350, 50);
            this.nameEntryLabel.Name = "nameEntryLabel";
            this.nameEntryLabel.Size = new System.Drawing.Size(500, 500);
            this.nameEntryLabel.TabIndex = 9;
            this.nameEntryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nameEntryLabel.Visible = false;
            // 
            // test_Endgame
            // 
            this.test_Endgame.Location = new System.Drawing.Point(1039, 478);
            this.test_Endgame.Name = "test_Endgame";
            this.test_Endgame.Size = new System.Drawing.Size(150, 97);
            this.test_Endgame.TabIndex = 10;
            this.test_Endgame.Text = "testing button, triggers OnEnd";
            this.test_Endgame.UseVisualStyleBackColor = true;
            this.test_Endgame.Click += new System.EventHandler(this.test_Endgame_Click);
            // 
            // nameInputButton
            // 
            this.nameInputButton.Enabled = false;
            this.nameInputButton.FlatAppearance.BorderSize = 0;
            this.nameInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameInputButton.Location = new System.Drawing.Point(550, 322);
            this.nameInputButton.Name = "nameInputButton";
            this.nameInputButton.Size = new System.Drawing.Size(100, 23);
            this.nameInputButton.TabIndex = 11;
            this.nameInputButton.Text = "Save Score";
            this.nameInputButton.UseVisualStyleBackColor = true;
            this.nameInputButton.Visible = false;
            this.nameInputButton.Click += new System.EventHandler(this.nameInputButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yahtzee.Properties.Resources.GameScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.test_Endgame);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.diceBox3);
            this.Controls.Add(this.diceBox6);
            this.Controls.Add(this.diceBox5);
            this.Controls.Add(this.diceBox4);
            this.Controls.Add(this.diceBox1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameInputButton);
            this.Controls.Add(this.nameEntryLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1200, 600);
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox diceBox1;
        private System.Windows.Forms.PictureBox diceBox4;
        private System.Windows.Forms.PictureBox diceBox5;
        private System.Windows.Forms.PictureBox diceBox6;
        private System.Windows.Forms.PictureBox diceBox3;
        private System.Windows.Forms.PictureBox diceBox2;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameEntryLabel;
        private System.Windows.Forms.Button test_Endgame;
        private System.Windows.Forms.Button nameInputButton;
    }
}
