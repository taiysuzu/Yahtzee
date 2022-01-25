
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
            this.totalTopScoreLabel = new System.Windows.Forms.Label();
            this.threeOfAKindLabel = new System.Windows.Forms.Label();
            this.fourOfAkindLabel = new System.Windows.Forms.Label();
            this.smStraightLabel = new System.Windows.Forms.Label();
            this.fullhouseLabel = new System.Windows.Forms.Label();
            this.lgStraightLabel = new System.Windows.Forms.Label();
            this.yahtzeeLabel = new System.Windows.Forms.Label();
            this.chanceLabel = new System.Windows.Forms.Label();
            this.totalBottomScoreLabel = new System.Windows.Forms.Label();
            this.totalTopScoreLabel2 = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.topScoreBeforeBonusLabel = new System.Windows.Forms.Label();
            this.sixesLabel = new System.Windows.Forms.Label();
            this.fivesLabel = new System.Windows.Forms.Label();
            this.foursLabel = new System.Windows.Forms.Label();
            this.threesLabel = new System.Windows.Forms.Label();
            this.twosLabel = new System.Windows.Forms.Label();
            this.acesLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.dice1FrozenBox = new System.Windows.Forms.Label();
            this.dice3FrozenBox = new System.Windows.Forms.Label();
            this.dice4FrozenBox = new System.Windows.Forms.Label();
            this.dice5FrozenBox = new System.Windows.Forms.Label();
            this.dice2FrozenBox = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.categoryHighlight1 = new System.Windows.Forms.Label();
            this.categoryHighlight2 = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
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
            this.diceBox1.Click += new System.EventHandler(this.diceBox1_Click);
            // 
            // diceBox4
            // 
            this.diceBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox4.Location = new System.Drawing.Point(686, 304);
            this.diceBox4.Name = "diceBox4";
            this.diceBox4.Size = new System.Drawing.Size(180, 180);
            this.diceBox4.TabIndex = 2;
            this.diceBox4.TabStop = false;
            this.diceBox4.Click += new System.EventHandler(this.diceBox4_Click);
            // 
            // diceBox5
            // 
            this.diceBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox5.Location = new System.Drawing.Point(952, 304);
            this.diceBox5.Name = "diceBox5";
            this.diceBox5.Size = new System.Drawing.Size(180, 180);
            this.diceBox5.TabIndex = 3;
            this.diceBox5.TabStop = false;
            this.diceBox5.Click += new System.EventHandler(this.diceBox5_Click);
            // 
            // diceBox3
            // 
            this.diceBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox3.Location = new System.Drawing.Point(420, 304);
            this.diceBox3.Name = "diceBox3";
            this.diceBox3.Size = new System.Drawing.Size(180, 180);
            this.diceBox3.TabIndex = 5;
            this.diceBox3.TabStop = false;
            this.diceBox3.Click += new System.EventHandler(this.diceBox3_Click);
            // 
            // diceBox2
            // 
            this.diceBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diceBox2.Location = new System.Drawing.Point(822, 100);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(180, 180);
            this.diceBox2.TabIndex = 6;
            this.diceBox2.TabStop = false;
            this.diceBox2.Click += new System.EventHandler(this.diceBox2_Click);
            // 
            // rollButton
            // 
            this.rollButton.FlatAppearance.BorderSize = 0;
            this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.nameInput.Location = new System.Drawing.Point(900, 542);
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
            this.nameEntryLabel.Location = new System.Drawing.Point(700, 302);
            this.nameEntryLabel.Name = "nameEntryLabel";
            this.nameEntryLabel.Size = new System.Drawing.Size(500, 500);
            this.nameEntryLabel.TabIndex = 9;
            this.nameEntryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nameEntryLabel.Visible = false;
            // 
            // test_Endgame
            // 
            this.test_Endgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.nameInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputButton.Location = new System.Drawing.Point(900, 574);
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
            this.freezeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.freezeButton.FlatAppearance.BorderSize = 0;
            this.freezeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freezeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freezeButton.Location = new System.Drawing.Point(686, 552);
            this.freezeButton.Name = "freezeButton";
            this.freezeButton.Size = new System.Drawing.Size(180, 23);
            this.freezeButton.TabIndex = 12;
            this.freezeButton.Text = "Freeze Dice";
            this.freezeButton.UseVisualStyleBackColor = false;
            this.freezeButton.Click += new System.EventHandler(this.freezeButton_Click);
            // 
            // totalTopScoreLabel
            // 
            this.totalTopScoreLabel.BackColor = System.Drawing.Color.White;
            this.totalTopScoreLabel.Enabled = false;
            this.totalTopScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalTopScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTopScoreLabel.Location = new System.Drawing.Point(297, 248);
            this.totalTopScoreLabel.Name = "totalTopScoreLabel";
            this.totalTopScoreLabel.Size = new System.Drawing.Size(60, 28);
            this.totalTopScoreLabel.TabIndex = 13;
            this.totalTopScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threeOfAKindLabel
            // 
            this.threeOfAKindLabel.BackColor = System.Drawing.Color.White;
            this.threeOfAKindLabel.Enabled = false;
            this.threeOfAKindLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeOfAKindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeOfAKindLabel.Location = new System.Drawing.Point(297, 302);
            this.threeOfAKindLabel.Name = "threeOfAKindLabel";
            this.threeOfAKindLabel.Size = new System.Drawing.Size(60, 28);
            this.threeOfAKindLabel.TabIndex = 14;
            this.threeOfAKindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourOfAkindLabel
            // 
            this.fourOfAkindLabel.BackColor = System.Drawing.Color.White;
            this.fourOfAkindLabel.Enabled = false;
            this.fourOfAkindLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourOfAkindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourOfAkindLabel.Location = new System.Drawing.Point(297, 329);
            this.fourOfAkindLabel.Name = "fourOfAkindLabel";
            this.fourOfAkindLabel.Size = new System.Drawing.Size(60, 28);
            this.fourOfAkindLabel.TabIndex = 15;
            this.fourOfAkindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smStraightLabel
            // 
            this.smStraightLabel.BackColor = System.Drawing.Color.White;
            this.smStraightLabel.Enabled = false;
            this.smStraightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smStraightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smStraightLabel.Location = new System.Drawing.Point(297, 385);
            this.smStraightLabel.Name = "smStraightLabel";
            this.smStraightLabel.Size = new System.Drawing.Size(60, 28);
            this.smStraightLabel.TabIndex = 16;
            this.smStraightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullhouseLabel
            // 
            this.fullhouseLabel.BackColor = System.Drawing.Color.White;
            this.fullhouseLabel.Enabled = false;
            this.fullhouseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullhouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullhouseLabel.Location = new System.Drawing.Point(297, 357);
            this.fullhouseLabel.Name = "fullhouseLabel";
            this.fullhouseLabel.Size = new System.Drawing.Size(60, 28);
            this.fullhouseLabel.TabIndex = 16;
            this.fullhouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lgStraightLabel
            // 
            this.lgStraightLabel.BackColor = System.Drawing.Color.White;
            this.lgStraightLabel.Enabled = false;
            this.lgStraightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgStraightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgStraightLabel.Location = new System.Drawing.Point(297, 413);
            this.lgStraightLabel.Name = "lgStraightLabel";
            this.lgStraightLabel.Size = new System.Drawing.Size(60, 28);
            this.lgStraightLabel.TabIndex = 17;
            this.lgStraightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yahtzeeLabel
            // 
            this.yahtzeeLabel.BackColor = System.Drawing.Color.White;
            this.yahtzeeLabel.Enabled = false;
            this.yahtzeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yahtzeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahtzeeLabel.Location = new System.Drawing.Point(297, 441);
            this.yahtzeeLabel.Name = "yahtzeeLabel";
            this.yahtzeeLabel.Size = new System.Drawing.Size(60, 28);
            this.yahtzeeLabel.TabIndex = 18;
            this.yahtzeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chanceLabel
            // 
            this.chanceLabel.BackColor = System.Drawing.Color.White;
            this.chanceLabel.Enabled = false;
            this.chanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceLabel.Location = new System.Drawing.Point(297, 469);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(60, 28);
            this.chanceLabel.TabIndex = 19;
            this.chanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalBottomScoreLabel
            // 
            this.totalBottomScoreLabel.BackColor = System.Drawing.Color.White;
            this.totalBottomScoreLabel.Enabled = false;
            this.totalBottomScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalBottomScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBottomScoreLabel.Location = new System.Drawing.Point(297, 505);
            this.totalBottomScoreLabel.Name = "totalBottomScoreLabel";
            this.totalBottomScoreLabel.Size = new System.Drawing.Size(60, 28);
            this.totalBottomScoreLabel.TabIndex = 20;
            this.totalBottomScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTopScoreLabel2
            // 
            this.totalTopScoreLabel2.BackColor = System.Drawing.Color.White;
            this.totalTopScoreLabel2.Enabled = false;
            this.totalTopScoreLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalTopScoreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTopScoreLabel2.Location = new System.Drawing.Point(297, 537);
            this.totalTopScoreLabel2.Name = "totalTopScoreLabel2";
            this.totalTopScoreLabel2.Size = new System.Drawing.Size(60, 28);
            this.totalTopScoreLabel2.TabIndex = 21;
            this.totalTopScoreLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.BackColor = System.Drawing.Color.White;
            this.grandTotalLabel.Enabled = false;
            this.grandTotalLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLabel.Location = new System.Drawing.Point(297, 569);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(60, 28);
            this.grandTotalLabel.TabIndex = 22;
            this.grandTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bonusLabel
            // 
            this.bonusLabel.BackColor = System.Drawing.Color.White;
            this.bonusLabel.Enabled = false;
            this.bonusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusLabel.Location = new System.Drawing.Point(297, 220);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(60, 28);
            this.bonusLabel.TabIndex = 23;
            this.bonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topScoreBeforeBonusLabel
            // 
            this.topScoreBeforeBonusLabel.BackColor = System.Drawing.Color.White;
            this.topScoreBeforeBonusLabel.Enabled = false;
            this.topScoreBeforeBonusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topScoreBeforeBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topScoreBeforeBonusLabel.Location = new System.Drawing.Point(297, 192);
            this.topScoreBeforeBonusLabel.Name = "topScoreBeforeBonusLabel";
            this.topScoreBeforeBonusLabel.Size = new System.Drawing.Size(60, 28);
            this.topScoreBeforeBonusLabel.TabIndex = 24;
            this.topScoreBeforeBonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixesLabel
            // 
            this.sixesLabel.BackColor = System.Drawing.Color.White;
            this.sixesLabel.Enabled = false;
            this.sixesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixesLabel.Location = new System.Drawing.Point(297, 164);
            this.sixesLabel.Name = "sixesLabel";
            this.sixesLabel.Size = new System.Drawing.Size(60, 28);
            this.sixesLabel.TabIndex = 25;
            this.sixesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sixesLabel.Click += new System.EventHandler(this.sixesLabel_Click);
            // 
            // fivesLabel
            // 
            this.fivesLabel.BackColor = System.Drawing.Color.White;
            this.fivesLabel.Enabled = false;
            this.fivesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivesLabel.Location = new System.Drawing.Point(297, 136);
            this.fivesLabel.Name = "fivesLabel";
            this.fivesLabel.Size = new System.Drawing.Size(60, 28);
            this.fivesLabel.TabIndex = 26;
            this.fivesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fivesLabel.Click += new System.EventHandler(this.fivesLabel_Click);
            // 
            // foursLabel
            // 
            this.foursLabel.BackColor = System.Drawing.Color.White;
            this.foursLabel.Enabled = false;
            this.foursLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foursLabel.Location = new System.Drawing.Point(297, 108);
            this.foursLabel.Name = "foursLabel";
            this.foursLabel.Size = new System.Drawing.Size(60, 28);
            this.foursLabel.TabIndex = 27;
            this.foursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foursLabel.Click += new System.EventHandler(this.foursLabel_Click);
            // 
            // threesLabel
            // 
            this.threesLabel.BackColor = System.Drawing.Color.White;
            this.threesLabel.Enabled = false;
            this.threesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threesLabel.Location = new System.Drawing.Point(297, 80);
            this.threesLabel.Name = "threesLabel";
            this.threesLabel.Size = new System.Drawing.Size(60, 28);
            this.threesLabel.TabIndex = 28;
            this.threesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.threesLabel.Click += new System.EventHandler(this.threesLabel_Click);
            // 
            // twosLabel
            // 
            this.twosLabel.BackColor = System.Drawing.Color.White;
            this.twosLabel.Enabled = false;
            this.twosLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twosLabel.Location = new System.Drawing.Point(297, 52);
            this.twosLabel.Name = "twosLabel";
            this.twosLabel.Size = new System.Drawing.Size(60, 28);
            this.twosLabel.TabIndex = 29;
            this.twosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twosLabel.Click += new System.EventHandler(this.twosLabel_Click);
            // 
            // acesLabel
            // 
            this.acesLabel.BackColor = System.Drawing.Color.White;
            this.acesLabel.Enabled = false;
            this.acesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acesLabel.Location = new System.Drawing.Point(297, 24);
            this.acesLabel.Name = "acesLabel";
            this.acesLabel.Size = new System.Drawing.Size(60, 28);
            this.acesLabel.TabIndex = 30;
            this.acesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acesLabel.Click += new System.EventHandler(this.acesLabel_Click);
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.BackColor = System.Drawing.Color.Crimson;
            this.backgroundLabel.Location = new System.Drawing.Point(357, 0);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(843, 600);
            this.backgroundLabel.TabIndex = 31;
            // 
            // dice1FrozenBox
            // 
            this.dice1FrozenBox.BackColor = System.Drawing.Color.Gold;
            this.dice1FrozenBox.Location = new System.Drawing.Point(543, 93);
            this.dice1FrozenBox.Name = "dice1FrozenBox";
            this.dice1FrozenBox.Size = new System.Drawing.Size(194, 194);
            this.dice1FrozenBox.TabIndex = 32;
            this.dice1FrozenBox.Visible = false;
            // 
            // dice3FrozenBox
            // 
            this.dice3FrozenBox.BackColor = System.Drawing.Color.Gold;
            this.dice3FrozenBox.Location = new System.Drawing.Point(413, 297);
            this.dice3FrozenBox.Name = "dice3FrozenBox";
            this.dice3FrozenBox.Size = new System.Drawing.Size(194, 194);
            this.dice3FrozenBox.TabIndex = 33;
            this.dice3FrozenBox.Visible = false;
            // 
            // dice4FrozenBox
            // 
            this.dice4FrozenBox.BackColor = System.Drawing.Color.Gold;
            this.dice4FrozenBox.Location = new System.Drawing.Point(679, 297);
            this.dice4FrozenBox.Name = "dice4FrozenBox";
            this.dice4FrozenBox.Size = new System.Drawing.Size(194, 194);
            this.dice4FrozenBox.TabIndex = 34;
            this.dice4FrozenBox.Visible = false;
            this.dice4FrozenBox.Click += new System.EventHandler(this.diceBox4_Click);
            // 
            // dice5FrozenBox
            // 
            this.dice5FrozenBox.BackColor = System.Drawing.Color.Gold;
            this.dice5FrozenBox.Location = new System.Drawing.Point(945, 297);
            this.dice5FrozenBox.Name = "dice5FrozenBox";
            this.dice5FrozenBox.Size = new System.Drawing.Size(194, 194);
            this.dice5FrozenBox.TabIndex = 35;
            this.dice5FrozenBox.Visible = false;
            this.dice5FrozenBox.Click += new System.EventHandler(this.diceBox5_Click);
            // 
            // dice2FrozenBox
            // 
            this.dice2FrozenBox.BackColor = System.Drawing.Color.Gold;
            this.dice2FrozenBox.Location = new System.Drawing.Point(814, 93);
            this.dice2FrozenBox.Name = "dice2FrozenBox";
            this.dice2FrozenBox.Size = new System.Drawing.Size(194, 194);
            this.dice2FrozenBox.TabIndex = 36;
            this.dice2FrozenBox.Visible = false;
            // 
            // turnLabel
            // 
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(370, 4);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(107, 76);
            this.turnLabel.TabIndex = 37;
            this.turnLabel.Text = "sample text";
            // 
            // categoryHighlight1
            // 
            this.categoryHighlight1.BackColor = System.Drawing.Color.Gold;
            this.categoryHighlight1.Location = new System.Drawing.Point(290, 17);
            this.categoryHighlight1.Name = "categoryHighlight1";
            this.categoryHighlight1.Size = new System.Drawing.Size(74, 266);
            this.categoryHighlight1.TabIndex = 38;
            this.categoryHighlight1.Visible = false;
            // 
            // categoryHighlight2
            // 
            this.categoryHighlight2.BackColor = System.Drawing.Color.Gold;
            this.categoryHighlight2.Location = new System.Drawing.Point(290, 295);
            this.categoryHighlight2.Name = "categoryHighlight2";
            this.categoryHighlight2.Size = new System.Drawing.Size(74, 305);
            this.categoryHighlight2.TabIndex = 39;
            this.categoryHighlight2.Visible = false;
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(483, 4);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(714, 76);
            this.topLabel.TabIndex = 40;
            this.topLabel.Text = "toplabel";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yahtzee.Properties.Resources.GameScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.acesLabel);
            this.Controls.Add(this.twosLabel);
            this.Controls.Add(this.threesLabel);
            this.Controls.Add(this.foursLabel);
            this.Controls.Add(this.fivesLabel);
            this.Controls.Add(this.sixesLabel);
            this.Controls.Add(this.topScoreBeforeBonusLabel);
            this.Controls.Add(this.bonusLabel);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.totalTopScoreLabel2);
            this.Controls.Add(this.totalBottomScoreLabel);
            this.Controls.Add(this.chanceLabel);
            this.Controls.Add(this.yahtzeeLabel);
            this.Controls.Add(this.lgStraightLabel);
            this.Controls.Add(this.fullhouseLabel);
            this.Controls.Add(this.smStraightLabel);
            this.Controls.Add(this.fourOfAkindLabel);
            this.Controls.Add(this.threeOfAKindLabel);
            this.Controls.Add(this.totalTopScoreLabel);
            this.Controls.Add(this.freezeButton);
            this.Controls.Add(this.test_Endgame);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.diceBox5);
            this.Controls.Add(this.diceBox4);
            this.Controls.Add(this.diceBox1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameInputButton);
            this.Controls.Add(this.nameEntryLabel);
            this.Controls.Add(this.dice1FrozenBox);
            this.Controls.Add(this.dice5FrozenBox);
            this.Controls.Add(this.dice4FrozenBox);
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.dice2FrozenBox);
            this.Controls.Add(this.diceBox3);
            this.Controls.Add(this.dice3FrozenBox);
            this.Controls.Add(this.categoryHighlight1);
            this.Controls.Add(this.categoryHighlight2);
            this.Controls.Add(this.backgroundLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1200, 600);
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
        private System.Windows.Forms.Label totalTopScoreLabel;
        private System.Windows.Forms.Label threeOfAKindLabel;
        private System.Windows.Forms.Label fourOfAkindLabel;
        private System.Windows.Forms.Label smStraightLabel;
        private System.Windows.Forms.Label fullhouseLabel;
        private System.Windows.Forms.Label lgStraightLabel;
        private System.Windows.Forms.Label yahtzeeLabel;
        private System.Windows.Forms.Label chanceLabel;
        private System.Windows.Forms.Label totalBottomScoreLabel;
        private System.Windows.Forms.Label totalTopScoreLabel2;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Label topScoreBeforeBonusLabel;
        private System.Windows.Forms.Label sixesLabel;
        private System.Windows.Forms.Label fivesLabel;
        private System.Windows.Forms.Label foursLabel;
        private System.Windows.Forms.Label threesLabel;
        private System.Windows.Forms.Label twosLabel;
        private System.Windows.Forms.Label acesLabel;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Label dice1FrozenBox;
        private System.Windows.Forms.Label dice3FrozenBox;
        private System.Windows.Forms.Label dice4FrozenBox;
        private System.Windows.Forms.Label dice5FrozenBox;
        private System.Windows.Forms.Label dice2FrozenBox;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label categoryHighlight1;
        private System.Windows.Forms.Label categoryHighlight2;
        private System.Windows.Forms.Label topLabel;
    }
}
