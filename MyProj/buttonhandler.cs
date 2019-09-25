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
        
        
        public void button_clicked(object sender, EventArgs e)
        {
            
            
            switch ((sender as Button).Name)
            {
                case "yesButton":
                    MessageBox.Show("You clicked yes");

                    break;

                case "noButton":
                    MessageBox.Show("You clicked no");

                    break;
                default:
                    break;
            }
        }
    }
}
