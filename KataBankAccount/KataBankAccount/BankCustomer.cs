using System;
using System.Text;

namespace KataBankAccount
{
    public class BankCustomer
    {
        private readonly Account _account;
        public BankCustomer()
        {
            _account = new Account();
        }
        
        public void MakeADeposit(Amount amount, DateTime operationDate)
        {
            _account.DepositMoney(amount, operationDate);
        }

        public Amount Withdraw(Amount amount, DateTime operationDate)
        {
            return _account.WithdrawMoney(amount, operationDate);
        }

        public Amount WithdrawAllSaves(DateTime operationDate)
        {
            return _account.WithdrawAllSaved(operationDate);
        }

        public StringBuilder SeeOperationsOfAccount()
        {
            return _account.SeeOperations();
        }

        public Amount AmountOnAccount()
        {
            return _account.GetAmountSaved();
        }
    }
}