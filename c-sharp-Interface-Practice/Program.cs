using c_sharp_Interface_Practice;
using Microsoft.VisualBasic;
using System;
using System.Text;

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

        Console.WriteLine("--------------------------------------------------");

        ILogger file = new FileLogger();
        ILogger Database= new DatabaseLogger();

        file.LogInfo("login success");
        Database.LogError("login failed");

        Console.WriteLine("--------------------------------------------------");

        IEmployee full = new FullTimeEmployee();
        IEmployee part = new PartTimeEmployee();

        Console.WriteLine("Full Time Employee Info: ");
        Console.WriteLine(full.Name="ali");
        Console.WriteLine(full.Salary = 2100);
        Console.WriteLine(full.JobTitle = "Dev");
        Console.WriteLine("*********************");

        Console.WriteLine("Part Time Employee Info: ");
        Console.WriteLine(full.Name = "ahmed");
        Console.WriteLine(full.Salary = 1500);
        Console.WriteLine(full.JobTitle = "salesman");

        Console.WriteLine("--------------------------------------------------");
        GetHash get= new GetHash();
        get.age = 28;
        get.Name = "omar";
        Console.WriteLine(get.GetHashCode());
        GetHash get1 = new GetHash();
        Console.WriteLine(get1.GetHashCode());
        get1.age = 28;
        get1.Name = "omar";

        Console.WriteLine(get.Equals(get1));//in this case Equals function is comparing the HashCode so we need to override the equals function

        StringBuilder sb= new StringBuilder();// this used to prevent adding new object each time we add new string 
        sb.AppendLine("hi");
        Console.WriteLine(get1.GetHashCode());// same HashCode everytime
        sb.AppendLine("i am");
        Console.WriteLine(get1.GetHashCode());
        sb.AppendLine("omran");
        Console.WriteLine(get1.GetHashCode());
        Console.WriteLine(sb.ToString());

        Immutable person = new Immutable("omran", 27);//Once the object is created, the property values cannot be changed.


        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");

        Console.WriteLine("--------------------------------------------------");
        int[] arr = new int[] {1,2,3,4,5};
                                  
                                         


        search sr=new search();
        Console.WriteLine(sr.searchForElement(arr, 4));

        
    }

    
}