using System;
using System.Collections.Generic;
using System.Text;

namespace KataBankAccountTest
{
    public class Account
    {
        private double _amount;
        private IList<Operation> _operations;

        public Account()
        {
            _operations = new List<Operation>();
        }
        internal void DepositMoney(double moneyToSave)
        {
            _amount += moneyToSave;
            _operations.Add(new Operation(_operations.Count));
        }
        internal double WithdrawMoney(double moneyToRetrieve)
        {
            if (IsEnoughtMoneyToWithdraw(moneyToRetrieve))
            {
                _amount -= moneyToRetrieve;
                _operations.Add(new Operation(_operations.Count));
                return moneyToRetrieve;
            }
            else
            {
                throw new InvalidOperationException("You can not withdraw this amount because the amount of the money you saved is lower.");
            }
        }

        internal double WithdrawAllSaved()
        {
            double moneyToRetrieve = _amount;
            _amount = 0;

            _operations.Add(new Operation(_operations.Count));
            return moneyToRetrieve;
        }

        public double GetAmountSaved()
        {
            return _amount;
        }


        private bool IsEnoughtMoneyToWithdraw(double moneyToWithdraw)
        {
            return _amount > moneyToWithdraw;
        }

        internal StringBuilder SeeOperations()
        {
            StringBuilder stringBuilder= new StringBuilder("List of operations :");
            stringBuilder.AppendLine();
            foreach (Operation operation in _operations)
            {
                stringBuilder.AppendLine(operation.ToString());
            }

            return stringBuilder;
        }
    }
}