using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvzGame
{
    class Zombie
    {
        public int x, y, size, speed;
        public int zombieHealth = 10;
        public int zombieDamage = 10;

        public Zombie(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }

        public void move()
        {
            x -= speed;
        }
    }
}
