/* Taiyo + Charlie
 * Yahtzee
 * ICS4U
 * Mr. T
 * Jan 26, 2022
 */
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

            //reset game values
            score = 0;

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
                dice1FrozenBox.Visible = true;
                dice2FrozenBox.Visible = true;
                dice3FrozenBox.Visible = true;
                dice4FrozenBox.Visible = true;
                dice5FrozenBox.Visible = true;
                rollButton.Enabled = false;
                topLabel.Text = "Click a Die To Freeze It!";
            }
            else
            {

                for (int i = 0; i < 5; i++)
                {
                    if (diceList[i].frozen == false)
                    {
                        diceFrozenBoxList[i].Visible = false;
                    }
                }
                rollButton.Enabled = true;

                topLabel.Text = "Roll The Dice!";
            }

            if (rollsDone == true)
            {
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
            {
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
                topLabel.Text = "Roll The Dice!";
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < diceBoxList.Count; i++)
            {
                //paints dice images based on dice values
                diceBoxList[i].BackgroundImage = diceImageList[diceList[i].value - 1];
            }

            //displays which turn the player is on
            turnLabel.Text = $"Turn: {turn}/13 \nRolls: {rolls}/3";
        }

        #region Button Click Methods
        private void rollButton_Click(object sender, EventArgs e)
        {
            foreach (Dice dice in diceList)
            {
                //randomize dice values (roll the dice)
                dice.Roll();
            }

            //gets rid of one rolls until there are no left, then starting the next part of the turn
            rolls--;
            if (rolls == 0)
            {
                rollsDone = true;
            }
            Refresh();
        }

        private void freezeButton_Click(object sender, EventArgs e)
        {
            //changes so that the butons are able to be frozen
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

                HighscoreScreen hh = new HighscoreScreen();
                hh.Location = new Point((form.Width - hh.Width) / 2, (form.Height - hh.Height) / 2);

                form.Controls.Add(hh);
                form.Controls.Remove(this);
            }
            else
            {
                //If the bame entered is invalid, tells the player to re enter a name
                nameEntryLabel.Text += $"\n\n\n\n\n\n\n\n\nPlease enter 3 uppercase characters.";
            }
        }

        private void test_Endgame_Click(object sender, EventArgs e)
        {
            OnEnd();
        }
        #endregion

        #region Dice Box Click Methods
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
        private void acesLabel_Click(object sender, EventArgs e)
        {
            List<Dice> aces = diceList.FindAll(a => a.value == 1);
            acesLabel.Text = aces.Count.ToString();
            NewTurn();
        }

        private void twosLabel_Click(object sender, EventArgs e)
        {
            List<Dice> twos = diceList.FindAll(a => a.value == 2);
            twosLabel.Text = (twos.Count * 2).ToString();
            NewTurn();
        }

        private void threesLabel_Click(object sender, EventArgs e)
        {
            List<Dice> threes = diceList.FindAll(a => a.value == 3);
            threesLabel.Text = (threes.Count * 3).ToString();
            NewTurn();
        }

        private void foursLabel_Click(object sender, EventArgs e)
        {
            List<Dice> fours = diceList.FindAll(a => a.value == 4);
            foursLabel.Text = (fours.Count * 4).ToString();
            NewTurn();
        }

        private void fivesLabel_Click(object sender, EventArgs e)
        {
            List<Dice> fives = diceList.FindAll(a => a.value == 5);
            fivesLabel.Text = (fives.Count * 5).ToString();
            NewTurn();
        }

        private void sixesLabel_Click(object sender, EventArgs e)
        {
            List<Dice> sixes = diceList.FindAll(a => a.value == 6);
            sixesLabel.Text = (sixes.Count * 6).ToString();
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
            //Adds to the turn counter
            turn++;
            if (turn == 14)
            {
                //ends the game after 13 turns
                OnEnd();
            }
            else
            {
                //Restarts the board for the next round
                rolls = 3;
                rollsDone = false;
                freezeMode = false;

                foreach (Dice Dice in diceList)
                {
                    Dice.frozen = false;
                }

                dice1FrozenBox.BackColor = Color.Gold;
                dice2FrozenBox.BackColor = Color.Gold;
                dice3FrozenBox.BackColor = Color.Gold;
                dice4FrozenBox.BackColor = Color.Gold;
                dice5FrozenBox.BackColor = Color.Gold;
                categoryHighlight1.BackColor = Color.Gold;
                categoryHighlight2.BackColor = Color.Gold;
                Refresh();
            }

        }

    }
}
