using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {

        public CarLot()
        {

        }
        public List<Car> ParkingLot { get; set; } = new List<Car>(); // Made into a Property 
                                                                     //List<Car> ParkingLot = new List<car>(); --> Standard way

        public static int numberOfCars;
       
    }
}


// FOR ***BONUS X 2***