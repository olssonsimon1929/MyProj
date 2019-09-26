using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj
{
    
    class buttonhandler
    {
        private Logic l = new Logic();
        private int player = 0;
        private int dealer = 0;

        public buttonhandler()
        {
            player = l.GetPlayer();
            dealer = l.GetDealer();
        }
        
        public void button_clicked(object sender, EventArgs e)
        {
            
            
            switch ((sender as Button).Name)
            {
                case "yesButton":
                    player = l.RunPlayer();
                    if(player > 21)
                    {
                        MessageBox.Show("Du blev fet på: " + player);
                        break;
                    } else
                    {
                        MessageBox.Show("Du har nu: " + player + " , och dealern har: " + dealer);
                    }

                    break;

                case "noButton":
                    dealer = l.RunDealer();
                    if(dealer < 22 && dealer >= player)
                    {
                        MessageBox.Show("Dealer vann på: " + dealer);
                    } else if(dealer > 22)
                    {
                        MessageBox.Show("Dealer blev fet på: " + dealer + " , du vann.");
                    }
                   
                    break;
                default:
                    break;
            }
        }
    }
}
