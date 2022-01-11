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
        List<Dice> diceList = new List<Dice> { };
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void OnStart()
        {
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

        }
    }
}
