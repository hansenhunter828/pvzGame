using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pvzGame
{
    public partial class MainMenuScreen : UserControl
    {
        List<Zombie> zombies = new List<Zombie>();
        List<Projectile> projectiles = new List<Projectile>();
        Random randGen = new Random();
        SolidBrush brushColour = new SolidBrush(Color.White);
        SolidBrush zomBrush = new SolidBrush(Color.Green);
        int zomSpawn1X = 777; int zomSpawn1Y = 74;
        int zomSpawn2X = 777; int zomSpawn2Y = 200;
        int proSpawn1X = 10; int proSpawn1Y = 74;
        int proSpawn2X = 10; int proSpawn2Y = 200;
        int zomSize = 20;
        int SpawnTimer = 20;
        int damage = 30;
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loop_Tick(object sender, EventArgs e)
        {
            if (SpawnTimer == 0)
            {
                int zomSpawnLoca = randGen.Next(0, 3);
                int proSpawnLoca = randGen.Next(0, 3);

                if (zomSpawnLoca == 1)
                {
                    Zombie z = new Zombie(zomSpawn1X, zomSpawn1Y, zomSize, 3);
                    zombies.Add(z);
                }
                else
                {
                    Zombie z = new Zombie(zomSpawn2X, zomSpawn2Y, zomSize, 3);
                    zombies.Add(z);
                }

                if (proSpawnLoca == 1)
                {
                    Projectile pr = new Projectile(proSpawn1X, proSpawn1Y, 10);
                    projectiles.Add(pr);
                }
                else
                {
                    Projectile pr = new Projectile(proSpawn2X, proSpawn2Y, 10);
                    projectiles.Add(pr);
                }
                SpawnTimer = 20;
            }
            foreach (Zombie z in zombies)
            {
                z.move();
            }
            foreach (Zombie z in zombies)
            {
                if (z.x < 0)
                {
                    zombies.Remove(z);
                    return;
                }
            }
            foreach (Projectile p in projectiles)
            {
                p.Shoot();
                foreach (Zombie z in zombies)
                {
                    Rectangle projectileRec = new Rectangle(p.x, p.y, p.size, p.size);
                    Rectangle zombieRec = new Rectangle(z.x, z.y, z.size, z.size);

                    if (projectileRec.IntersectsWith(zombieRec))
                    {
                        if (z.zombieHealth > 0)
                        {
                            z.zombieHealth -= damage;
                            projectiles.Remove(p);
                            return;
                        }
                        if (z.zombieHealth <= 0)
                        {
                            zombies.Remove(z);
                            projectiles.Remove(p);
                            return;
                        }
                    }
                }
            }
            foreach (Projectile p in projectiles)
            {
                if (p.x > this.Width)
                {
                    projectiles.Remove(p);
                    return;
                }
            }
            SpawnTimer--;
            Refresh();
        }

        private void MainMenuScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Projectile P in projectiles)
            {
                e.Graphics.FillRectangle(brushColour, P.x, P.y, P.size, P.size);
            }
            //Draw zombies
            foreach (Zombie z in zombies)
            {
                e.Graphics.FillRectangle(zomBrush, z.x, z.y, z.size, z.size);
            }
        }
    }
}
