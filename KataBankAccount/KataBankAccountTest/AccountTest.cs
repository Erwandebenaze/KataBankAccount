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
            Account account = new Account();
            Customer customer = new Customer(account);

            double moneyToSave = 10;
            customer.MakeADeposit(moneyToSave);


            customer.Account.GetAmount().Should().Be(10);
        }
    }
}
