using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvzGame
{
    class Projectile
    {
        public int speed = 10;
        public int x, y, size;

        public Projectile (int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }

        public void Shoot()
        {
            x += speed;
        }
    }
}
