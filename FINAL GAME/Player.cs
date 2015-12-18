using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_GAME
{
    public class Player
    {

        public string playerName;
        public int playerHealth;
        public int playerLevel;
        public int playerScore;
        public static int playerDamageX = 0;
        public static int playerDamageY = 0;
        public static int hpGainX = 0;
        public static int hpGainY = 0;
        public string Inventory;

        public Player(int playerHP, int TotalScore, int playerLVL)
        {
            playerHealth = playerHP;
            playerScore = TotalScore;
            playerLevel = playerLVL;
        }

        public int weaponDMG() //calculate random weapon damage
        {
            Random rngPlayer = new Random();
            return rngPlayer.Next(playerDamageX, playerDamageY); //two variables change depending on weapon
        }

        public int healthGain()
        {
            Random rngHP = new Random();
            return rngHP.Next(hpGainX, hpGainY);
        }


        
    }
}
