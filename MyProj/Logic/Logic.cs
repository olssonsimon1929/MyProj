using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj.Logic
{
    
    public class Logic
    {
        private static int playerSum = 0;
        private static int dealerSum = 0;
        private static Random r;

        public Logic()
        {
            r = new Random();
        }

        public static int GetRandom()
        {
            int rand = r.Next(0, 12);
            return rand;
        }

        public static int RunDealer()
        {
            while(dealerSum < 17)
            {
                dealerSum += GetRandom();
            }
            return dealerSum;
        }

        public static int RunPlayer()
        {
            playerSum += GetRandom();
            return playerSum;
        }

        public int GetDealer()
        {
            return dealerSum;
        }

        public int GetPlayer()
        {
            return playerSum;
        }
    }
}
