using c_sharp_Interface_Practice;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
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


        Console.WriteLine("--------------------------------------------------");
        IBankAccount[] bankAccount = { new SavingsAccount(), new CheckingAccount() };
        string str3;
        do
        {
            
            Console.WriteLine("choos the operation you want to do(deposit or withdraw)");
            string str1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("choos the account (Savings or Checking)");
            string str2 = Convert.ToString(Console.ReadLine());
            double deposit, withdraw;
            
            switch (str1)
            {
                case "deposit":

                    Console.WriteLine("enter amount to deposit");
                    deposit = int.Parse(Console.ReadLine());
                    if (str2 == "Saving")
                    {

                        bankAccount[0].Deposit(deposit);
                    }
                    else if (str2 == "Checking")
                    {

                        bankAccount[1].Deposit(deposit);
                    }
                    else
                        Console.WriteLine("you have entered invalid input");


                    break;
                case "withdraw":

                    Console.WriteLine("enter amount to withdraw");
                    withdraw = int.Parse(Console.ReadLine());
                    if (str2 == "Saving")
                    {

                        bankAccount[0].Withdraw(withdraw);
                    }
                    else if (str2 == "Checking")
                    {

                        bankAccount[1].Withdraw(withdraw);
                    }
                    else
                        Console.WriteLine("you have entered invalid input");

                    break;

                default:
                    Console.WriteLine("you have entered invalid input");
                    break;
            }
            Console.WriteLine($" you have {bankAccount[0].GetBalance()} balance in SavingAccount and {bankAccount[1].GetBalance()} in CheckingAccount ");
            Console.WriteLine("do you want to do another operation?(yes or no)");
             str3 = Convert.ToString(Console.ReadLine());

        } while (str3 =="yes");
        */

        Console.WriteLine("--------------------------------------------------");
        IPlayable music = new MusicPlayer();
        IPlayable video=new VideoPlayer();

        music.Play();
        video.Play();
        music.Stop();
        video.Pause();

    }

    
}