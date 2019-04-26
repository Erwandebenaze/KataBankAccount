using System;
using System.Text;

namespace KataBankAccount
{
    public class BankCustomer
    {
        private readonly Account _account;
        public BankCustomer(Account account)
        {
            _account = account;
        }
        
        public void MakeADeposit(double moneyToSave, DateTime operationDate)
        {
            _account.DepositMoney(moneyToSave, operationDate);
        }

        public double Withdraw(double moneyToRetrieve, DateTime operationDate)
        {
            return _account.WithdrawMoney(moneyToRetrieve, operationDate);
        }

        public double WithdrawAllSaves(DateTime operationDate)
        {
            return _account.WithdrawAllSaved(operationDate);
        }

        public StringBuilder SeeOperationsOfAccount()
        {
            return _account.SeeOperations();
        }

        public double AmountOnAccount()
        {
            return _account.GetAmountSaved();
        }
    }
}