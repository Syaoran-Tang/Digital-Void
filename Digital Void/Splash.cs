using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Void
{
    public partial class Splash : Form
    {
        private int i = 0;
        MainForm MainForm = new MainForm();
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashTimer.Start();
            this.Opacity = 0;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            if(i<10)
            {
                this.Opacity += 0.1;
            }
            else if(i==25)
            {
                MainForm.Show();
            }
            else if(i>=40&&i<50)
            {
                this.Opacity -= 0.1;
            }
            else if(i>=50)
            {
                SplashTimer.Stop();
                this.Hide();
            }
            i++;
        }
    }
}
