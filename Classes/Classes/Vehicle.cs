using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycles, Spaceships, Planes, Boats}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }

        public Vehicle(){}
        public Vehicle(string make, string model, double mileage, VehicleType typeofvehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeofvehicle;
        }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle.");
            IsRunning = false;
        }
        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }
        

        public void IndicateRight()
        {
            RightIndicator.IndicatorOn();
            LeftIndicator.IndicatorOff();
        }
        public void IndicateLeft()
        {
            LeftIndicator.IndicatorOn();
            RightIndicator.IndicatorOff();
        }
        public void Hazzards()
        {
            LeftIndicator.IndicatorOn();
            RightIndicator.IndicatorOn();
        }
        public void ClearIndicators()
        {
            LeftIndicator.IndicatorOff();
            RightIndicator.IndicatorOff();
        }

    }
    public class Indicator
    {
        public bool IsFlashing { get; private set; }
        public void IndicatorOn()
        {
            IsFlashing = true;
            Console.WriteLine("The light starts flashing.");
        }
        public void IndicatorOff()
        {
            Console.WriteLine("The light is no longer flashing");
            IsFlashing = false;
        }
    }
}
