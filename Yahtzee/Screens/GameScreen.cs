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

        //roll counter
        int rolls = 0;

        //lists
        List<Dice> diceList = new List<Dice>();
        List<PictureBox> diceBoxList = new List<PictureBox>();
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

            //add all dice picture boxes to list
            diceBoxList.Add(diceBox1);
            diceBoxList.Add(diceBox2);
            diceBoxList.Add(diceBox3);
            diceBoxList.Add(diceBox4);
            diceBoxList.Add(diceBox5);

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
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < diceBoxList.Count; i++)
            {
                //paints dice images based on dice values
                diceBoxList[i].BackgroundImage = diceImageList[diceList[i].value - 1];
            }
        }

        #region Button Click Methods
        private void rollButton_Click(object sender, EventArgs e)
        {
            foreach (Dice dice in diceList)
            {
                //randomize dice values (roll the dice)
                dice.Roll();
                rolls++;
                if (rolls == 3)
                {
                    rollsDone = true;
                    rolls = 0;
                }
            }
            Refresh();
        }

        private void nameInputButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Length == 3)
            {
                //saves name and score to highscore object
                name = nameInput.Text.ToUpper();

                Highscore hs = new Highscore(name, score);
                Yahtzee.scores.Add(hs);

                // Goes to the game over screen
                Form form = this.FindForm();

                GameOver go = new GameOver();
                go.Location = new Point((form.Width - go.Width) / 2, (form.Height - go.Height) / 2);

                form.Controls.Add(go);
                form.Controls.Remove(this);
            }
            else
            {
                nameEntryLabel.Text += $"\n\n\n\n\n\n\n\n\nPlease enter 3 uppercase characters.";
            }
        }

        private void test_Endgame_Click(object sender, EventArgs e)
        {
            OnEnd();
        }
        #endregion

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
