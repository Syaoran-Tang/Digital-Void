using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Digital_Void
{
    [Serializable]
    public class Entity
    {
        public String Name;
        public Color Color;
        public Vector3 Position;
        public float Radius;
        public Vector3 Velocity;
        //public Vector3 Force;
        public float Mass;

        public Entity()
        {
            Name = "新实体";
            Color = Color.Black; //Color.FromArgb(new Random().Next(0, 255 * 255 * 255));
            Mass = 0f;
            Radius = 0f;
            Position = new Vector3(0f, 0f, 0f, 1);
            Velocity = new Vector3(0f, 0f, 0f, 1);
        }
        
    }
}
