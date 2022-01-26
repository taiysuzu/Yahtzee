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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //starts game / opens game screen
            Form form = this.FindForm();

            GameScreen gs = new GameScreen();
            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }

        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            //opens instructions
            Form form = this.FindForm();

            HowToPlayScreen htps = new HowToPlayScreen();
            htps.Location = new Point((form.Width - htps.Width) / 2, (form.Height - htps.Height) / 2);

            form.Controls.Add(htps);
            form.Controls.Remove(this);
        }

        private void highscoreButton_Click(object sender, EventArgs e)
        {
            //opens high scores
            Form form = this.FindForm();

            HighscoreScreen hs = new HighscoreScreen();
            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);

            form.Controls.Add(hs);
            form.Controls.Remove(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //quits the game
            Application.Exit();   
        }
    }
}
