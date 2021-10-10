//Hunter Hansen
//Animating Game
//Plants V Zombies
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace pvzGame
{
    public partial class GameScreen : UserControl
    {//Variables
        List<Zombie> zombies = new List<Zombie>();
        List<Projectile> projectiles = new List<Projectile>();
        int sunFlowers = 50;
        int sunTimer = 100;
        int cashUpCost = 25;
        int cashUp = 1;
        int cashPS = 1;
        int damUpCost = 30;
        int damage = 20;
        int zombieSpawnTimer = 20;
        int zomSize = 20;
        int plot2X = 145; int plot2Y = 74;
        int plot4X = 145; int plot4Y = 200;
        int zomSpawn1X = 777; int zomSpawn1Y = 74;
        int zomSpawn2X = 777; int zomSpawn2Y = 200;
        int waveTimer;
        int currentWave;
        int baseHealth = 50;
        SolidBrush brushColour = new SolidBrush(Color.White);
        SolidBrush zomBrush = new SolidBrush(Color.Green);
        Random randGen = new Random();


        public GameScreen()
        {
            InitializeComponent();
        }

        private void plot1_Click(object sender, EventArgs e)
        {
            sunFlowers += cashPS;
        }

        private void plot2_Click(object sender, EventArgs e)
        {
            if(sunFlowers > 0)
            {
                Projectile pr = new Projectile(plot2X, plot2Y, 10);
                projectiles.Add(pr);
                sunFlowers--;
            }
        }

        private void plot3_Click(object sender, EventArgs e)
        {
            sunFlowers += cashPS;
        }

        private void plot4_Click(object sender, EventArgs e)
        {
            if (sunFlowers > 0)
            {
                Projectile pr = new Projectile(plot4X, plot4Y, 10);
                projectiles.Add(pr);
                sunFlowers--;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Draw projectiles
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

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            foreach (Projectile p in projectiles)
            {
                p.Shoot();
                foreach (Zombie z in zombies)
                {
                    Rectangle projectileRec = new Rectangle(p.x, p.y, p.size, p.size);
                    Rectangle zombieRec = new Rectangle(z.x, z.y, z.size, z.size);

                    if (projectileRec.IntersectsWith(zombieRec))
                    {
                        if (z.zombieHealth <= 0)
                        {
                            zombies.Remove(z);
                            projectiles.Remove(p);
                            return;
                        }
                        else
                        {
                            z.zombieHealth -= damage;
                            projectiles.Remove(p);
                            return;
                        }
                    }
                }
            }
            //Spawn zombies
            if (zombieSpawnTimer == 0)
            {
                int spawnLoca = randGen.Next(0, 3);

                if (spawnLoca == 1)
                {
                    Zombie z = new Zombie(zomSpawn1X, zomSpawn1Y, zomSize, 3);
                    zombies.Add(z);
                }
                else
                {
                    Zombie z = new Zombie(zomSpawn2X, zomSpawn2Y, zomSize, 3);
                    zombies.Add(z);
                }
                zombieSpawnTimer = 20;
            }
            //Move zombies
            foreach (Zombie z in zombies)
            {
                z.move();
            }
            //Delete zombies
            foreach (Zombie z in zombies)
            {
                if (z.x < 0)
                {
                    zombies.Remove(z);
                    baseHealth -= z.zombieDamage;
                    return;
                }
            }
            //Delete projectiles
            foreach (Projectile p in projectiles)
            {
                if (p.x > this.Width)
                {
                    projectiles.Remove(p);
                    return;
                }
            }
            //Create currency
            if (sunTimer == 0)
            {
                sunFlowers += cashPS;
                sunFlowersLabel.Text = $"{sunFlowers}";
                sunTimer = 50;
            }
            //Timers
            waveTimer--;
            zombieSpawnTimer--;
            sunTimer--;
            //update labels
            upDamCostLabel.Text = $"Cost: {damUpCost}";
            upCashCostLabel.Text = $"Cost: {cashUpCost}";
            sunFlowersLabel.Text = $"Flowers: {sunFlowers}";
            waveTimerLeftLabel.Text = $"Time: {waveTimer}";
            baseHealthLabel.Text = $"Health: {baseHealth}";
            currentWaveLabel.Text = $"Wave: {currentWave}";
            //check if game over
            if (baseHealth <= 0)
            {
                GameOver();
            }
            //check if time for new round
            if (waveTimer <= 0)
            {
                NewWave();
            }
            Refresh();
        }

        private void upgradeCashButton_Click(object sender, EventArgs e)
        {
            //Upgrade currency
            if (sunFlowers >= cashUpCost)
            {
                cashPS = cashPS + cashUp;
                cashUpCost += 2;
                sunFlowers -= cashUpCost;
            }
        }

        private void upgradeDamButton_Click(object sender, EventArgs e)
        {
            //Upgrade damga
            if (sunFlowers >= damUpCost)
            {
                damage += 2;
                damUpCost += 2;
                sunFlowers -= damUpCost;
            }
        }

        private void GameOver()
        {
            gameLoop.Enabled = false;

            waveLabel.Text = $"GAME OVER";
            Refresh();
            Thread.Sleep(3000);

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gameOver = new GameOverScreen();
            f.Controls.Add(gameOver);
        }

        public void NewWave()
        {
            gameLoop.Enabled = false;
            waveLabel.Text = $"wave {currentWave}";
            Refresh();
            zombies.Clear();
            projectiles.Clear();
            Thread.Sleep(3000);
            waveLabel.Text = "";
            currentWave++;
            waveTimer = 1000;
            gameLoop.Enabled = true;
        }
    }
}