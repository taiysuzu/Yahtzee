using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class GameScreen : UserControl
    {
        #region Global Values
        //random generator
        public static Random randGen = new Random();

        //booleans
        bool rollsDone = false;
        bool freezeMode = false;

        //turn and roll counters
        int turn = 1;
        int rolls = 3;

        //lists
        List<Dice> diceList = new List<Dice>();
        List<PictureBox> diceBoxList = new List<PictureBox>();
        List<Label> diceFrozenBoxList = new List<Label>();
        List<Image> diceImageList = new List<Image> { Properties.Resources.Die1, Properties.Resources.Die2, Properties.Resources.Die3,
            Properties.Resources.Die4, Properties.Resources.Die5, Properties.Resources.Die6};

        //score / highscore objects
        int score;
        string name;

        int topScoreBeforeBonus;
        int totalTopScore;
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void OnStart()
        {
            //create dice objects to hold values and add to dice list
            for (int i = 0; i < 5; i++)
            {
                Dice dice = new Dice(randGen.Next(1, 7));
                diceList.Add(dice);
            }

            //add all dice picture boxes and labels to lists
            diceBoxList.Add(diceBox1);
            diceBoxList.Add(diceBox2);
            diceBoxList.Add(diceBox3);
            diceBoxList.Add(diceBox4);
            diceBoxList.Add(diceBox5);

            diceFrozenBoxList.Add(dice1FrozenBox);
            diceFrozenBoxList.Add(dice2FrozenBox);
            diceFrozenBoxList.Add(dice3FrozenBox);
            diceFrozenBoxList.Add(dice4FrozenBox);
            diceFrozenBoxList.Add(dice5FrozenBox);

            //turn pause buttons invisible (bug where if they start visible=false they won't show up)
            resumeButton.Enabled = false;
            menuButton.Enabled = false;
            exitButton.Enabled = false;
            resumeButton.Visible = false;
            menuButton.Visible = false;
            exitButton.Visible = false;

            //reset game values
            score = 0;
            topScoreBeforeBonus = 0;
            totalTopScore = 0;

            //begin game loop
            gameTimer.Enabled = true;
        }

        private void OnEnd()
        {
            //stop game timer 
            gameTimer.Enabled = false;

            //display name entry (3 characters, uppercase)
            nameEntryLabel.Enabled = true;
            nameInput.Enabled = true;
            nameInputButton.Enabled = true;
            nameEntryLabel.Visible = true;
            nameInput.Visible = true;
            nameInputButton.Visible = true;

            nameEntryLabel.Text = $"\n\n\n\n\n\n\nYou achieved a score of {score}! \n\nEnter your initials below.";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (freezeMode == true)
            {
                //show freeze mde indicators
                dice1FrozenBox.Visible = true;
                dice2FrozenBox.Visible = true;
                dice3FrozenBox.Visible = true;
                dice4FrozenBox.Visible = true;
                dice5FrozenBox.Visible = true;
                rollButton.Enabled = false;
                topLabel.Text = "Click a Die to Freeze It!";
            }
            else
            {
                //hide all non-frozen dice outlines
                for (int i = 0; i < 5; i++)
                {
                    if (diceList[i].frozen == false)
                    {
                        diceFrozenBoxList[i].Visible = false;
                    }
                }
                rollButton.Enabled = true;
                topLabel.Text = "Roll the Dice!";
            }

            if (rollsDone == true)
            {   //highlight and enable scoring boxes
                acesLabel.Enabled = true;
                twosLabel.Enabled = true;
                threesLabel.Enabled = true;
                foursLabel.Enabled = true;
                fivesLabel.Enabled = true;
                sixesLabel.Enabled = true;
                threeOfAKindLabel.Enabled = true;
                fourOfAkindLabel.Enabled = true;
                fullhouseLabel.Enabled = true;
                smStraightLabel.Enabled = true;
                lgStraightLabel.Enabled = true;
                yahtzeeLabel.Enabled = true;
                chanceLabel.Enabled = true;

                rollButton.Enabled = false;

                categoryHighlight1.Visible = true;
                categoryHighlight2.Visible = true;

                topLabel.Text = "Click a Box to Score!";
            }
            else if (rollsDone == false)
            {//disable scoring once new turn starts
                acesLabel.Enabled = false;
                twosLabel.Enabled = false;
                threesLabel.Enabled = false;
                foursLabel.Enabled = false;
                fivesLabel.Enabled = false;
                sixesLabel.Enabled = false;
                threeOfAKindLabel.Enabled = false;
                fourOfAkindLabel.Enabled = false;
                fullhouseLabel.Enabled = false;
                smStraightLabel.Enabled = false;
                lgStraightLabel.Enabled = false;
                yahtzeeLabel.Enabled = false;
                chanceLabel.Enabled = false;
                rollButton.Enabled = true;

                topLabel.Text = "Roll the Dice!";
            }

            if (rolls == 3)
            {//disable freezing of dice before first roll, must roll at least once before choosing dice to keep
                freezeButton.Enabled = false;
            }
            else
            {
                freezeButton.Enabled = true;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < diceBoxList.Count; i++)
            {
                //paints dice images based on dice values
                diceBoxList[i].BackgroundImage = diceImageList[diceList[i].value - 1];
            }

            //displays turn and roll to screen
            turnLabel.Text = $"Turn: {turn}/13 \nRolls: {rolls}/3";

            #region Score Totals
            //display total score from upper section before bonus
            topScoreBeforeBonusLabel.Text = $"{topScoreBeforeBonus}";
            //check if bonus can be applied
            if (topScoreBeforeBonus >= 63)
            {//apply bonus
                bonusLabel.Text = "35";
                totalTopScore = topScoreBeforeBonus + 35;
            }
            else
            {
                bonusLabel.Text = "0";
                totalTopScore = topScoreBeforeBonus;
            }
            //display total upper section score
            totalTopScoreLabel.Text = $"{totalTopScore}";
            totalTopScoreLabel2.Text = $"{totalTopScore}";
            #endregion
        }

        #region Button Click Methods
        private void rollButton_Click(object sender, EventArgs e)
        {
            foreach (Dice dice in diceList)
            {
                //randomize dice values (roll the dice)
                dice.Roll();
            }

            //subtract one from remaining rolls
            rolls--;
            if (rolls == 0)
            {//if rollsdone =
                rollsDone = true;
            }
            Refresh();
        }

        private void freezeButton_Click(object sender, EventArgs e)
        {
            //enters freeze mode to be able to save dice rolls
            freezeMode = !freezeMode;
        }

        private void nameInputButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Length == 3)
            {
                //saves name and score to highscore object
                name = nameInput.Text.ToUpper();

                Highscore hs = new Highscore(name, score);
                Yahtzee.scores.Add(hs);

                // Goes to the high score screen
                Form form = this.FindForm();

                HighscoreScreen go = new HighscoreScreen();
                go.Location = new Point((form.Width - go.Width) / 2, (form.Height - go.Height) / 2);

                form.Controls.Add(go);
                form.Controls.Remove(this);
            }
            else
            {
                nameEntryLabel.Text += $"\n\n\n\n\n\n\n\n\nPlease enter 3 uppercase characters.";
            }
        }

        #region Pause Menu Buttons
        private void pauseButtonLabel_Click(object sender, EventArgs e)
        {
            //stops game timer, displays and enables pause menu and buttons
            pauseLabel.Visible = true;
            resumeButton.Enabled = true;
            menuButton.Enabled = true;
            exitButton.Enabled = true;
            resumeButton.Visible = true;
            menuButton.Visible = true;
            exitButton.Visible = true;
            pauseLabel.BringToFront();
            menuButton.BringToFront();
            resumeButton.BringToFront();
            exitButton.BringToFront();
            gameTimer.Enabled = false;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            //starts the game timer, hides and disables pause menu and buttons
            gameTimer.Enabled = true;
            pauseLabel.Visible = false;
            resumeButton.Visible = false;
            menuButton.Visible = false;
            exitButton.Visible = false;
            resumeButton.Enabled = false;
            menuButton.Enabled = false;
            exitButton.Enabled = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //starts game / opens game screen
            Form form = this.FindForm();

            MenuScreen ms = new MenuScreen();
            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

            form.Controls.Add(ms);
            form.Controls.Remove(this);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //quits the game
            Application.Exit();
        }
        #endregion
        #endregion

        #region Dice Box Click Methods
        //below is code to freeze and unfreeze dice based on a click
        private void diceBox1_Click(object sender, EventArgs e)
        {
            if (freezeMode == true && diceList[0].frozen == false)
            {
                diceList[0].frozen = true;
                dice1FrozenBox.BackColor = Color.SkyBlue;
            }
            else if (freezeMode == true && diceList[0].frozen == true)
            {
                diceList[0].frozen = false;
                dice1FrozenBox.BackColor = Color.Gold;
            }
        }
        private void diceBox2_Click(object sender, EventArgs e)
        {
            if (freezeMode == true && diceList[1].frozen == false)
            {
                diceList[1].frozen = true;
                dice2FrozenBox.BackColor = Color.SkyBlue;
            }
            else if (freezeMode == true && diceList[1].frozen == true)
            {
                diceList[1].frozen = false;
                dice2FrozenBox.BackColor = Color.Gold;
            }
        }
        private void diceBox3_Click(object sender, EventArgs e)
        {
            if (freezeMode == true && diceList[2].frozen == false)
            {
                diceList[2].frozen = true;
                dice3FrozenBox.BackColor = Color.SkyBlue;
            }
            else if (freezeMode == true && diceList[2].frozen == true)
            {
                diceList[2].frozen = false;
                dice3FrozenBox.BackColor = Color.Gold;
            }
        }
        private void diceBox4_Click(object sender, EventArgs e)
        {
            if (freezeMode == true && diceList[3].frozen == false)
            {
                diceList[3].frozen = true;
                dice4FrozenBox.BackColor = Color.SkyBlue;
            }
            else if (freezeMode == true && diceList[3].frozen == true)
            {
                diceList[3].frozen = false;
                dice4FrozenBox.BackColor = Color.Gold;
            }
        }

        private void diceBox5_Click(object sender, EventArgs e)
        {
            if (freezeMode == true && diceList[4].frozen == false)
            {
                diceList[4].frozen = true;
                dice5FrozenBox.BackColor = Color.SkyBlue;
            }
            else if (freezeMode == true && diceList[4].frozen == true)
            {
                diceList[4].frozen = false;
                dice5FrozenBox.BackColor = Color.Gold;
            }
        }
        #endregion

        #region Label Click Methods
        //scoring methods
        private void acesLabel_Click(object sender, EventArgs e)
        {//scores based on how many ones are in the dice list
            List<Dice> aces = diceList.FindAll(a => a.value == 1);
            acesLabel.Text = aces.Count.ToString();
            topScoreBeforeBonus += aces.Count;
            NewTurn();
        }

        private void twosLabel_Click(object sender, EventArgs e)
        {//scores based on how many twos are in the dice list
            List<Dice> twos = diceList.FindAll(a => a.value == 2);
            twosLabel.Text = (twos.Count * 2).ToString();
            topScoreBeforeBonus += twos.Count * 2;
            NewTurn();
        }

        private void threesLabel_Click(object sender, EventArgs e)
        {//scores based on how many threes are in the dice list
            List<Dice> threes = diceList.FindAll(a => a.value == 3);
            threesLabel.Text = (threes.Count * 3).ToString();
            topScoreBeforeBonus += threes.Count * 3;
            NewTurn();
        }

        private void foursLabel_Click(object sender, EventArgs e)
        {//scores based on how many fours are in the dice list
            List<Dice> fours = diceList.FindAll(a => a.value == 4);
            foursLabel.Text = (fours.Count * 4).ToString();
            topScoreBeforeBonus += fours.Count * 4;
            NewTurn();
        }

        private void fivesLabel_Click(object sender, EventArgs e)
        {//scores based on how many fives are in the dice list
            List<Dice> fives = diceList.FindAll(a => a.value == 5);
            fivesLabel.Text = (fives.Count * 5).ToString();
            topScoreBeforeBonus += fives.Count * 5;
            NewTurn();
        }

        private void sixesLabel_Click(object sender, EventArgs e)
        {//scores based on how many sixes are in the dice list
            List<Dice> sixes = diceList.FindAll(a => a.value == 6);
            sixesLabel.Text = (sixes.Count * 6).ToString();
            topScoreBeforeBonus += sixes.Count * 6;
            NewTurn();
        }
        private void threeOfAKindLabel_Click(object sender, EventArgs e)
        {

        }
        private void fourOfAkindLabel_Click(object sender, EventArgs e)
        {

        }
        private void fullhouseLabel_Click(object sender, EventArgs e)
        {

        }
        private void smStraightLabel_Click(object sender, EventArgs e)
        {

        }
        private void lgStraightLabel_Click(object sender, EventArgs e)
        {

        }
        private void yahtzeeLabel_Click(object sender, EventArgs e)
        {

        }
        private void chanceLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void NewTurn()
        {
            //increment turn counter
            turn++;
            if (turn == 14)
            {//ends game after 13 turns completed
                OnEnd();
            }
            else
            {//if game doesnt end, set up next turn with defaults
                rolls = 3;
                rollsDone = false;
                freezeMode = false;

                foreach (Dice Dice in diceList)
                {
                    Dice.frozen = false;
                    Dice.Roll();
                }

                dice1FrozenBox.BackColor = Color.Gold;
                dice2FrozenBox.BackColor = Color.Gold;
                dice3FrozenBox.BackColor = Color.Gold;
                dice4FrozenBox.BackColor = Color.Gold;
                dice5FrozenBox.BackColor = Color.Gold;

                categoryHighlight1.Visible = false;
                categoryHighlight2.Visible = false;
                Refresh();
            }
        }
    }
}
