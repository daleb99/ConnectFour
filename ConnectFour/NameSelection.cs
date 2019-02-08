using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class NameSelection : Form
    {
        public NameSelection()
        {
            InitializeComponent();
        }
        private void BtnNameEnter_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Check we have a name for both players
            if (TxtName1.Text.Trim() == string.Empty || TxtName2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Pleae enter a name for BOTH players");
                this.Show();
                return;
            }

            // Create a new game to be played
            C4Game game = new C4Game(TxtName1.Text, TxtName2.Text);
            game.init();
        }
    }
}
