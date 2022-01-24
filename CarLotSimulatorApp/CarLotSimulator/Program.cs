using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot(); // for BONUZ X 2 only needed for BOUNS X 2 !!! --> Instantiating a new object of type CarLot
            

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //**Dot Notation**
            var toyota = new Car(); // instantiating a new car
            toyota.Year = 2021;
            toyota.Make = "Toyota";
            toyota.Model = "4Runner";
            toyota.EngineNoise = "Vroom, Vroom";
            toyota.HonkNoise = "Beep, Beep";
            toyota.IsDrivable = true;

            carLot.ParkingLot.Add(toyota); // for ***BONUS X 2*** only needed for BONUS X 2 !!!
            
            
            Console.WriteLine($"Number of cars in CarLot: {CarLot.numberOfCars}");

            //**Object Initialize Syntax**
            var honda = new Car()
            {
                Year = 2001,
                Make = "Honda",
                Model =  "Accord",
                EngineNoise = "Rattle, Rattle...",
                HonkNoise = "Beep,Beep",
                IsDrivable = false

            };
            carLot.ParkingLot.Add(honda); // for ***BONUS X 2*** only needed for BONUS X 2 !!!
            
            Console.WriteLine($"Number of cars in CarLot: {CarLot.numberOfCars}");

            //**Custom Constructor**
            var infiniti = new Car(2014, "Infiniti", "Q50", "Vroom!", "BEEEP!", true);

            carLot.ParkingLot.Add(infiniti); // for *** BONUS X 2*** only needed for BONUS X 2 !!!
            
            Console.WriteLine($"Number of cars in CarLot: {CarLot.numberOfCars}");


            Console.WriteLine("Toyota");
            toyota.MakeEngineNoise(toyota.EngineNoise);
            toyota.MakeHonkeNoise(toyota.HonkNoise);
            Console.WriteLine();

            Console.WriteLine("Honda");
            honda.MakeEngineNoise(honda.EngineNoise);
            honda.MakeHonkeNoise(honda.HonkNoise);
            Console.WriteLine();

            Console.WriteLine("Infiniti");
            infiniti.MakeEngineNoise(infiniti.EngineNoise);
            infiniti.MakeHonkeNoise(infiniti.HonkNoise);
            Console.WriteLine();





            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
           
            Console.WriteLine("-----------------");

            foreach (var car in carLot.ParkingLot) // ITERATING THROUGH THE LIST
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                Console.WriteLine();
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkeNoise(car.HonkNoise);
                
                // can also add /n to end before " to make a space.
            }
        }
    }
}
