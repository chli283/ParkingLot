using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ParkingLotSystem;

namespace TestParkingLotSystem
{
    public class TestParkingLot
    {
        [Fact]
        public void should_pick_one_car_when_pick_a_parked_car()
        {
            ParkingLot parkingLot = new ParkingLot();
            
            string key = parkingLot.park("paoche");
        
            Assert.Same("paoche", parkingLot.pick(key));
        }


        [Fact]
        public void should_pick_correct_car_when_pick_car_with_parked_multi_cars()
        {
            ParkingLot parkingLot = new ParkingLot();

            string key1 = parkingLot.park("paoche");
            string key2 = parkingLot.park("qq");

            Assert.Same("paoche", parkingLot.pick(key1));
            Assert.Same("qq", parkingLot.pick(key2));
        }

        [Fact]
        public void should_not_pick_the_car_repeatly_when_pick_a_parked_car()
        {
            string key;
            ParkingLot parkingLot = new ParkingLot();

            key = parkingLot.park("paoche");
            parkingLot.pick(key);
            Assert.Null(parkingLot.pick(key));
        }

        public void should_not_park_a_car_when_parking()
        { 
        }



        
        
    }
}
