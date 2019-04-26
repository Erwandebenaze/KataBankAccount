using System;

namespace KataBankAccountTest
{
    public class Account
    {
        private double _amount;
        internal void DepositMoney(double moneyToSave)
        {
            _amount += moneyToSave;
        }

        public object GetAmount()
        {
            return _amount;
        }

        internal double WithdrawMoney(double moneyToRetrieve)
        {
            return _amount -= moneyToRetrieve;
        }
    }
}