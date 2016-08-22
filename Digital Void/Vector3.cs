using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Void
{
    [Serializable]
    public class Vector3 
    {
        public float X;
        public float Y;
        public float Z;
        public float W;
        public Vector3 ()
        {
            X = Y = Z = 0;
            W = 1f;
        }
        public Vector3(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            Vector3 result = new Vector3();
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;
            result.Z = a.Z + b.Z;
            return result;
        }
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            Vector3 result = new Vector3();
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
            result.Z = a.Z - b.Z;
            return result;
        }
       /* public static Vector3 operator *(Matrix3 m, Vector3 p)
        {
            Vector3 result=new Vector3();
            result.X = m.M[0, 0] * p.X + m.M[0, 1] * p.Y + m.M[0, 2] * p.Z + m.M[0, 3] * p.W;
            result.Y = m.M[1, 0] * p.X + m.M[1, 1] * p.Y + m.M[1, 2] * p.Z + m.M[1, 3] * p.W;
            result.Z = m.M[2, 0] * p.X + m.M[2, 1] * p.Y + m.M[2, 2] * p.Z + m.M[2, 3] * p.W;
            result.W = m.M[3, 0] * p.X + m.M[3, 1] * p.Y + m.M[3, 2] * p.Z + m.M[3, 3] * p.W;
            return result;
        }*/
        public static Vector3 Transform3D_2D(Vector3 ViewAngle, Vector3 Distance)
        {
            Vector3 ViewVector=new Vector3();
            float a=Distance.X;
            float b=Distance.Y;
            float c=Distance.Z;
            float sinX = (float)Math.Sin(Math.PI * ViewAngle.X / 180);
            float cosX = (float)Math.Cos(Math.PI * ViewAngle.X / 180);
            float sinY = (float)Math.Sin(Math.PI * ViewAngle.Y / 180);
            float cosY = (float)Math.Cos(Math.PI * ViewAngle.Y / 180);
            float sinZ = (float)Math.Sin(Math.PI * ViewAngle.Z / 180);
            float cosZ = (float)Math.Cos(Math.PI * ViewAngle.Z / 180);
            ViewVector.X = c * sinY + a * cosY * cosZ - b * cosY * sinZ;
            ViewVector.Y = a * (cosX * sinZ + cosZ * sinX * sinY) + b * (cosX * cosZ - sinX * sinY * sinZ) - c * cosY * sinX;
            ViewVector.Z = a * (sinX * sinZ - cosX * cosZ * sinY) + b * (cosZ * sinX + cosX * sinY * sinZ) + c * cosX * cosY;
            return ViewVector;

        }
        /// <summary>
        /// 该方法将一个世界坐标矢量转换为一个窗口坐标
        /// </summary>
        /// <param name="WorldVector">世界坐标矢量</param>
        /// <param name="MainForm">窗体实例对象</param>
        /// <returns>窗口坐标</returns>
        public static Vector3 Transform3D_View(Vector3 WorldVector, MainForm MainForm)
        {
            Vector3 ViewVector = new Vector3();
            Vector3 ShowVector = new Vector3();
            Vector3 ViewAngle = MainForm.ViewAngle;
            float PanelHeight = MainForm.PlotPanel.Height;
            float PanelWidth = MainForm.PlotPanel.Width;
            Vector3 Distance=new Vector3();
            Distance = WorldVector - MainForm.ViewPosition;
            ViewVector = Transform3D_2D(ViewAngle,Distance);
            if (Math.Abs(ViewVector.X) < (PanelWidth / 2) && Math.Abs(ViewVector.Y) < (PanelHeight / 2) && ViewVector.Z <= 0)
            {
                ShowVector.X = ViewVector.X  + (PanelWidth / 2);
                ShowVector.Y = ViewVector.Y  + (PanelHeight / 2);
            }
            else
            {
                ShowVector.X = ViewVector.X + (PanelWidth / 2);
                ShowVector.Y = ViewVector.Y + (PanelHeight / 2);
                ShowVector.W = 0;
            }
            
            return ShowVector;
        }
        public static Vector3 TransformView_3D(float a,float b, MainForm MainForm)
        {
            Vector3 ViewPosition=new Vector3();
            Vector3 ViewAngle = new Vector3((float)Math.Cos(MainForm.Azimuth), (float)Math.Sin(MainForm.Azimuth), (float)Math.Cos(MainForm.Elevation), 1);
            ViewPosition.X = (float)((b * (Math.Cos(ViewAngle.X) * Math.Sin(ViewAngle.Z) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) + Math.Cos(ViewAngle.X) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) + Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Y))) / (Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) + Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) + Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) + Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) + Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z)) + (a * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Z)) / (Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) + Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) + Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z)));
            ViewPosition.Y = (float)((b * (Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Z) - Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y))) / (Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) + Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) + Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) + Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) + Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z)) - (a * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.Z)) / (Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) + Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z) + Math.Cos(ViewAngle.Z) * Math.Cos(ViewAngle.Z) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) + Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Z) * Math.Sin(ViewAngle.Z)));
            ViewPosition.Z = (float)((a * Math.Sin(ViewAngle.Y)) / (Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) + Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y)) - (b * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.X)) / (Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) + Math.Cos(ViewAngle.X) * Math.Cos(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y) + Math.Cos(ViewAngle.Y) * Math.Cos(ViewAngle.Y) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) + Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.X) * Math.Sin(ViewAngle.Y) * Math.Sin(ViewAngle.Y)));
            return ViewPosition;
        }
    }
}
