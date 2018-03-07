using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class GameScreen
    {
        private int Width;
        private int Height;
        private Hero MyHero;
        private List<Enemy> Enemies = new List<Enemy>();

        public GameScreen(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public void SetHero(Hero MyHero)
        {
            this.MyHero = MyHero;
        }
        public Hero GetHero()
        {
            return MyHero;
        }
        public void MobAdd(Enemy mob)
        {
            Enemies.Add(mob);
        }
        public void MoveAllMobDown()
        {
            foreach(Enemy mob in Enemies)
            {
                mob.MoveDown();
            }
        }
        public Enemy GetEnemyById(int Id)
        {
            foreach (Enemy mob in Enemies)
            {
                if(mob.GetId()==Id)
                {
                    return mob;
                }
            }
            return null;
        }
        public void Render()
        {
            MyHero.PrintInfo();
            foreach(Enemy mob in Enemies)
            {
                mob.PrintInfo();
            }
        }

    }
}
