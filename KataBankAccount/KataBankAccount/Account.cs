using System;
using System.Collections.Generic;
using System.Text;

namespace KataBankAccount
{

    public class Account
    {
        private readonly IList<Operation> _operations;
        private readonly Amount _amount;

        internal Account()
        {
            _operations = new List<Operation>();
            _amount = Amount.Of(0);
        }
        internal void DepositMoney(Amount moneyToSave, DateTime operationDate)
        {
            _amount.IncreaseAmount(moneyToSave);
            Amount balance = moneyToSave;
            _operations.Add(Operation.Of(OperationName.Deposit, operationDate, _amount, balance));
        }
        internal Amount WithdrawMoney(Amount moneyToRetrieve, DateTime operationDate)
        {
            if (IsEnoughtMoneyToWithdraw(moneyToRetrieve))
            {
                _amount.DecreaseAmount(moneyToRetrieve);
                Amount balance = _amount.GetOppositeAmount();
                _operations.Add(Operation.Of(OperationName.Withdraw, operationDate, _amount, balance));
                return moneyToRetrieve;
            }
            else
            {
                throw new InvalidOperationException("Withdraw impossible, the saved is lower than amount wanted.");
            }
        }

        internal Amount WithdrawAllSaved(DateTime operationDate)
        {
            Amount moneyToRetrieve = _amount.CreateCopy();
            Amount balance = _amount.GetOppositeAmount();
            _amount.DecreaseAmount(_amount);

            _operations.Add(Operation.Of(OperationName.WithdrawAll, operationDate, _amount, balance));
            return moneyToRetrieve;
        }

        internal Amount GetAmountSaved()
        {
            return _amount;
        }


        private bool IsEnoughtMoneyToWithdraw(Amount moneyToWithdraw)
        {
            return _amount.IsSuperiorThan(moneyToWithdraw);
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