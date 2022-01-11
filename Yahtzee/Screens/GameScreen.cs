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
                Dice dice = new Dice(randGen.Next(1,7));
                diceList.Add(dice);
            }

            //begin game loop
            gameTimer.Enabled = true;
        }

        private void OnEnd()
        {
            // Goes to the game over screen
            Form form = this.FindForm();

            GameOver go = new GameOver();
            go.Location = new Point((form.Width - go.Width) / 2, (form.Height - go.Height) / 2);

            form.Controls.Add(go);
            form.Controls.Remove(this);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            foreach (Dice dice in diceList)
            {
                dice.value = randGen.Next(1,7);
            }
        }
    }
}
