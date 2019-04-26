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

        public double GetAmountSaved()
        {
            return _amount;
        }

        internal double WithdrawMoney(double moneyToRetrieve)
        {
            if (IsEnoughtMoneyToWithdraw(moneyToRetrieve))
            {
                _amount -= moneyToRetrieve;
                return moneyToRetrieve;
            }
            else
            {
                throw new InvalidOperationException("You can not withdraw this amount because the amount of the money you saved is lower.");
            }
        }

        private bool IsEnoughtMoneyToWithdraw(double moneyToWithdraw)
        {
            return _amount > moneyToWithdraw;
        }
    }
}