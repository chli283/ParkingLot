using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ParkingLotSystem
{
     
    public class ParkingLot
    {    
        public static int counts = 0;
        public static int parkingLotMax = 0;
        public Hashtable parkingLotList = new Hashtable();
     
    
        public ParkingLot(int i)
        {                      
            parkingLotMax = i;                      
 
        }
        public ParkingLot()
        {
            parkingLotMax = 100;
        }
        public int park(string car)
        {

            if (counts < parkingLotMax)
            {
                parkingLotList.Add(counts,car);
                int key = counts++;                
                return key;                
            }
            else
                return 0;
         }
        public string pick(int key)
        {

           string result = (string)parkingLotList[key];
           if (result!=null)
           {               
               parkingLotList.Remove(key);
               counts--;
               return result;
           }            
           else
               return null;

            
           
        }
        
    }

}
