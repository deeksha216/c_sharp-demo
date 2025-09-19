using System;

public class vehicle
{
    public void drive()
    {
        Console.WriteLine("Driving a vehicle");
    }
    class car : vehicle
    {
        public void speed()
        {
            Console.WriteLine("speed is vetry high");
        }
        class bmw : car
        {
            public void sound()
            {
                Console.WriteLine("bmw sound is very good");
            }
            static void Main(string[] args)
            {
                bmw b = new bmw();
                b.drive();
                b.speed();
                b.sound();
            }



        }



    }
}
