using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Void
{
    public class Matrix3
    {
        #region 矩阵初始化
        public float[,] M = new float[4, 4];
        public Matrix3()
        {
            Identity3();
        }
        public Matrix3(float m00, float m01, float m02, float m03,
                       float m10, float m11, float m12, float m13,
                       float m20, float m21, float m22, float m23,
                       float m30, float m31, float m32, float m33)
        {
            M[0, 0] = m00; M[0, 1] = m01; M[0, 2] = m02; M[0, 3] = m03;
            M[1, 0] = m10; M[1, 1] = m11; M[1, 2] = m12; M[1, 3] = m13;
            M[2, 0] = m20; M[2, 1] = m21; M[2, 2] = m22; M[2, 3] = m23;
            M[3, 0] = m30; M[3, 1] = m31; M[3, 2] = m32; M[3, 3] = m33;
        }
        //定义一个单位矩阵
        public void Identity3()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        M[i, j] = 1;
                    }
                    else
                    {
                        M[i, j] = 0;
                    }
                }
            }
        }
        #endregion

        #region 矩阵方法
        //矩阵乘法
        public static Matrix3 operator *(Matrix3 m1, Matrix3 m2)
        {
            Matrix3 result = new Matrix3();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    float element = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        element += m1.M[i, k] * m2.M[k, j];
                    }
                    result.M[i, j] = element;
                }
            }
            return result;
        }

        public static Matrix3 AngelTransform3D_2D(Vector3 ViewAngle)
        {
            float sinX = (float)Math.Sin(ViewAngle.X * Math.PI / 180);
            float cosX = (float)Math.Cos(ViewAngle.X * Math.PI / 180);
            float sinY = (float)Math.Sin(ViewAngle.Y * Math.PI / 180);
            float cosY = (float)Math.Cos(ViewAngle.Y * Math.PI / 180);
            float sinZ = (float)Math.Sin(ViewAngle.Z * Math.PI / 180);
            float cosZ = (float)Math.Cos(ViewAngle.Z * Math.PI / 180);
            Matrix3 result = new Matrix3(cosY*cosZ,-cosY*sinZ,sinY,0,
                                         cosX*sinZ+cosZ*sinX*sinY,cosX*cosZ-sinX*sinY*sinZ,-cosY*sinX,0,
                                         sinX*sinZ-cosX*cosZ*sinY,cosZ*sinX+cosX*sinY*sinZ,cosX*cosY,0,
                                         0,0,0,1);
            return result;
        }
        #endregion

    }
}
