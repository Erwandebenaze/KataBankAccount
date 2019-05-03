using System;
using System.Text;

namespace KataBankAccount
{
    public class Operation
    {
        private readonly OperationName _name;
        private readonly DateTime _date;
        private readonly Amount _amount;
        private readonly Amount _balance;
        public static Operation Of(OperationName name, DateTime operationDate, Amount amount, Amount balance)
        {
            return new Operation(name, operationDate, amount.CreateCopy(), balance);
        }


        private Operation(OperationName name, DateTime operationDate, Amount amount, Amount balance)
        {
            _name = name;
            _date = operationDate;
            _amount = amount;
            _balance = balance;
        }

        public string Print()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Operation : " + _name + ", ");
            stringBuilder.Append("date : " + _date + ", ");
            stringBuilder.Append("amount after operation : " + _amount.ToString() + ", ");
            stringBuilder.Append("balance : " + _balance.ToString());
            return stringBuilder.ToString();
        }
    }
}