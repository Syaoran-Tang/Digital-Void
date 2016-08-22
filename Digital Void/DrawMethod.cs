using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Digital_Void
{
    class DrawMethod            //绘制方法
    {
        private MainForm MainForm;
        public DrawMethod (MainForm form)
        {
            MainForm = form;
        }
        private PointF PointF(Vector3 A)
        {
            PointF result=new PointF();
            result.X=A.X;
            result.Y=A.Y;
            return result;
        }
        #region 坐标轴绘制
        public void DrawAxes(Graphics g)
        {
            Pen DrawXAxis = new Pen(Color.Red,1f);
            Pen DrawYAxis = new Pen(Color.Green, 1f);
            Pen DrawZAxis = new Pen(Color.Blue, 1f);
            Vector3 Opoint = new Vector3(0, 0, 0, 1);
            Vector3 Xpoint = new Vector3(100f, 0, 0, 1);
            Vector3 Ypoint = new Vector3(0, 100f, 0, 1);
            Vector3 Zpoint = new Vector3(0, 0, 100f, 1);

            Vector3 OpointView = Vector3.Transform3D_View(Opoint, MainForm);
            Vector3 XpointView = Vector3.Transform3D_View(Xpoint, MainForm);
            Vector3 YpointView = Vector3.Transform3D_View(Ypoint, MainForm);
            Vector3 ZpointView = Vector3.Transform3D_View(Zpoint, MainForm);
            PointF[] OXpoint = AxisPoint(OpointView, XpointView);
            PointF[] OYpoint = AxisPoint(OpointView, YpointView);
            PointF[] OZpoint = AxisPoint(OpointView, ZpointView);
            if (OXpoint[0].X !=-1)
                g.DrawLine(DrawXAxis, OXpoint[0], OXpoint[1]);
            if (OYpoint[0].X != -1)
                g.DrawLine(DrawYAxis, OYpoint[0], OYpoint[1]);
            if (OZpoint[0].X != -1)
                g.DrawLine(DrawZAxis, OZpoint[0], OZpoint[1]);

            //MainForm.StripStatusLabel.Text = OZpoint[0].X.ToString();
            //g.DrawLine(DrawXAxis, Opoint2D.X, Opoint2D.Y, Xpoint2D.X, Xpoint2D.Y);
            //g.DrawLine(DrawYAxis, Opoint2D.X, Opoint2D.Y, Ypoint2D.X, Ypoint2D.Y);
            //g.DrawLine(DrawZAxis, Opoint2D.X, Opoint2D.Y, Zpoint2D.X, Zpoint2D.Y);
            //g.DrawLine(DrawAxis, OXpoint[0], OXpoint[1]);
            DrawXAxis.Dispose();
            DrawYAxis.Dispose();
            DrawZAxis.Dispose();
        }
        public PointF[] AxisPoint(Vector3 O,Vector3 X)
        {
            float PanelHeight = MainForm.PlotPanel.Height;
            float PanelWidth = MainForm.PlotPanel.Width;
            PointF[]OXpoint=new PointF[2];
            Vector3 OX_Vector = X - O;
            if (OX_Vector.X == 0 && OX_Vector.Y != 0)
            {
                if (X.W == 0)
                    OXpoint[0].X = -1;
                else
                {
                    OXpoint[0].X = OXpoint[1].X = O.X;
                    OXpoint[0].Y = 0;
                    OXpoint[1].Y = PanelHeight;
                }
            }
            else if (OX_Vector.Y == 0 && OX_Vector.X != 0)
            {
                if (X.W == 0)
                    OXpoint[0].X = -1;
                else
                {
                    OXpoint[0].X = 0;
                    OXpoint[1].X = PanelWidth;
                    OXpoint[0].Y = OXpoint[1].Y = O.Y;
                }
            }
            else if (OX_Vector.Y == 0 && OX_Vector.X == 0)
            {
                if (X.W == 0)
                    OXpoint[0].X = -1;
                else
                {
                    OXpoint[0].X = OXpoint[1].X = O.X;
                    OXpoint[0].Y = OXpoint[1].Y = O.Y;
                }
            }
            else
            {
                float k=OX_Vector.Y/OX_Vector.X;
                int i=0;
                OXpoint[0].X = -1;
                if (-k * O.X + O.Y > 0 && -k * O.X + O.Y < PanelHeight)
                {
                    OXpoint[i].X = 0;
                    OXpoint[i].Y = -k * O.X + O.Y;
                    i++;
                }
                if (k * (PanelWidth - O.X) + O.Y > 0 && k * (PanelWidth - O.X) + O.Y < PanelHeight)
                {
                    OXpoint[i].X = PanelWidth;
                    OXpoint[i].Y = k * (PanelWidth - O.X) + O.Y;
                    i++;
                }
                if (-O.Y / k + O.X > 0 && -O.Y / k + O.X < PanelWidth)
                {
                    OXpoint[i].X = -O.Y / k + O.X;
                    OXpoint[i].Y = 0;
                    i++;
                }
                if ((PanelHeight - O.Y) / k + O.X > 0 && (PanelHeight - O.Y) / k + O.X < PanelWidth)
                {
                    OXpoint[i].X = (PanelHeight - O.Y) / k + O.X;
                    OXpoint[i].Y = PanelHeight;
                    i++;
                }
            }
            return OXpoint;
        }

        #endregion

        #region 实体绘制
        public void DrawEntity(Graphics g,Entity Object)
        {
            Pen DrawEntityPen = new Pen(Object.Color, 1f);
            Vector3 Center = Vector3.Transform3D_View(Object.Position, MainForm);
            /*
            Vector3 Arctic = new Vector3(Object.Position.X, Object.Position.Y, Object.Position.Z - Object.Radius, 1);
            Vector3 Antarctica = new Vector3(Object.Position.X, Object.Position.Y, Object.Position.Z + Object.Radius, 1);
            Vector3 Equator1 = new Vector3(Object.Position.X - Object.Radius, Object.Position.Y, Object.Position.Z, 1);
            Vector3 Equator2 = new Vector3(Object.Position.X + Object.Radius, Object.Position.Y, Object.Position.Z, 1);
            Vector3 Equator3 = new Vector3(Object.Position.X, Object.Position.Y - Object.Radius, Object.Position.Z, 1);
            Vector3 Equator4 = new Vector3(Object.Position.X, Object.Position.Y + Object.Radius, Object.Position.Z, 1);

            Vector3 NorthLatLine1 = new Vector3(Object.Position.X - Object.Radius/2, Object.Position.Y, Object.Position.Z+ Object.Radius/2, 1);
            Vector3 NorthLatLine2 = new Vector3(Object.Position.X + Object.Radius/2, Object.Position.Y + Object.Radius, Object.Position.Z+ Object.Radius/2, 1);
            Vector3 NorthLatLine3 = new Vector3(Object.Position.X, Object.Position.Y - Object.Radius/2, Object.Position.Z+ Object.Radius/2, 1);
            Vector3 NorthLatLine4 = new Vector3(Object.Position.X, Object.Position.Y + Object.Radius/2, Object.Position.Z+ Object.Radius/2, 1);
            Vector3 SouthLatLine1 = new Vector3(Object.Position.X- Object.Radius/2, Object.Position.Y, Object.Position.Z- Object.Radius/2, 1);
            Vector3 SouthLatLine2 = new Vector3(Object.Position.X+ Object.Radius/2, Object.Position.Y, Object.Position.Z- Object.Radius/2, 1);
            Vector3 SouthLatLine3 = new Vector3(Object.Position.X, Object.Position.Y - Object.Radius/2, Object.Position.Z- Object.Radius/2, 1);
            Vector3 SouthLatLine4 = new Vector3(Object.Position.X, Object.Position.Y + Object.Radius/2, Object.Position.Z- Object.Radius/2, 1);

            Vector3 ArcticView = Vector3.Transform3D_View(Arctic, MainForm);
            Vector3 AntarcticaView = Vector3.Transform3D_View(Antarctica, MainForm);
            Vector3 Equator1View = Vector3.Transform3D_View(Equator1, MainForm);
            Vector3 Equator2View = Vector3.Transform3D_View(Equator2, MainForm);
            Vector3 Equator3View = Vector3.Transform3D_View(Equator3, MainForm);
            Vector3 Equator4View = Vector3.Transform3D_View(Equator4, MainForm);

            Vector3 NorthLatLine1View = Vector3.Transform3D_View(NorthLatLine1, MainForm);
            Vector3 NorthLatLine2View = Vector3.Transform3D_View(NorthLatLine2, MainForm);
            Vector3 NorthLatLine3View = Vector3.Transform3D_View(NorthLatLine3, MainForm);
            Vector3 NorthLatLine4View = Vector3.Transform3D_View(NorthLatLine4, MainForm);
            Vector3 SouthLatLine1View = Vector3.Transform3D_View(SouthLatLine1, MainForm);
            Vector3 SouthLatLine2View = Vector3.Transform3D_View(SouthLatLine2, MainForm);
            Vector3 SouthLatLine3View = Vector3.Transform3D_View(SouthLatLine3, MainForm);
            Vector3 SouthLatLine4View = Vector3.Transform3D_View(SouthLatLine4, MainForm);
            
            PointF[] Equator = new PointF[] { PointF(Equator1View), PointF(Equator3View), PointF(Equator2View), PointF(Equator4View) };
            PointF[] Meridian = new PointF[] { PointF(ArcticView), PointF(Equator1View), PointF(AntarcticaView), PointF(Equator2View) };
            PointF[] SubMeridian = new PointF[] { PointF(ArcticView), PointF(Equator3View), PointF(AntarcticaView), PointF(Equator4View) };
            g.DrawClosedCurve(DrawEntity,Equator,1f,FillMode.Winding);
            g.DrawClosedCurve(DrawEntity, Meridian,1f, FillMode.Winding);
            g.DrawClosedCurve(DrawEntity, SubMeridian, 1f, FillMode.Winding);*/
            g.FillEllipse(new SolidBrush(Object.Color), Center.X - 3f, Center.Y - 3f, 6f, 6f);
            DrawEntityPen.Dispose();
        }
        #endregion

        #region 轨迹绘制

        #endregion


    }
}
