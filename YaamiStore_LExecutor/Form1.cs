using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace YaamiStore_LExecutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.GetProcessesByName("Minecraft.Windows")[0].Kill();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MCM.openGame();
            MCM.openWindowHost();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("minecraft://");
            }
            catch
            {
                button4_Click(sender, e);
            }
        }
    }
}
