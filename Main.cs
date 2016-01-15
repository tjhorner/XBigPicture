using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XInputDotNetPure;

namespace BigPictureOpener
{
    public partial class Main : Form
    {
        private bool shouldTrigger = true;
        private bool isEnabled = true;

        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GamePadState controller = GamePad.GetState(PlayerIndex.One);
            if (controller.IsConnected && isEnabled)
            {
                if (shouldTrigger && isEnabled)
                {
                    shouldTrigger = false;
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Steam\Steam.exe", "\"steam://open/bigpicture\"");
                }
            }
            else
            {
                shouldTrigger = true;
            }
        }

        private void toggleEnabled()
        {
            disableButton.Text = (isEnabled ? "Enable" : "Disable");
            disableToolStripMenuItem.Text = (isEnabled ? "Enable" : "Disable");
            isEnabled = !isEnabled;
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            toggleEnabled();
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleEnabled();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(3000, "Down here!", "Double click the XBigPicture icon in the taskbar to get back to settings.", ToolTipIcon.Info);
            this.Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
