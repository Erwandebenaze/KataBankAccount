using System;
using KataBankAccountTest;

namespace KataBankAccount
{
    public class Customer
    {
        public Customer(Account account)
        {
            Account = account;
        }

        public Account Account { get; }

        public void MakeADeposit(double moneyToSave)
        {
            Account.DepositMoney(moneyToSave);
        }
    }
}