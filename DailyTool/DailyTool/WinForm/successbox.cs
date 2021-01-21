using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DailyTool.WinForm
{
    public partial class successbox : Form
    {
        string locc;
        public successbox(string dir)
        {
            InitializeComponent();
            locc = dir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SoundPlayer(".//sound/Click.wav").Play();
            Process.Start(@locc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SoundPlayer(".//sound/Click.wav").Play();
            Process.Start("explorer.exe","/select ,"+locc);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SoundPlayer(".//sound/Click.wav").Play();
            Close();
        }
    }
}
