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
    public partial class HowToPlayScreen : UserControl
    {
        public HowToPlayScreen()
        {
            InitializeComponent();
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
