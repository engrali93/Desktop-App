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


namespace Word_to_Pdf_Converter.WinForm
{
    public partial class successbox : Form
    {
        string locc;
        public successbox(string dir)
        {
            InitializeComponent();
            new SoundPlayer(Word_to_Pdf_Converter.Properties.Resources.Windows_Exclamation).Play();
            locc = dir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var Clicksound = DailyTool.Properties.Resources.Click;
            //new SoundPlayer(Clicksound).Play();
            Process.Start(@locc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var Clicksound = DailyTool.Properties.Resources.Click;
            //new SoundPlayer(Clicksound).Play();
            Process.Start("explorer.exe","/select ,"+locc);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var Clicksound = DailyTool.Properties.Resources.Click;
            //new SoundPlayer(Clicksound).Play();
            Close();
        }

        private void successbox_Load(object sender, EventArgs e)
        {

        }
    }
}
