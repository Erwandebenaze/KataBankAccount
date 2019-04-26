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

        [TestMethod]
        public void In_order_to_retrieve_his_money_customer_can_withdraw_from_his_account()
        {
            BankCustomer bankCustomer = new BankCustomer(new Account());
            double moneyToRetrieve = 5;
            double moneyToSave = 20;
            bankCustomer.MakeADeposit(moneyToSave);

            double moneyRetrieved = bankCustomer.MakeAWithdraw(moneyToRetrieve);

            moneyRetrieved.Should().Be(15);
        }
    }
}
