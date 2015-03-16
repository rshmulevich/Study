using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vechicles;



namespace Study
{
    class Program
    {

        private static log4net.ILog Log { get; set; }


        public static void Main()
        {


            //BasicConfigurator.Configure();

            bool bigCar = true;
            ICar car;//interface

            if (!bigCar)
                car = new ToyotaVenza();

            else
                car = new Gaz51();

            Console.WriteLine(string.Format("Wheels: {0}", car.NumberOfWeels));
            Logger.Info(string.Format("LOOOOOOOOOOOOOOOOOOG"));
            Console.WriteLine(string.Format("Engine Size: {0}", car.Engine.Size));
                


            PlayWithOdometer(car);

            Console.ReadLine();

            string fuel = "Gasolin";
            //string fuel = "Diesel";
            var numberOfLiters = 1000;

            FillFuel(car, fuel, numberOfLiters);

            //added by Roman
            int _pressure = car.Wheels[0].CheckPressure();

            if (_pressure == 0)
                Console.WriteLine("Pressure is OK");
            else if (_pressure < 0)
                Console.WriteLine("Pressure is Low");
            else
                Console.WriteLine("Pressure is High");

            Console.ReadLine();

            car.Engine.Start();
            car.Drive();

        }
        private static void PlayWithOdometer(ICar car)
        {
            Console.WriteLine(string.Format("Odometer: {0}km", car.OdometerReading));//interface

           // car.OdometerReadings = 9000; // should not compile with this line uncommented

        }

        private static void FillFuel(ICar car, string fuelType, int liters)
        {

            //I'm proude of myself

            string strVehicleType = car.GetType().ToString();
            strVehicleType = strVehicleType.Split('.')[1];

            // make sure method below checks for tank capacity and fuel type
            // if something is wrong, throw informative exception


            try
            {
                
                car.FillTank(fuelType, liters);
                Console.WriteLine(string.Format("{0}ltr of {1} is good for {2}", liters, fuelType, strVehicleType));
                Console.ReadLine();

            }
            catch (WrongFuelTypeException ex)
            {
                Console.WriteLine("Incorrect fuel type: " + ex.Message);
                Console.ReadLine();

                Logger.Error(ex.Message, ex);
            }
            catch (WrongFuelAmountException ex)
            {
                Console.WriteLine("Incorrect fuel amount: " + ex.Message);

                Logger.Error("Incorrect fuel amount: " + ex.Message);

                Console.ReadLine();
            }
        }


        
    }
}
