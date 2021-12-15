using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroL5.Model
{
    internal class GYModel
    {
        public int gx;
        public int gy;
        public int gz;
        public int ax;
        public int ay;
        public int az;
        public float temp;

        public GYModel(int gx, int gy, int gz, int ax, int ay, int az, float temp)
        {
            this.gx = gx;
            this.gy = gy;
            this.gz = gz;
            this.ax = ax;
            this.ay = ay;
            this.az = az;
            this.temp = temp;
        }
    }
}
