using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Digital_Void
{
    public partial class PlayControl : Form
    {
        public MainForm MainForm;
        public PlayControl(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            this.Closing += new CancelEventHandler(PlayControl_Closing); 
        }

        private void PC_Play_Click(object sender, EventArgs e)
        {
            if(MainForm.EntityGroup.Length==0)
            {
                MessageBox.Show("实体集为空！计算已取消", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!MainForm.IsPaused&&!MainForm.timer.Enabled)//Start from 00:00:00
            {
                MainForm.StartTime = DateTime.Now;
                MainForm.TimePauseSpan = TimeSpan.Zero;
                MainForm.timer.Enabled = true;
                this.PC_Play.Text = "暂停";
                MainForm.StripStatusLabel.Text = "模拟中...";
                MainForm.EditMode = false;
                MainForm.EM.EM_New.Enabled = MainForm.EM.EM_Delete.Enabled = MainForm.EM.EM_Save.Enabled = false;
            }
            else if (MainForm.timer.Enabled && !MainForm.MFBackGroundWorker.IsBusy)   //pause
            {
                MainForm.timer.Enabled = false;
                MainForm.TimePauseSpan = TimeSpan.Parse(MainForm.TimeLabel.Text);
                MainForm.IsPaused = true;
                this.PC_Play.Text = "继续";
                MainForm.StripStatusLabel.Text = "模拟已暂停";
            }
            else if (MainForm.timer.Enabled && MainForm.MFBackGroundWorker.IsBusy)
            {

                MainForm.timer.Enabled = false;
                MainForm.TimePauseSpan = TimeSpan.Parse(MainForm.TimeLabel.Text);
                MainForm.IsPaused = true;
                this.PC_Play.Text = "继续";
                MainForm.StripStatusLabel.Text = "模拟已暂停";
                MainForm.MFBackGroundWorker.CancelAsync();
            }
            else if(!MainForm.timer.Enabled && MainForm.MFBackGroundWorker.IsBusy)
            {
                this.PC_Play.Text = "继续";
                MainForm.StripStatusLabel.Text = "模拟已暂停";
                MainForm.MFBackGroundWorker.CancelAsync();
            }
            else      //Start after pause
            {
                MainForm.StartTime = DateTime.Now.Add(TimeSpan.Zero - MainForm.TimePauseSpan);
                MainForm.TimePauseSpan = TimeSpan.Zero;
                MainForm.timer.Enabled = true;
                MainForm.IsPaused = false;
                this.PC_Play.Text = "暂停";
                MainForm.StripStatusLabel.Text = "模拟中...";
            }
            
        }


        public void PC_End_Click(object sender, EventArgs e)
        {
            if (MainForm.timer.Enabled || MainForm.IsPaused)
            {
                MainForm.timer.Enabled = false;
                if (!MainForm.IsPaused)
                    MainForm.TotalSpan = DateTime.Now - MainForm.StartTime;
                else
                {
                    MainForm.TotalSpan = MainForm.TimePauseSpan;
                    MainForm.IsPaused = false;
                }

                MainForm.SpanDateTime = new DateTime(MainForm.TotalSpan.Ticks);
                MainForm.LastTimeSpan = TimeSpan.Zero;
                MainForm.TimeLabel.Text = "00:00:00.00";
                this.PC_Play.Text = "开始";
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, MainForm.EM.oriEntityGroup);
                ms.Position = 0;
                MainForm.EntityGroup = (Entity[])bf.Deserialize(ms);
                MainForm.EM.EntityUpdate(MainForm.EntityGroup);
                MainForm.RefreshBackground();
                MainForm.StripStatusLabel.Text = "准备就绪...";
                MainForm.StripProgressBar.Value = 0;
                MainForm.EditMode = true;
                MainForm.EM.EM_New.Enabled = MainForm.EM.EM_Delete.Enabled = MainForm.EM.EM_Save.Enabled = true;
            }
        }
        private void PlayControl_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            MainForm.MainMenu_PC.Checked = false;
        }
        public void PlayPress()
        {
            PC_Play_Click(null, null);
        }

        public void StopPress()
        {
            PC_End_Click(null, null);
        }
    }
}
