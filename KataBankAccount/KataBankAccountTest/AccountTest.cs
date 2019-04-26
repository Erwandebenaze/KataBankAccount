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

            bankCustomer.Account.GetAmountSaved().Should().Be(10);
        }

        [TestMethod]
        public void In_order_to_retrieve_his_money_customer_can_withdraw_from_his_account()
        {
            BankCustomer bankCustomer = new BankCustomer(new Account());
            double moneyToRetrieve = 5;
            double moneyToSave = 20;
            bankCustomer.MakeADeposit(moneyToSave);

            double moneyRetrieved = bankCustomer.MakeAWithdraw(moneyToRetrieve);

            moneyRetrieved.Should().Be(5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "You can not withdraw this amount because the amount of the money you saved is lower.")]
        public void A_bank_customer_can_not_retrieve_more_than_he_saved()
        {
            BankCustomer bankCustomer = new BankCustomer(new Account());
            double moneyToRetrieve = 50;
            double moneyToSave = 20;
            bankCustomer.MakeADeposit(moneyToSave);

            double moneyRetrieved = bankCustomer.MakeAWithdraw(moneyToRetrieve);
        }

        [TestMethod]
        public void When_a_customer_retrieve_money_the_amountSaved_on_the_account_is_exact()
        {
            BankCustomer bankCustomer = new BankCustomer(new Account());
            double moneyToRetrieve = 5;
            double moneyToSave = 20;
            bankCustomer.MakeADeposit(moneyToSave);

            double moneyRetrieved = bankCustomer.MakeAWithdraw(moneyToRetrieve);

            bankCustomer.Account.GetAmountSaved().Should().Be(15);
        }
    }
}
