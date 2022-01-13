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
        Random randGen = new Random();

        //lists
        List<Dice> diceList = new List<Dice> { };

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
            for (int i = 0; i < 6; i++)
            {
                Dice dice = new Dice(randGen.Next(1, 7));
                diceList.Add(dice);
            }

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

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            foreach (Dice dice in diceList)
            {
                //randomize dice values (roll the dice)
                dice.value = randGen.Next(1, 7);
            }
        }

        private void test_Endgame_Click(object sender, EventArgs e)
        {
            OnEnd();
        }
    }
}
