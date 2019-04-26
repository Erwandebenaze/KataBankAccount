using System;
using System.Text;
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

        public double Withdraw(double moneyToRetrieve)
        {
            return Account.WithdrawMoney(moneyToRetrieve);
        }

        public double WithdrawAllSaves()
        {
            return Account.WithdrawAllSaved();
        }

        public StringBuilder SeeOperationsOfAccount()
        {
            return Account.SeeOperations();
        }
    }
}