using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem
{
     
    public class ParkingLot
    {
        public static int flag = 0;
        public string park(string car)
        {

            if (car == "paoche")
            {
                flag = 1;
                return "paoche";
            }

            else
                return "qq";

        }
        public string pick(string key)
        {

            if (key == "paoche" && flag == 1)
            {
                flag = 0;
                return "paoche";

            }
            else if (key == "qq")
                return "qq";
            else
                return null;
           
        }
        
    }

}
