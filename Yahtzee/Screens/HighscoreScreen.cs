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
    public partial class HighscoreScreen : UserControl
    {
        public HighscoreScreen()
        {
            InitializeComponent();
            SortScores();
        }

        private void SortScores()
        {   //sort scores
            Yahtzee.scores = Yahtzee.scores.OrderByDescending(x => x.score).ThenBy(x => x.name).ToList();

            while (Yahtzee.scores.Count > 10)   //remove smallest score if more than 10 scores are saved
            {
                Yahtzee.scores.RemoveAt(10);
            }

            highScoreLabel.Text = "\n \n";         //display scores to highscore screen

            foreach (Highscore hs in Yahtzee.scores)
            {
                highScoreLabel.Text += $"{hs.name} {hs.score}\n";
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();

            MenuScreen ms = new MenuScreen();
            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

            form.Controls.Add(ms);
            form.Controls.Remove(this);
        }
    }
}
