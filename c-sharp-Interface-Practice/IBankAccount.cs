using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface_Practice
{
    /*
    Task 2
 Create an interface called IBankAccount that has methods called GetBalance(),
        Deposit(), and Withdraw(). Create two classes, SavingsAccount and CheckingAccount,
        that implement the IBankAccount interface. The SavingsAccount class should override
        the Deposit() and Withdraw() methods to add and subtract money from the savings account 
        balance.The CheckingAccount class should override the Deposit() and Withdraw() methods
        to add and subtract money from the checking account balance.
    */ 
    internal interface IBankAccount
    {
        
        public double GetBalance();
        public void Deposit(double balance);
        public void Withdraw(double balance);
    }
    class SavingsAccount: IBankAccount
    {

       private double balance;

        public SavingsAccount()
        {
   
        }
        public double GetBalance()
        {
           
            return balance;

        }
        public  void Deposit(double balance)
        {
            this.balance += balance;
           

        }

        public void Withdraw(double balance)
        {
            this.balance -= balance;

            
        }


    }

    class CheckingAccount: IBankAccount
    {
       private double balance;

        public CheckingAccount()
        {
           
        }
        public double GetBalance()
        {
            return balance;

        }
        public void Deposit(double balance)
        {
            this.balance += balance;
           
        }

        public void Withdraw(double balance)
        {
            this.balance -= balance;
           

        }

    }
}
