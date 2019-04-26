using System;
using KataBankAccountTest;

namespace KataBankAccount
{
    public class BankCustomer
    {
        public BankCustomer(Account account)
        {
            Account = account;
        }

        public Account Account { get; }

        public void MakeADeposit(double moneyToSave)
        {
            Account.DepositMoney(moneyToSave);
        }

        public double MakeAWithdraw(double moneyToRetrieve)
        {
            return Account.WithdrawMoney(moneyToRetrieve);
        }
    }
}