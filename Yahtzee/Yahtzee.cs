﻿/* Taiyo + Charlie
 * ICS4U
 * Mr. T
 * Date of Submission
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
using System.IO;

namespace Yahtzee
{
    public partial class Yahtzee : Form
    {
        public Yahtzee()
        {
            InitializeComponent();
            LoadScores();
        }

        public static List<Highscore> scores = new List<Highscore>();

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        private void LoadScores()
        {
            List<string> scoresStrings = File.ReadAllLines(Application.StartupPath + "/Resources/Highscores.txt").ToList();

            for (int i = 0; i < scoresStrings.Count; i += 2)
            {
                string name = scoresStrings[i];
                int score = Convert.ToInt32(scoresStrings[i + 1]);

                Highscore hs = new Highscore(name, score);
                scores.Add(hs);
            }
        }

        private void Yahtzee_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<string> tempList = new List<string>();
            foreach (Highscore hs in scores)
            {
                tempList.Add(hs.name);
                tempList.Add(Convert.ToString(hs.score));
                File.WriteAllLines(Application.StartupPath + "/Resources/Highscores.txt", tempList);
            }
        }
    }
}
