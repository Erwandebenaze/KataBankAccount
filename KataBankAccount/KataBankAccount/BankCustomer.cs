using System;
using System.Text;

namespace KataBankAccount
{
    public class BankCustomer
    {

        public BankCustomer(Account account)
        {
            Account = account;
        }

        public Account Account { get; }

        public void MakeADeposit(double moneyToSave, DateTime operationDate)
        {
            Account.DepositMoney(moneyToSave, operationDate);
        }

        public double Withdraw(double moneyToRetrieve, DateTime operationDate)
        {
            return Account.WithdrawMoney(moneyToRetrieve, operationDate);
        }

        public double WithdrawAllSaves(DateTime operationDate)
        {
            return Account.WithdrawAllSaved(operationDate);
        }

        public StringBuilder SeeOperationsOfAccount()
        {
            return Account.SeeOperations();
        }
    }
}