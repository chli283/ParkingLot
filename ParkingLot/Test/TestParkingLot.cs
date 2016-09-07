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
            ParkingLot parkingLot = new ParkingLot(2);
            
            int key = parkingLot.park("paoche");
        
            Assert.Same("paoche", parkingLot.pick(key));
        }

        [Fact]
        public void should_pick_correct_car_when_pick_car_with_parked_multi_cars()
        {
            ParkingLot parkingLot = new ParkingLot(2);

            int key1 = parkingLot.park("paoche");
            int key2 = parkingLot.park("qq");

            Assert.Same("paoche", parkingLot.pick(key1));
            Assert.Same("qq", parkingLot.pick(key2));
        }

        [Fact]
        public void should_not_pick_the_car_repeatly_when_pick_a_parked_car()
        {
            int key;
            ParkingLot parkingLot = new ParkingLot(2);

            key = parkingLot.park("BMW");
            parkingLot.pick(key);
            Assert.Null(parkingLot.pick(key));
        }

        [Fact]
        public void should_not_park_a_car_when_parkingLot_is_full()
        {
            ParkingLot parkingLot = new ParkingLot(2);
            parkingLot.park("W");
            parkingLot.park("Z");
            Assert.Equal(0,parkingLot.park("H"));

        }
        [Fact]
        public void should_be_able_to_park_a_car_after_pick_a_car_from_full_parkingLot()
        {
            ParkingLot parkingLot = new ParkingLot(1);
            int key =  parkingLot.park("W");
            parkingLot.pick(key);

            int key2 = parkingLot.park("Z");
            Assert.Same("Z",parkingLot.pick(key2));

        }
        
    }
}
