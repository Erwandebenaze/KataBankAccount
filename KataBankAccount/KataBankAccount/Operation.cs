using System;
using System.Text;

namespace KataBankAccount
{
    public class Operation
    {
        private readonly OperationName _name;
        private readonly DateTime _date;
        private readonly double _amount;
        private readonly double _balance;

        public Operation(OperationName name, DateTime operationDate, double amount, double balance)
        {
            _name = name;
            _date = operationDate;
            _amount = amount;
            _balance = balance;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Operation : " + _name + ", ");
            stringBuilder.Append("date : " + _date + ", ");
            stringBuilder.Append("amount after operation : " + _amount + ", ");
            stringBuilder.Append("balance : " + _balance);
            return stringBuilder.ToString();
        }
    }
}