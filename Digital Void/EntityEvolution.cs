using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Void
{
    public class EntityEvolution
    {
        public MainForm MainForm;
        public float k = 320f;
        public float DeltaTime = 0.0001f;

        public EntityEvolution(MainForm Form)
        {
            MainForm = Form;
        }
        public void Evolution(Entity[] EntityGroup)
        {
            AtomicEvolution(EntityGroup);
        }
        /// <summary>
        /// 对整个实体集合进行演化模拟
        /// </summary>
        /// <param name="EntityGroup">实体数组</param>
        public void AtomicEvolution(Entity[] EntityGroup)
        {
            int Sum = EntityGroup.Length;
            Vector3[,] Force = new Vector3[Sum, Sum];
            Vector3[] TotalForce = new Vector3[Sum];
            Vector3[] Acceleration = new Vector3[Sum];
            for(int i=0;i<Sum;i++)//对于第i个实体来说
            {
                TotalForce[i] = new Vector3();
                Acceleration[i] = new Vector3();
                for(int j=0;j<Sum;j++)//第j个实体对于它（第i个实体）的作用力
                {
                    if (j != i)
                    {
                        Force[i, j] = WorldInteraction(EntityGroup[i], EntityGroup[j]);
                    }
                    else
                        Force[i,j] = new Vector3(0,0,0,1);
                    TotalForce[i] += Force[i, j];//其余所有实体对于它（第i个实体）的合力矢量
                }
                Acceleration[i].X = TotalForce[i].X / EntityGroup[i].Mass;
                Acceleration[i].Y = TotalForce[i].Y / EntityGroup[i].Mass;
                Acceleration[i].Z = TotalForce[i].Z / EntityGroup[i].Mass; //得加速度矢量
            }
            for(int i=0;i<Sum;i++)
            {
                EntityGroup[i].Position.X += EntityGroup[i].Velocity.X * DeltaTime + Acceleration[i].X * DeltaTime * DeltaTime / 2;
                EntityGroup[i].Position.Y += EntityGroup[i].Velocity.Y * DeltaTime + Acceleration[i].Y * DeltaTime * DeltaTime / 2;
                EntityGroup[i].Position.Z += EntityGroup[i].Velocity.Z * DeltaTime + Acceleration[i].Z * DeltaTime * DeltaTime / 2;
                EntityGroup[i].Velocity.X += Acceleration[i].X * DeltaTime;
                EntityGroup[i].Velocity.Y += Acceleration[i].Y * DeltaTime;
                EntityGroup[i].Velocity.Z += Acceleration[i].Z * DeltaTime; 
            }      
        }
        private Vector3 WorldInteraction(Entity A,Entity B)
        {
            Vector3 Interaction = new Vector3();
            float DeltaX = B.Position.X - A.Position.X;
            float DeltaY = B.Position.Y - A.Position.Y;
            float DeltaZ = B.Position.Z - A.Position.Z;
            float R2 = DeltaX * DeltaX + DeltaY * DeltaY + DeltaZ * DeltaZ;
            float Force = k * A.Mass * B.Mass / R2;
            
            Interaction.Z = (float)(Force * DeltaZ / Math.Sqrt(R2));
            Interaction.Y = (float)((Force * Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY) / Math.Sqrt(R2)) * DeltaY / Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY));
            Interaction.X = (float)((Force * Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY) / Math.Sqrt(R2)) * DeltaX / Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY));
            return Interaction;
        }

    }
}
