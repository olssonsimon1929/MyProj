using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    
    public class Logic
    {
        private int playerSum = 0;
        private int dealerSum = 0;
        private static Random r;

        public Logic()
        {
            r = new Random();
            playerSum = GetRandom();
            dealerSum = GetRandom();
        }

        private static int GetRandom()
        {
            int rand = r.Next(1, 12);
            return rand;
        }

        public int RunDealer()
        {
            while(dealerSum < 17)
            {
                dealerSum += GetRandom();
            }
            return dealerSum;
        }

        public int RunPlayer()
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
