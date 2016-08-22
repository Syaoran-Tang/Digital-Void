using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Digital_Void
{
    public partial class EntityManager : Form
    {
        private MainForm MainForm;
        private int EntityCount=0;
        public Entity[] oriEntityGroup;
        private int DataCount=0;
        private bool DataSavingComplete = true;
        
        public EntityManager(MainForm Form)
        {
            InitializeComponent();
            MainForm = Form;
            
            this.Closing += new CancelEventHandler(EntityManager_Closing);
            listDataGridView.CellMouseClick += new DataGridViewCellMouseEventHandler(listDataGridView_CellMouseClick);
            listDataGridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(listDataGridView_CellMouseDoubleClick);
            listDataGridView.CellValidating += new DataGridViewCellValidatingEventHandler(listDataGridView_CellValidating);
        }

        private void EntityManager_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, MainForm.EntityGroup);
            ms.Position = 0;
            oriEntityGroup = (Entity[])bf.Deserialize(ms);
            EntityLoad(oriEntityGroup);
        }
        private void EntityManager_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            MainForm.MainMenu_EM.Checked = false;
        }
        private void listDataGridView_CellMouseClick(object sender, MouseEventArgs e)
        {
            if(!MainForm.EditMode)
            {
                int i = listDataGridView.CurrentCell.RowIndex;
                EM_Name.Text = MainForm.EntityGroup[i].Name.ToString();
                EM_Radius.Text = MainForm.EntityGroup[i].Radius.ToString();
                EM_Mass.Text = MainForm.EntityGroup[i].Mass.ToString();
                EM_PositionX.Text = MainForm.EntityGroup[i].Position.X.ToString();
                EM_PositionY.Text = MainForm.EntityGroup[i].Position.Y.ToString();
                EM_PositionZ.Text = MainForm.EntityGroup[i].Position.Z.ToString();
                EM_VelocityX.Text = MainForm.EntityGroup[i].Velocity.X.ToString();
                EM_VelocityY.Text = MainForm.EntityGroup[i].Velocity.Y.ToString();
                EM_VelocityZ.Text = MainForm.EntityGroup[i].Velocity.Z.ToString();
            }
            else
            {
                EM_Radius.ReadOnly = EM_Mass.ReadOnly =
                EM_PositionX.ReadOnly = EM_PositionY.ReadOnly = EM_PositionZ.ReadOnly =
                EM_VelocityX.ReadOnly = EM_VelocityY.ReadOnly = EM_VelocityZ.ReadOnly = true;
                int i = listDataGridView.CurrentCell.RowIndex;
                listDataGridView.Rows[i].ReadOnly = true;
                EM_Name.Text = oriEntityGroup[i].Name.ToString();
                EM_Radius.Text = oriEntityGroup[i].Radius.ToString();
                EM_Mass.Text = oriEntityGroup[i].Mass.ToString();
                EM_PositionX.Text = oriEntityGroup[i].Position.X.ToString();
                EM_PositionY.Text = oriEntityGroup[i].Position.Y.ToString();
                EM_PositionZ.Text = oriEntityGroup[i].Position.Z.ToString();
                EM_VelocityX.Text = oriEntityGroup[i].Velocity.X.ToString();
                EM_VelocityY.Text = oriEntityGroup[i].Velocity.Y.ToString();
                EM_VelocityZ.Text = oriEntityGroup[i].Velocity.Z.ToString();
            }
        }
        private void listDataGridView_CellMouseDoubleClick(object sender,MouseEventArgs e)
        {
            if(MainForm.EditMode)
            {
                int i = listDataGridView.CurrentCell.RowIndex;
                int j = listDataGridView.CurrentCell.ColumnIndex;
                if (j == 1)
                {
                    if (this.colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        listDataGridView.Rows[i].Cells[j].Style.SelectionBackColor = colorDialog.Color;
                        listDataGridView.Rows[i].Cells[j].Style.SelectionForeColor = colorDialog.Color;
                        listDataGridView.Rows[i].Cells[j].Style.BackColor = colorDialog.Color;
                        listDataGridView.Rows[i].Cells[j].Style.ForeColor = colorDialog.Color;
                    }
                }
                listDataGridView.Rows[i].ReadOnly = false;
                EM_Radius.ReadOnly = EM_Mass.ReadOnly =
                    EM_PositionX.ReadOnly = EM_PositionY.ReadOnly = EM_PositionZ.ReadOnly =
                    EM_VelocityX.ReadOnly = EM_VelocityY.ReadOnly = EM_VelocityZ.ReadOnly = false;
            }
        }
        private void listDataGridView_CellValidating(object sender,DataGridViewCellValidatingEventArgs e)
        {
            if (MainForm.EditMode)
            {
                int i = e.RowIndex;
                oriEntityGroup[i].Name = this.tempDataSet.List.Rows[i].ItemArray[1].ToString();
                oriEntityGroup[i].Color = ColorTranslator.FromHtml(this.tempDataSet.List.Rows[i].ItemArray[2].ToString());
                oriEntityGroup[i].Radius = float.Parse(EM_Radius.Text);
                oriEntityGroup[i].Mass = float.Parse(EM_Mass.Text);
                oriEntityGroup[i].Position.X = float.Parse(EM_PositionX.Text);
                oriEntityGroup[i].Position.Y = float.Parse(EM_PositionY.Text);
                oriEntityGroup[i].Position.Z = float.Parse(EM_PositionZ.Text);
                oriEntityGroup[i].Velocity.X = float.Parse(EM_VelocityX.Text);
                oriEntityGroup[i].Velocity.Y = float.Parse(EM_VelocityY.Text);
                oriEntityGroup[i].Velocity.Z = float.Parse(EM_VelocityZ.Text);
                /*
                MainForm.EntityGroup = new Entity[MainForm.EM.oriEntityGroup.Length];
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, oriEntityGroup);
                ms.Position = 0;
                MainForm.EntityGroup = (Entity[])bf.Deserialize(ms);*/
            }
        }
        private void EM_New_Click(object sender, EventArgs e)
        {
            this.Text = "实体管理(未保存)";
            int i = oriEntityGroup.Length;
            Array.Resize(ref oriEntityGroup, i + 1);
            oriEntityGroup[i] = new Entity();
            try
            {
                object[] rowArray = new object[5];
                rowArray[0] = oriEntityGroup.Length-1;
                rowArray[1] = oriEntityGroup[i].Name.ToString();
                rowArray[2] = ColorTranslator.ToHtml(oriEntityGroup[i].Color);
                rowArray[3] = oriEntityGroup[i].Radius;
                rowArray[4] = oriEntityGroup[i].Mass;
                TempDataSet.ListRow oneEntity = this.tempDataSet.List.NewListRow();
                oneEntity.ItemArray = rowArray;
                tempDataSet.List.AddListRow(oneEntity);
                //listBindingSource.AddNew();
                this.listTableAdapter.Update(this.tempDataSet.List);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            MainForm.EntityGroup = new Entity[MainForm.EM.oriEntityGroup.Length];
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, oriEntityGroup);
            ms.Position = 0;
            MainForm.EntityGroup = (Entity[])bf.Deserialize(ms);

            listDataGridView.Rows[i].ReadOnly = true;
            listDataGridView.Rows[i].Cells[1].Style.SelectionBackColor = oriEntityGroup[i].Color;
            listDataGridView.Rows[i].Cells[1].Style.SelectionForeColor = oriEntityGroup[i].Color;
            listDataGridView.Rows[i].Cells[1].Style.BackColor = oriEntityGroup[i].Color;
            listDataGridView.Rows[i].Cells[1].Style.ForeColor = oriEntityGroup[i].Color;
            EM_Radius.ReadOnly = EM_Mass.ReadOnly =
                    EM_PositionX.ReadOnly = EM_PositionY.ReadOnly = EM_PositionZ.ReadOnly =
                    EM_VelocityX.ReadOnly = EM_VelocityY.ReadOnly = EM_VelocityZ.ReadOnly = true;
        }

        private void EM_Delete_Click(object sender, EventArgs e)
        {
            this.Text = "实体管理(未保存)";
            int i;
            try
            {
                i = listDataGridView.CurrentRow.Index;
            }
            catch
            {
                MessageBox.Show("实体表为空！");
                return;
            }
            this.listTableAdapter.Delete(i, oriEntityGroup[i].Name, ColorTranslator.ToHtml(oriEntityGroup[i].Color), oriEntityGroup[i].Radius, oriEntityGroup[i].Mass);
            List<Entity> EntityList = oriEntityGroup.ToList();
            EntityList.RemoveAt(i);
            oriEntityGroup = EntityList.ToArray();
            //listBindingSource.RemoveAt(i);
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, oriEntityGroup);
            ms.Position = 0;
            MainForm.EntityGroup = (Entity[])bf.Deserialize(ms);
            MainForm.RefreshBackground();


            EntityCount = MainForm.EntityGroup.Length;
            tempDataSet.List.Clear();
            for (int j = 0; j < EntityCount; j++)
            {
                object[] rowArray = new object[5];
                rowArray[0] = j;
                rowArray[1] = oriEntityGroup[j].Name.ToString();
                rowArray[2] = ColorTranslator.ToHtml(oriEntityGroup[j].Color);
                rowArray[3] = oriEntityGroup[j].Radius;
                rowArray[4] = oriEntityGroup[j].Mass;
                TempDataSet.ListRow oneEntity = this.tempDataSet.List.NewListRow();
                oneEntity.ItemArray = rowArray;
                tempDataSet.List.AddListRow(oneEntity);
                listDataGridView.Rows[j].ReadOnly = true;
                listDataGridView.Rows[j].Cells[1].Style.SelectionBackColor = oriEntityGroup[j].Color;
                listDataGridView.Rows[j].Cells[1].Style.SelectionForeColor = oriEntityGroup[j].Color;
                listDataGridView.Rows[j].Cells[1].Style.BackColor = oriEntityGroup[j].Color;
                listDataGridView.Rows[j].Cells[1].Style.ForeColor = oriEntityGroup[j].Color;
            }
        }
        private void EM_Save_Click(object sender, EventArgs e)
        {
            if (EM_Radius.ReadOnly==false)
            {
                EM_Radius.ReadOnly = EM_Mass.ReadOnly =
                    EM_PositionX.ReadOnly = EM_PositionY.ReadOnly = EM_PositionZ.ReadOnly =
                    EM_VelocityX.ReadOnly = EM_VelocityY.ReadOnly = EM_VelocityZ.ReadOnly = true;
                int i = listDataGridView.CurrentRow.Index;
                oriEntityGroup[i].Name = this.tempDataSet.List.Rows[i].ItemArray[1].ToString();
                oriEntityGroup[i].Color = ColorTranslator.FromHtml(this.tempDataSet.List.Rows[i].ItemArray[2].ToString());
                oriEntityGroup[i].Radius = float.Parse(EM_Radius.Text);
                oriEntityGroup[i].Mass = float.Parse(EM_Mass.Text);
                oriEntityGroup[i].Position.X = float.Parse(EM_PositionX.Text);
                oriEntityGroup[i].Position.Y = float.Parse(EM_PositionY.Text);
                oriEntityGroup[i].Position.Z = float.Parse(EM_PositionZ.Text);
                oriEntityGroup[i].Velocity.X = float.Parse(EM_VelocityX.Text);
                oriEntityGroup[i].Velocity.Y = float.Parse(EM_VelocityY.Text);
                oriEntityGroup[i].Velocity.Z = float.Parse(EM_VelocityZ.Text);
            }
            try
            {
                this.listTableAdapter.Update(this.tempDataSet.List);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
           
            this.Text = "实体管理";
            MainForm.EntityGroup = new Entity[MainForm.EM.oriEntityGroup.Length];
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, oriEntityGroup);
            ms.Position = 0;
            MainForm.EntityGroup = (Entity[])bf.Deserialize(ms);

            MainForm.RefreshBackground();
        }
        public void EntityLoad(Entity[] EntityGroup)
        {
            EntityCount = EntityGroup.Length;
            tempDataSet.List.Clear();
            if (EntityCount>0)
            {
                for (int i = 0; i < EntityCount; i++)
                {
                    object[] rowArray = new object[5];
                    rowArray[0] = i;
                    rowArray[1] = EntityGroup[i].Name.ToString();
                    rowArray[2] = ColorTranslator.ToHtml(EntityGroup[i].Color);
                    rowArray[3] = EntityGroup[i].Radius;
                    rowArray[4] = EntityGroup[i].Mass;
                    TempDataSet.ListRow oneEntity = this.tempDataSet.List.NewListRow();
                    oneEntity.ItemArray = rowArray;
                    tempDataSet.List.AddListRow(oneEntity);
                    listDataGridView.Rows[i].ReadOnly = true;
                    listDataGridView.Rows[i].Cells[1].Style.SelectionBackColor = EntityGroup[i].Color;
                    listDataGridView.Rows[i].Cells[1].Style.SelectionForeColor = EntityGroup[i].Color;
                    listDataGridView.Rows[i].Cells[1].Style.BackColor = EntityGroup[i].Color;
                    listDataGridView.Rows[i].Cells[1].Style.ForeColor = EntityGroup[i].Color;
                }
                listTableAdapter.Update(tempDataSet.List);

                EM_Name.Text = oriEntityGroup[0].Name.ToString();
                EM_Radius.Text = oriEntityGroup[0].Radius.ToString();
                EM_Mass.Text = oriEntityGroup[0].Mass.ToString();
                EM_PositionX.Text = oriEntityGroup[0].Position.X.ToString();
                EM_PositionY.Text = oriEntityGroup[0].Position.Y.ToString();
                EM_PositionZ.Text = oriEntityGroup[0].Position.Z.ToString();
                EM_VelocityX.Text = oriEntityGroup[0].Velocity.X.ToString();
                EM_VelocityY.Text = oriEntityGroup[0].Velocity.Y.ToString();
                EM_VelocityZ.Text = oriEntityGroup[0].Velocity.Z.ToString();
            }
        }
        public void EntityUpdate(Entity[] EntityGroup)
        {
            int i = listDataGridView.CurrentRow.Index;
            EM_PositionX.Text = EntityGroup[i].Position.X.ToString();
            EM_PositionY.Text = EntityGroup[i].Position.Y.ToString();
            EM_PositionZ.Text = EntityGroup[i].Position.Z.ToString();
            EM_VelocityX.Text = EntityGroup[i].Velocity.X.ToString();
            EM_VelocityY.Text = EntityGroup[i].Velocity.Y.ToString();
            EM_VelocityZ.Text = EntityGroup[i].Velocity.Z.ToString();
            /*if(DataSavingComplete)
            {
                EMBackGroundWorker.RunWorkerAsync();
            }
            else
            {
                MainForm.timer.Enabled = false;
                MainForm.TimePauseSpan = TimeSpan.Parse(MainForm.TimeLabel.Text);
                MainForm.IsPaused = true;
                MainForm.DataSubStripStatusLabel.Text = "(非实时)(处理数据中...";
            }*/
        }

        private void EMBackGroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSavingComplete = false;
            if(DataCount<1000)
            {
                if(DataCount==0)
                {
                    tempDataSet.Data2.Clear();
                }
                for(int i=0;i<MainForm.EntityGroup.Length;i++)
                {
                    data1TableAdapter.InsertData(MainForm.SpanDateTime.ToString("HH:mm:ss.fff"), i, 
                        MainForm.EntityGroup[i].Position.X, MainForm.EntityGroup[i].Position.Y, MainForm.EntityGroup[i].Position.Z,
                        MainForm.EntityGroup[i].Velocity.X, MainForm.EntityGroup[i].Velocity.Y, MainForm.EntityGroup[i].Velocity.Z);
                    EMBackGroundWorker.ReportProgress(i / 1000);
                }
            }
            else if (DataCount >= 1000 && DataCount < 2000)
            {
                if (DataCount==1000)
                {
                    tempDataSet.Data1.Clear();
                }
                for (int i = 0; i < MainForm.EntityGroup.Length; i++)
                {
                    data2TableAdapter.InsertData(MainForm.SpanDateTime.ToString("HH:mm:ss.fff"), i,
                        MainForm.EntityGroup[i].Position.X, MainForm.EntityGroup[i].Position.Y, MainForm.EntityGroup[i].Position.Z,
                        MainForm.EntityGroup[i].Velocity.X, MainForm.EntityGroup[i].Velocity.Y, MainForm.EntityGroup[i].Velocity.Z);
                    EMBackGroundWorker.ReportProgress((i-1000) / 1000);
                }
            }
            DataCount++;
            if(DataCount==2000)
            {
                DataCount = 0;
            }
        }
        private void EMBackGroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            MainForm.DataSubStripStatusLabel.Text = "(非实时)(处理数据中..." + e.ProgressPercentage.ToString() + "%)";
        }
        private void EMBackGroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DataSavingComplete = true;
            MainForm.DataSubStripStatusLabel.Text = "(非实时)";
            if (MainForm.IsPaused)
            {
                MainForm.StartTime = DateTime.Now.Add(TimeSpan.Zero - MainForm.TimePauseSpan);
                MainForm.TimePauseSpan = TimeSpan.Zero;
                MainForm.timer.Enabled = true;
                MainForm.IsPaused = false;
            }
        }
    }
}
