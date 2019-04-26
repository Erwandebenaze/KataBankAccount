using System;
using System.Runtime.Remoting;
using System.Text;
using FluentAssertions;
using KataBankAccount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataBankAccountTest
{
    [TestClass]
    public class OperationTest
    {

        [TestMethod]
        public void US_3_in_order_to_check_his_operation_a_customer_can_see_them_with_operation_date_amount_balance()
        {
            BankCustomer bankCustomer = new BankCustomer(Account.Of());
            double moneyToSave = 20;
            DateTime actualDate = DateTime.Now;
            bankCustomer.MakeADeposit(moneyToSave, actualDate);

            double moneyRetrieved = bankCustomer.WithdrawAllSaves(actualDate);
            bankCustomer.MakeADeposit(moneyToSave, actualDate);

            StringBuilder stringBuilder = new StringBuilder("List of operations :");
            stringBuilder.AppendLine();
            stringBuilder.Append("Operation : " + OperationName.Deposit);
            stringBuilder.Append(", ");
            stringBuilder.Append("date : " + actualDate);
            stringBuilder.Append(", ");
            stringBuilder.Append("amount after operation : " + moneyToSave);
            stringBuilder.Append(", ");
            stringBuilder.Append("balance : " + moneyToSave);

            stringBuilder.AppendLine();

            stringBuilder.Append("Operation : " + OperationName.WithdrawAll);
            stringBuilder.Append(", ");
            stringBuilder.Append("date : " + actualDate);
            stringBuilder.Append(", ");
            stringBuilder.Append("amount after operation : 0");
            stringBuilder.Append(", ");
            stringBuilder.Append("balance : " + -moneyToSave);

            stringBuilder.AppendLine();

            stringBuilder.Append("Operation : " + OperationName.Deposit);
            stringBuilder.Append(", ");
            stringBuilder.Append("date : " + actualDate);
            stringBuilder.Append(", ");
            stringBuilder.Append("amount after operation : " + moneyToSave);
            stringBuilder.Append(", ");
            stringBuilder.AppendLine("balance : " + moneyToSave);
            bankCustomer.SeeOperationsOfAccount().ToString().Should().Be(stringBuilder.ToString());
        }
    }
}
