using System;
using System.Collections.Generic;
using System.Text;

namespace KataBankAccount
{
    public class Account
    {
        private double _amount = 0;
        private readonly IList<Operation> _operations;
        public static Account Of()
        {
            return new Account();
        }

        private Account()
        {
            _operations = new List<Operation>();
        }
        internal void DepositMoney(double moneyToSave, DateTime operationDate)
        {
            _amount += moneyToSave;
            double balance = moneyToSave;
            _operations.Add(Operation.Of(OperationName.Deposit, operationDate, _amount, balance));
        }
        internal double WithdrawMoney(double moneyToRetrieve, DateTime operationDate)
        {
            if (IsEnoughtMoneyToWithdraw(moneyToRetrieve))
            {
                _amount -= moneyToRetrieve;
                double balance = -moneyToRetrieve;
                _operations.Add(Operation.Of(OperationName.Withdraw, operationDate, _amount, balance));
                return moneyToRetrieve;
            }
            else
            {
                throw new InvalidOperationException("Withdraw impossible, the saved is lower than amount wanted.");
            }
        }

        internal double WithdrawAllSaved(DateTime operationDate)
        {
            double moneyToRetrieve = _amount;
            double balance = -moneyToRetrieve;
            _amount = 0;

            _operations.Add(Operation.Of(OperationName.WithdrawAll, operationDate, _amount, balance));
            return moneyToRetrieve;
        }

        internal double GetAmountSaved()
        {
            return _amount;
        }


        private bool IsEnoughtMoneyToWithdraw(double moneyToWithdraw)
        {
            return _amount > moneyToWithdraw;
        }

        internal StringBuilder SeeOperations()
        {
            StringBuilder stringBuilder = new StringBuilder("List of operations :");
            stringBuilder.AppendLine();
            foreach (Operation operation in _operations)
            {
                stringBuilder.AppendLine(operation.Print());
            }

            return stringBuilder;
        }
    }
}