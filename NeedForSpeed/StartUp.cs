using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle car = new Car(100, 200);
            car.Drive(20);
        }
    }
}
