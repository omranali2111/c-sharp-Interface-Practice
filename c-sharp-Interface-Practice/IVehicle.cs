using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface_Practice
{
    /*
    Task 1:
Create an interface IVehicle with the following methods:

void Start()
void Accelerate(int speed)
void Brake()
Create two classes Car and Motorcycle that implement 
the IVehicle interface. Implement the methods according
to the behavior of each vehicle type.
    */
    internal interface IVehicle
    {
       
       public void Start();
      public  void Accelerate(int speed)
        {

        }
       public void Brake();


    }

    class Car: IVehicle
    {
        int speed;

       public void Start()
        {
            Console.WriteLine("\r\nPlace your key in the ignition – Your ignition will" +
                "\r\n be located to the right of your steering wheel, just behind it. In some instances," +
                "\r\nthis will just be a button, known as 'push-button ignition'." +
                "\r\nTurn the key or press your push-button ignition – Turn it all the way to start the engine");
        }
        public void Accelerate(int speed)
        {
            Console.WriteLine("\r\nto Accelerate to speed " + speed + " gently apply pressure to the accelerator and never jab or floor it " +
                "\r\nmaintain consistent pressure on the accelerator as you push it down* " +
                "\r\nrelease the accelerator gradually, and avoid suddenly lifting your foot off it.");
           
        }
        public void Brake()
        {
            Console.WriteLine("\r\nPress down the brake firmly and smoothly." +
                "\r\nDepress your brake pedal rapidly, but not instantly. " +
                "\r\nThis is essential to maximize the braking potential of your car. " +
                "\r\nThe goal is to bring the vehicle's tires just shy of breaking traction. " +
                "\r \nIt is important, though, to avoid squeezing down on the brakes if your car has ABS");
        }
    }

    class Motorcycle: IVehicle
    {
        int speed;

        public void Start()
        {
            Console.WriteLine("Make sure that the gear selector is in neutral (the neutral light on the instrument panel will glow when the ignition is turned on)." +
                "\r\nTurn the fuel tap to ‘on’.If the engine is cold, move the choke to ‘on’.Make sure the engine cut-out switch is in the ‘on’ position." +
                "\r\nTurn the ignition key to the ‘on’ position.The next step depends on whether your motorbike has an electric starter or a kick starter." +
                "\r\nWith an electric starter, press the starter button. Release the button as the engine starts.With a kick starter, fold out the kick-start" +
                " \r\nlever. Put your foot on the lever and tread down sharply. Let the lever return to its upright position. Repeat this until the engine starts. When " +
                "\r\nit’s started, fold the lever back to its resting position.");
        }
        public void Accelerate(int speed)
        {
            Console.WriteLine("\r\nto Accelerate to speed " + speed + " gently throttle smoothly and steadily and never jab or floor it " +
                "\r\nmaintain consistent throttle  as you push it down* " +
                "\r\nrelease the throttle gradually, and avoid suddenly lifting your hand off it.");

        }
        public void Brake()
        {
            Console.WriteLine("Press down the brake firmly and smoothly." +
                "\r\nDepress your brake pedal rapidly, but not instantly. " +
                "\r\nThis is essential to maximize the braking potential of your car. " +
                "\r\nThe goal is to bring the Motorcycle's tires just shy of breaking traction. " +
                "\r\nIt is important, though, to avoid squeezing down on the brakes if your car has ABS");
        }
    }


}
