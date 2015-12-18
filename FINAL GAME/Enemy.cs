using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_GAME
{
    class Enemy
    {
        Random rngEnemy = new Random();
        public int enemyHealth;
        static int damageX;
        static int damageY;
        static int ScoreX;
        static int ScoreY;


        public Enemy(int damageE1, int damageE2, int enemyHP, int ScoreEX, int ScoreEY)
        {
            enemyHealth = enemyHP;
            damageX = damageE1;
            damageY = damageE2;
            ScoreX = ScoreEX;
            ScoreY = ScoreEY;
        }

        public int enemyDMG()
        {
            Random rngPlayer = new Random();
            return rngPlayer.Next(damageX, damageY);
        }

        public int scoreGive()
        {
            Random rngScore = new Random();
            return rngScore.Next(ScoreX, ScoreY);
        }
    }
}
