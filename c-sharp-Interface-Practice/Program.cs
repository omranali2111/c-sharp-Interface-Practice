using c_sharp_Interface_Practice;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("what kind of vehicle you want to use:");
        string type = Convert.ToString(Console.ReadLine());
        Console.WriteLine("what is the speed you want to reach");
        int i = int.Parse(Console.ReadLine());

        IVehicle[] vehicle = { new Car(), new Motorcycle() };

        if (type == "car")
        {
            Console.WriteLine("this is instructions to ride a "+ type + " safely");
            vehicle[0].Start();
            vehicle[0].Accelerate(i);
            vehicle[0].Brake();
        }
        else if(type == "Motorcycle")
        {
            Console.WriteLine("this is instructions to ride a " + type + " safely");
            vehicle[1].Start();
            vehicle[1].Accelerate(i);
            vehicle[1].Brake();
        }

        else Console.WriteLine("you have enterd invalid input");

    }

    
}