using System;
using System.Collections.Generic;
using System.Text;

namespace Séance2DMWMCSharp
{
    class PointAtelier1
    {
        private int x, y, z;
        public PointAtelier1(int x)
        {
            this.x = x;

        }
        public PointAtelier1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public PointAtelier1(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void translate(int tx)
        {
            x += tx;
        }
        public void translate(int tx, int ty)
        {
            x += tx;
            y += ty;
        }
        public void translate(int tx, int ty, int tz)
        {
            x += tx;
            y += ty;
            z += tz;
        }
    }
}
