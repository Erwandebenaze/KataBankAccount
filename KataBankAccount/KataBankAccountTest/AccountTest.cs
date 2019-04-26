using System;
using System.Runtime.Remoting;
using FluentAssertions;
using KataBankAccount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataBankAccountTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void In_order_to_save_money_customer_can_deposit_money_on_his_account()
        {
            BankCustomer bankCustomer = new BankCustomer(new Account());
            double moneyToSave = 10;

            bankCustomer.MakeADeposit(moneyToSave);

            bankCustomer.Account.GetAmount().Should().Be(10);
        }
    }
}
