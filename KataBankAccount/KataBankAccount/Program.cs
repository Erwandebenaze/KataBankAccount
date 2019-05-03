using System;

namespace KataBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            BankCustomer customer = new BankCustomer();
            Console.WriteLine("Account manager");
            Console.WriteLine();

            Console.WriteLine("Deposit 20");
            customer.MakeADeposit(Amount.Of(20) , DateTime.Now);
            Console.WriteLine("You have " + customer.AmountOnAccount() + " on your account");
            Console.WriteLine();

            Console.WriteLine("Deposit 15");
            customer.MakeADeposit(Amount.Of(15), DateTime.Now);
            Console.WriteLine("You have " + customer.AmountOnAccount() + " on your account");
            Console.WriteLine();

            Console.WriteLine("Withdraw 10");
            Amount inYourhands = customer.Withdraw(Amount.Of(10), DateTime.Now);
            Console.WriteLine("You have " + inYourhands + " in your hands");
            Console.WriteLine("You have " + customer.AmountOnAccount() + " on your account");

            Console.WriteLine();

            Console.WriteLine("Withdraw all");
            inYourhands = customer.WithdrawAllSaves( DateTime.Now);
            Console.WriteLine("You have " + inYourhands + " in your hands");
            Console.WriteLine("You have " + customer.AmountOnAccount() + " on your account");

            Console.WriteLine();
            Console.WriteLine(customer.SeeOperationsOfAccount());

            Console.ReadKey();

        }
    }
}
