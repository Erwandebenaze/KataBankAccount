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
    }
}