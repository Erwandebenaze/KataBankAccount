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
        public void US_3_in_order_to_check_his_operation_a_customer_can_see_them()
        {
            BankCustomer bankCustomer = new BankCustomer(new Account());
            double moneyToSave = 20;
            bankCustomer.MakeADeposit(moneyToSave);

            double moneyRetrieved = bankCustomer.WithdrawAllSaves();
            bankCustomer.MakeADeposit(moneyToSave);

            StringBuilder stringBuilder = new StringBuilder("List of operations :");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Operation number 0");
            stringBuilder.AppendLine("Operation number 1");
            stringBuilder.AppendLine("Operation number 2");
            bankCustomer.SeeOperationsOfAccount().ToString().Should().Be(stringBuilder.ToString());
        }
    }
}
