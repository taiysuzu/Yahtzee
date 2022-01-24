
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
            this.diceBox3 = new System.Windows.Forms.PictureBox();
            this.diceBox2 = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameEntryLabel = new System.Windows.Forms.Label();
            this.test_Endgame = new System.Windows.Forms.Button();
            this.nameInputButton = new System.Windows.Forms.Button();
            this.freezeButton = new System.Windows.Forms.Button();
            this.totalupperscoretopLabel = new System.Windows.Forms.Label();
            this.threeofakindLabel = new System.Windows.Forms.Label();
            this.fourofakindLabel = new System.Windows.Forms.Label();
            this.smstraightLabel = new System.Windows.Forms.Label();
            this.fullhouseLabel = new System.Windows.Forms.Label();
            this.lgstraightLabel = new System.Windows.Forms.Label();
            this.yahtzeeLabel = new System.Windows.Forms.Label();
            this.chanceLabel = new System.Windows.Forms.Label();
            this.lowertotalLabel = new System.Windows.Forms.Label();
            this.uppertotalbottomLabel = new System.Windows.Forms.Label();
            this.grandtotalLabel = new System.Windows.Forms.Label();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.topupperScore = new System.Windows.Forms.Label();
            this.sixesLabel = new System.Windows.Forms.Label();
            this.fivesLabel = new System.Windows.Forms.Label();
            this.foursLabel = new System.Windows.Forms.Label();
            this.threesLabel = new System.Windows.Forms.Label();
            this.twosLabel = new System.Windows.Forms.Label();
            this.acesLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // diceBox1
            // 
            this.diceBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox1.Location = new System.Drawing.Point(550, 100);
            this.diceBox1.Name = "diceBox1";
            this.diceBox1.Size = new System.Drawing.Size(180, 180);
            this.diceBox1.TabIndex = 1;
            this.diceBox1.TabStop = false;
            // 
            // diceBox4
            // 
            this.diceBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox4.Location = new System.Drawing.Point(420, 304);
            this.diceBox4.Name = "diceBox4";
            this.diceBox4.Size = new System.Drawing.Size(180, 180);
            this.diceBox4.TabIndex = 2;
            this.diceBox4.TabStop = false;
            // 
            // diceBox5
            // 
            this.diceBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox5.Location = new System.Drawing.Point(952, 304);
            this.diceBox5.Name = "diceBox5";
            this.diceBox5.Size = new System.Drawing.Size(180, 180);
            this.diceBox5.TabIndex = 3;
            this.diceBox5.TabStop = false;
            // 
            // diceBox3
            // 
            this.diceBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox3.Location = new System.Drawing.Point(822, 100);
            this.diceBox3.Name = "diceBox3";
            this.diceBox3.Size = new System.Drawing.Size(180, 180);
            this.diceBox3.TabIndex = 5;
            this.diceBox3.TabStop = false;
            // 
            // diceBox2
            // 
            this.diceBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox2.Location = new System.Drawing.Point(686, 304);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(180, 180);
            this.diceBox2.TabIndex = 6;
            this.diceBox2.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.FlatAppearance.BorderSize = 0;
            this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollButton.Location = new System.Drawing.Point(686, 515);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(180, 23);
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
            this.nameInput.Location = new System.Drawing.Point(129, 460);
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
            this.nameEntryLabel.Location = new System.Drawing.Point(-71, 220);
            this.nameEntryLabel.Name = "nameEntryLabel";
            this.nameEntryLabel.Size = new System.Drawing.Size(500, 500);
            this.nameEntryLabel.TabIndex = 9;
            this.nameEntryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nameEntryLabel.Visible = false;
            // 
            // test_Endgame
            // 
            this.test_Endgame.Location = new System.Drawing.Point(1047, 500);
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
            this.nameInputButton.Location = new System.Drawing.Point(129, 492);
            this.nameInputButton.Name = "nameInputButton";
            this.nameInputButton.Size = new System.Drawing.Size(100, 23);
            this.nameInputButton.TabIndex = 11;
            this.nameInputButton.Text = "Save Score";
            this.nameInputButton.UseVisualStyleBackColor = true;
            this.nameInputButton.Visible = false;
            this.nameInputButton.Click += new System.EventHandler(this.nameInputButton_Click);
            // 
            // freezeButton
            // 
            this.freezeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.freezeButton.FlatAppearance.BorderSize = 0;
            this.freezeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freezeButton.Location = new System.Drawing.Point(686, 552);
            this.freezeButton.Name = "freezeButton";
            this.freezeButton.Size = new System.Drawing.Size(180, 23);
            this.freezeButton.TabIndex = 12;
            this.freezeButton.Text = "Freeze Dice";
            this.freezeButton.UseVisualStyleBackColor = false;
            // 
            // totalupperscoretopLabel
            // 
            this.totalupperscoretopLabel.BackColor = System.Drawing.Color.White;
            this.totalupperscoretopLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalupperscoretopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalupperscoretopLabel.Location = new System.Drawing.Point(297, 248);
            this.totalupperscoretopLabel.Name = "totalupperscoretopLabel";
            this.totalupperscoretopLabel.Size = new System.Drawing.Size(64, 28);
            this.totalupperscoretopLabel.TabIndex = 13;
            this.totalupperscoretopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threeofakindLabel
            // 
            this.threeofakindLabel.BackColor = System.Drawing.Color.White;
            this.threeofakindLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeofakindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeofakindLabel.Location = new System.Drawing.Point(297, 302);
            this.threeofakindLabel.Name = "threeofakindLabel";
            this.threeofakindLabel.Size = new System.Drawing.Size(64, 28);
            this.threeofakindLabel.TabIndex = 14;
            this.threeofakindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourofakindLabel
            // 
            this.fourofakindLabel.BackColor = System.Drawing.Color.White;
            this.fourofakindLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourofakindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourofakindLabel.Location = new System.Drawing.Point(297, 329);
            this.fourofakindLabel.Name = "fourofakindLabel";
            this.fourofakindLabel.Size = new System.Drawing.Size(64, 28);
            this.fourofakindLabel.TabIndex = 15;
            this.fourofakindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smstraightLabel
            // 
            this.smstraightLabel.BackColor = System.Drawing.Color.White;
            this.smstraightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smstraightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smstraightLabel.Location = new System.Drawing.Point(297, 385);
            this.smstraightLabel.Name = "smstraightLabel";
            this.smstraightLabel.Size = new System.Drawing.Size(64, 28);
            this.smstraightLabel.TabIndex = 16;
            this.smstraightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullhouseLabel
            // 
            this.fullhouseLabel.BackColor = System.Drawing.Color.White;
            this.fullhouseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullhouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullhouseLabel.Location = new System.Drawing.Point(297, 357);
            this.fullhouseLabel.Name = "fullhouseLabel";
            this.fullhouseLabel.Size = new System.Drawing.Size(64, 28);
            this.fullhouseLabel.TabIndex = 16;
            this.fullhouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lgstraightLabel
            // 
            this.lgstraightLabel.BackColor = System.Drawing.Color.White;
            this.lgstraightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgstraightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgstraightLabel.Location = new System.Drawing.Point(297, 413);
            this.lgstraightLabel.Name = "lgstraightLabel";
            this.lgstraightLabel.Size = new System.Drawing.Size(64, 28);
            this.lgstraightLabel.TabIndex = 17;
            this.lgstraightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yahtzeeLabel
            // 
            this.yahtzeeLabel.BackColor = System.Drawing.Color.White;
            this.yahtzeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yahtzeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahtzeeLabel.Location = new System.Drawing.Point(297, 441);
            this.yahtzeeLabel.Name = "yahtzeeLabel";
            this.yahtzeeLabel.Size = new System.Drawing.Size(64, 28);
            this.yahtzeeLabel.TabIndex = 18;
            this.yahtzeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chanceLabel
            // 
            this.chanceLabel.BackColor = System.Drawing.Color.White;
            this.chanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceLabel.Location = new System.Drawing.Point(297, 469);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(64, 31);
            this.chanceLabel.TabIndex = 19;
            this.chanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowertotalLabel
            // 
            this.lowertotalLabel.BackColor = System.Drawing.Color.White;
            this.lowertotalLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowertotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowertotalLabel.Location = new System.Drawing.Point(297, 500);
            this.lowertotalLabel.Name = "lowertotalLabel";
            this.lowertotalLabel.Size = new System.Drawing.Size(64, 38);
            this.lowertotalLabel.TabIndex = 20;
            this.lowertotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uppertotalbottomLabel
            // 
            this.uppertotalbottomLabel.BackColor = System.Drawing.Color.White;
            this.uppertotalbottomLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uppertotalbottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppertotalbottomLabel.Location = new System.Drawing.Point(297, 533);
            this.uppertotalbottomLabel.Name = "uppertotalbottomLabel";
            this.uppertotalbottomLabel.Size = new System.Drawing.Size(64, 36);
            this.uppertotalbottomLabel.TabIndex = 21;
            this.uppertotalbottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grandtotalLabel
            // 
            this.grandtotalLabel.BackColor = System.Drawing.Color.White;
            this.grandtotalLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grandtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotalLabel.Location = new System.Drawing.Point(297, 569);
            this.grandtotalLabel.Name = "grandtotalLabel";
            this.grandtotalLabel.Size = new System.Drawing.Size(64, 28);
            this.grandtotalLabel.TabIndex = 22;
            this.grandtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bonusLabel
            // 
            this.bonusLabel.BackColor = System.Drawing.Color.White;
            this.bonusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusLabel.Location = new System.Drawing.Point(297, 220);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(64, 28);
            this.bonusLabel.TabIndex = 23;
            this.bonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topupperScore
            // 
            this.topupperScore.BackColor = System.Drawing.Color.White;
            this.topupperScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topupperScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topupperScore.Location = new System.Drawing.Point(297, 192);
            this.topupperScore.Name = "topupperScore";
            this.topupperScore.Size = new System.Drawing.Size(64, 28);
            this.topupperScore.TabIndex = 24;
            this.topupperScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixesLabel
            // 
            this.sixesLabel.BackColor = System.Drawing.Color.White;
            this.sixesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixesLabel.Location = new System.Drawing.Point(297, 164);
            this.sixesLabel.Name = "sixesLabel";
            this.sixesLabel.Size = new System.Drawing.Size(64, 28);
            this.sixesLabel.TabIndex = 25;
            this.sixesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fivesLabel
            // 
            this.fivesLabel.BackColor = System.Drawing.Color.White;
            this.fivesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivesLabel.Location = new System.Drawing.Point(297, 136);
            this.fivesLabel.Name = "fivesLabel";
            this.fivesLabel.Size = new System.Drawing.Size(64, 28);
            this.fivesLabel.TabIndex = 26;
            this.fivesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foursLabel
            // 
            this.foursLabel.BackColor = System.Drawing.Color.White;
            this.foursLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foursLabel.Location = new System.Drawing.Point(297, 108);
            this.foursLabel.Name = "foursLabel";
            this.foursLabel.Size = new System.Drawing.Size(64, 28);
            this.foursLabel.TabIndex = 27;
            this.foursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threesLabel
            // 
            this.threesLabel.BackColor = System.Drawing.Color.White;
            this.threesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threesLabel.Location = new System.Drawing.Point(297, 80);
            this.threesLabel.Name = "threesLabel";
            this.threesLabel.Size = new System.Drawing.Size(64, 28);
            this.threesLabel.TabIndex = 28;
            this.threesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twosLabel
            // 
            this.twosLabel.BackColor = System.Drawing.Color.White;
            this.twosLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twosLabel.Location = new System.Drawing.Point(297, 52);
            this.twosLabel.Name = "twosLabel";
            this.twosLabel.Size = new System.Drawing.Size(64, 28);
            this.twosLabel.TabIndex = 29;
            this.twosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acesLabel
            // 
            this.acesLabel.BackColor = System.Drawing.Color.White;
            this.acesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acesLabel.Location = new System.Drawing.Point(297, 24);
            this.acesLabel.Name = "acesLabel";
            this.acesLabel.Size = new System.Drawing.Size(64, 28);
            this.acesLabel.TabIndex = 30;
            this.acesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.BackColor = System.Drawing.Color.Crimson;
            this.backgroundLabel.Location = new System.Drawing.Point(357, 0);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(843, 600);
            this.backgroundLabel.TabIndex = 31;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yahtzee.Properties.Resources.GameScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.acesLabel);
            this.Controls.Add(this.twosLabel);
            this.Controls.Add(this.threesLabel);
            this.Controls.Add(this.foursLabel);
            this.Controls.Add(this.fivesLabel);
            this.Controls.Add(this.sixesLabel);
            this.Controls.Add(this.topupperScore);
            this.Controls.Add(this.bonusLabel);
            this.Controls.Add(this.grandtotalLabel);
            this.Controls.Add(this.uppertotalbottomLabel);
            this.Controls.Add(this.lowertotalLabel);
            this.Controls.Add(this.chanceLabel);
            this.Controls.Add(this.yahtzeeLabel);
            this.Controls.Add(this.lgstraightLabel);
            this.Controls.Add(this.fullhouseLabel);
            this.Controls.Add(this.smstraightLabel);
            this.Controls.Add(this.fourofakindLabel);
            this.Controls.Add(this.threeofakindLabel);
            this.Controls.Add(this.totalupperscoretopLabel);
            this.Controls.Add(this.freezeButton);
            this.Controls.Add(this.test_Endgame);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.diceBox3);
            this.Controls.Add(this.diceBox5);
            this.Controls.Add(this.diceBox4);
            this.Controls.Add(this.diceBox1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameInputButton);
            this.Controls.Add(this.nameEntryLabel);
            this.Controls.Add(this.backgroundLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox diceBox1;
        private System.Windows.Forms.PictureBox diceBox4;
        private System.Windows.Forms.PictureBox diceBox5;
        private System.Windows.Forms.PictureBox diceBox3;
        private System.Windows.Forms.PictureBox diceBox2;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameEntryLabel;
        private System.Windows.Forms.Button test_Endgame;
        private System.Windows.Forms.Button nameInputButton;
        private System.Windows.Forms.Button freezeButton;
        private System.Windows.Forms.Label totalupperscoretopLabel;
        private System.Windows.Forms.Label threeofakindLabel;
        private System.Windows.Forms.Label fourofakindLabel;
        private System.Windows.Forms.Label smstraightLabel;
        private System.Windows.Forms.Label fullhouseLabel;
        private System.Windows.Forms.Label lgstraightLabel;
        private System.Windows.Forms.Label yahtzeeLabel;
        private System.Windows.Forms.Label chanceLabel;
        private System.Windows.Forms.Label lowertotalLabel;
        private System.Windows.Forms.Label uppertotalbottomLabel;
        private System.Windows.Forms.Label grandtotalLabel;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Label topupperScore;
        private System.Windows.Forms.Label sixesLabel;
        private System.Windows.Forms.Label fivesLabel;
        private System.Windows.Forms.Label foursLabel;
        private System.Windows.Forms.Label threesLabel;
        private System.Windows.Forms.Label twosLabel;
        private System.Windows.Forms.Label acesLabel;
        private System.Windows.Forms.Label backgroundLabel;
    }
}
