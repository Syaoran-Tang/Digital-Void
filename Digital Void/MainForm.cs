using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Digital_Void
{
    public partial class MainForm : Form
    {
        private DrawMethod dm;
        private Graphics gB;
        private Bitmap bitmap, bm;
        private EntityEvolution ee;

        private bool CatchStart = false;
        private Point DownPoint = Point.Empty;    
        public float Azimuth;
        public float Elevation;
        private float DeltaAzimuth = 0;
        private float DeltaElevation = 0;
        public float ViewX = 0;
        public float ViewY = 0;
        private float DeltaViewX = 0;
        private float DeltaViewY = 0;
        public Vector3 ViewPosition = new Vector3(50,50,50,1);
        public Vector3 ViewAngle = new Vector3(45,0,45,1);

        private Point Panel_Position = new Point();
        private Point EM_Position = new Point();
        private Point PC_Position = new Point();
        public EntityManager EM;
        public PlayControl PC;
        private About About=new About();

        public DateTime StartTime;
        public TimeSpan TimePauseSpan;
        public DateTime SpanDateTime;
        public TimeSpan Span;
        public TimeSpan LastTimeSpan;
        public TimeSpan TotalSpan;
        public bool IsPaused = false;

        public bool EditMode = true;
        public Entity[] EntityGroup;
        /*public Entity Test1 = new Entity();
        public Entity Test2 = new Entity();
        public Entity Test3 = new Entity();*/
        private int EvolutionSum=1000;
        public bool EvolutionComplete = true;
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.InitialBitmap();
            dm = new DrawMethod(this);
            ee = new EntityEvolution(this);
            this.PlotPanel.MouseDown += new MouseEventHandler(P_MouseDown);
            this.PlotPanel.MouseMove += new MouseEventHandler(P_MouseMove);
            this.PlotPanel.MouseUp += new MouseEventHandler(P_MouseUp);
            MouseWheel += new MouseEventHandler(P_MouseWheel);

            this.timer.Enabled = false;
            this.timer.Interval = 1;
            
            /*Test1.Name = "实体1";
            Test1.Color = Color.Red;
            Test1.Position = new Vector3(20, 0, 0, 1);
            Test1.Velocity = new Vector3(0, 20, 0, 1);
            Test1.Mass = 100f;
            Test1.Radius = 45f;

            Test2.Name = "实体2";
            Test2.Color = Color.Blue;
            Test2.Position = new Vector3(-20, 0, 0, 1);
            Test2.Velocity = new Vector3(0, -20, 0, 1);
            Test2.Mass = 100f;
            Test2.Radius = 45f;

            Test3.Name = "实体3";
            Test3.Color = Color.Black;
            Test3.Position = new Vector3(0, 20, 20, 1);
            Test3.Velocity = new Vector3(0, 0, 0, 1);
            Test3.Mass = 100f;
            Test3.Radius = 45f;*/
            EntityGroup = new Entity[] { };

            EM = new EntityManager(this);
            PC = new PlayControl(this);
            Panel_Position = this.PointToScreen(PlotPanel.Location);
            EM_Position.X = Panel_Position.X + this.PlotPanel.Width - 185;
            EM_Position.Y = Panel_Position.Y;
            PC_Position.X = Panel_Position.X;
            PC_Position.Y = Panel_Position.Y + this.PlotPanel.Height - 100;
            EM.Location = EM_Position;
            PC.Location = PC_Position;
            
        }
        private void DrawPlot(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            dm.DrawAxes(g);
            int Num = EntityGroup.Length;
            for (int i = 0; i < Num;i++ )
            {
                dm.DrawEntity(g, EntityGroup[i]);
            }
        }
        private void InitialBitmap()
        {
            //Define bitmap
            Size size = new Size(PlotPanel.Width, PlotPanel.Height);
            bitmap = new Bitmap(size.Width, size.Height);
            gB = Graphics.FromImage(bitmap);
        }
        public void RefreshBackground()
        {
            gB.Clear(this.PlotPanel.BackColor);
            DrawPlot(gB);
            Size sz = this.PlotPanel.Size;
            Rectangle rt = new Rectangle(0, 0, sz.Width, sz.Height);
            bm = bitmap.Clone(rt, bitmap.PixelFormat);
            PlotPanel.BackgroundImage = bm;
            StatusLabel_Loacl.Text = ((int)ViewPosition.X).ToString() + "," + ((int)ViewPosition.Y).ToString() + "," + ((int)ViewPosition.Z).ToString();
            StatusLabel_Angle.Text = ((int)ViewAngle.X).ToString() + "," + ((int)ViewAngle.Y).ToString() + "," + ((int)ViewAngle.Z).ToString();
        }

        #region 鼠标控制方法
        private void P_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !CatchStart)
            {
                //CatchStart = true;
                DownPoint = new Point(e.X, e.Y);
            }
        }
        private void P_MouseMove(object sender, MouseEventArgs e)
        {
            if (CatchStart)
            {
                float R=(float) Math.Sqrt(ViewPosition.X*ViewPosition.X+ViewPosition.Y*ViewPosition.Y+ViewPosition.Z*ViewPosition.Z);
                Azimuth = (float)Math.Atan(ViewPosition.Y / ViewPosition.X);
                Elevation = (float)Math.Atan(ViewPosition.Z / (Math.Sqrt(ViewPosition.Y * ViewPosition.Y + ViewPosition.X * ViewPosition.X)));
                DeltaAzimuth = (e.X - DownPoint.X)/100f;
                DeltaElevation = (e.Y - DownPoint.Y)/100f;
                Azimuth += DeltaAzimuth;
                Elevation += DeltaElevation;
                if (Azimuth > 180)
                    Azimuth = -180;
                else if (Azimuth < -180)
                    Azimuth = 180;
                if (Elevation > 90)
                    Elevation = -90;
                else if (Elevation < -90)
                    Elevation = 90;
                ViewPosition.X = R * (float)Math.Cos(Elevation) * (float)Math.Cos(Azimuth);
                ViewPosition.Y = R * (float)Math.Cos(Elevation) * (float)Math.Sin(Azimuth);
                ViewPosition.Z = R * (float)Math.Sin(Elevation);
                //ViewAngle.X=;
               // ViewAngle.Y=;
                //ViewAngle.Z=;
                this.RefreshBackground();
            }
        }
        private void P_MouseUp(object sender, MouseEventArgs e)
        {
           CatchStart = false;
           DownPoint = Point.Empty;
           DeltaAzimuth = DeltaElevation = 0;
           DeltaViewY = DeltaViewX = 0;
        }
        private void P_MouseWheel(object sender, MouseEventArgs e)
        {
            /*float multiples = 1;
            if (e.Delta > 0)
                multiples = -1f;
            else
                multiples = 1f;
            ViewPosition.X = ViewPosition.X - multiples;
            ViewPosition.Y = ViewPosition.Y - multiples;
            ViewPosition.Z = ViewPosition.Z - multiples;
            this.RefreshBackground();*/
        }
        #endregion
        private void MainForm_Resize(object sender, EventArgs e)
        {
            InitialBitmap();
            this.RefreshBackground();
            this.Panel_Position = this.PointToScreen(PlotPanel.Location);
            EM_Position.X = Panel_Position.X + this.PlotPanel.Width - 185;
            EM_Position.Y = Panel_Position.Y;
            PC_Position.X = Panel_Position.X;
            PC_Position.Y = Panel_Position.Y + this.PlotPanel.Height - 100;
            EM.Location = EM_Position;
            PC.Location = PC_Position;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshBackground();
            this.Resize += new EventHandler(MainForm_Resize);
            EM.Show();
            PC.Show();
        }
        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if(EvolutionComplete)
            {
                MFBackGroundWorker.RunWorkerAsync();
            }
            else
            {
                timer.Enabled = false;
                TimePauseSpan = TimeSpan.Parse(TimeLabel.Text);
                IsPaused = true;
                StripStatusLabel.Text += "(非实时)";
                return;
            }
            EM.EntityUpdate(EntityGroup);
            this.RefreshBackground();
            Span = (DateTime.Now - StartTime).Add(this.TimePauseSpan);       //Use system time to calcuate the TimeSpan
            SpanDateTime = new DateTime(Span.Ticks);
            this.TimeLabel.Text = SpanDateTime.ToString("HH:mm:ss.ff");
        }


        #region 主菜单功能
        private void MainMenu_EM_Click(object sender, EventArgs e)
        {
            if (MainMenu_EM.Checked==true)
            { 
                EM.Hide();
                MainMenu_EM.Checked = false;
            }
            else
            {
                EM.Show();
                MainMenu_EM.Checked = true;
            }
            
        }
        private void MainMenu_PC_Click(object sender, EventArgs e)
        {
            if (MainMenu_PC.Checked == true)
            {
                PC.Hide();
                MainMenu_PC.Checked = false;
            }
            else
            {
                PC.Show();
                MainMenu_PC.Checked = true;
            }
        }
        private void MainMenu_About_Click(object sender, EventArgs e)
        {
            About.Show();
        }
        private void SingleCheck(object sender)   
        {
            中心固定ToolStripMenuItem.Checked = false;
            视点固定ToolStripMenuItem.Checked = false;
            追随实体ToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }
        private void 中心固定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
        }
        private void 视点固定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
        }
        private void 追随实体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
        }
        private void 导入数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 导出数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 导出实体文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog SaveFileDialog = new SaveFileDialog();

            SaveFileDialog.InitialDirectory = Application.StartupPath;
            SaveFileDialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            SaveFileDialog.FilterIndex = 1;
            SaveFileDialog.RestoreDirectory = true;

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = SaveFileDialog.OpenFile()) != null)
                {
                    IFormatter formater = new BinaryFormatter();
                    formater.Serialize(myStream, EntityGroup);
                    myStream.Close();
                }
            }
        }
        private void 导入实体文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            OpenFileDialog.InitialDirectory = Application.StartupPath;
            OpenFileDialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            OpenFileDialog.FilterIndex = 1;
            OpenFileDialog.RestoreDirectory = true;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = OpenFileDialog.OpenFile()) != null)
                {
                    IFormatter formater = new BinaryFormatter();
                    EntityGroup = (Entity[])formater.Deserialize(myStream);
                    myStream.Close();
                }
            }
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, EntityGroup);
            ms.Position = 0;
            EM.oriEntityGroup = (Entity[])bf.Deserialize(ms);
            EM.EntityLoad(EntityGroup);
            this.RefreshBackground();
        }
        #endregion


        private void MFBackGroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            EvolutionComplete = false;
            for (int i = 0; i < EvolutionSum;i++ )
            {
                if (MFBackGroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    ee.Evolution(EntityGroup);
                    MFBackGroundWorker.ReportProgress(100 * i / EvolutionSum);
                }
            }
        }
        private void MFBackGroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            StripProgressBar.Value = e.ProgressPercentage;
        }
        private void MFBackGroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                EvolutionComplete = true;
                StripStatusLabel.Text = "模拟已暂停...";
            }
            else
            {
                EvolutionComplete = true;
                StripStatusLabel.Text = "模拟中...";
                if (IsPaused)
                {
                    StartTime = DateTime.Now.Add(TimeSpan.Zero - TimePauseSpan);
                    TimePauseSpan = TimeSpan.Zero;
                    timer.Enabled = true;
                    IsPaused = false;
                }
            }
        }
    }
}
