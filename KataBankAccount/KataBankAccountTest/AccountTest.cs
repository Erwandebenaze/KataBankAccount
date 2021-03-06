﻿using FluentAssertions;
using KataBankAccount;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataBankAccountTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void US_1_in_order_to_save_money_customer_can_deposit_money_on_his_account()
        {
            BankCustomer bankCustomer = new BankCustomer();
            Amount moneyToSave = Amount.Of(10);

            DateTime actualDate = DateTime.Now;
            bankCustomer.MakeADeposit(moneyToSave, actualDate);

            bankCustomer.AmountOnAccount().Should().Be(Amount.Of(10));
        }

        [TestMethod]
        public void US_2_in_order_to_retrieve_his_money_customer_can_withdraw_from_his_account()
        {
            BankCustomer bankCustomer = new BankCustomer();
            DateTime actualDate = DateTime.Now;
            Amount moneyToRetrieve = Amount.Of(5);
            Amount moneyToSave = Amount.Of(20);
            bankCustomer.MakeADeposit(moneyToSave, actualDate);

            Amount moneyRetrieved = bankCustomer.Withdraw(moneyToRetrieve, actualDate);

            moneyRetrieved.Should().Be(Amount.Of(5));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "Withdraw impossible, the saved is lower than amount wanted.")]
        public void US_2_a_bank_customer_can_not_retrieve_more_than_he_saved()
        {
            BankCustomer bankCustomer = new BankCustomer();
            Amount moneyToRetrieve = Amount.Of(50);
            Amount moneyToSave = Amount.Of(20);
            DateTime actualDate = DateTime.Now;
            bankCustomer.MakeADeposit(moneyToSave, actualDate);

            Amount moneyRetrieved = bankCustomer.Withdraw(moneyToRetrieve, actualDate);

        }

        [TestMethod]
        public void US_2_when_a_customer_retrieve_money_the_amountSaved_on_the_account_is_exact()
        {
            BankCustomer bankCustomer = new BankCustomer();
            Amount moneyToRetrieve = Amount.Of(5);
            Amount moneyToSave = Amount.Of(20);
            DateTime actualDate = DateTime.Now;
            bankCustomer.MakeADeposit(moneyToSave, actualDate);

            Amount moneyRetrieved = bankCustomer.Withdraw(moneyToRetrieve, actualDate);

            bankCustomer.AmountOnAccount().Should().Be(Amount.Of(15));
        }

        [TestMethod]
        public void US_2_a_customer_can_retrieve_all_his_money_saved_on_his_account()
        {
            BankCustomer bankCustomer = new BankCustomer();
            Amount moneyToSave = Amount.Of(20);
            DateTime actualDate = DateTime.Now;
            bankCustomer.MakeADeposit(moneyToSave, actualDate);

            Amount moneyRetrieved = bankCustomer.WithdrawAllSaves(actualDate);

            moneyRetrieved.Should().Be(Amount.Of(20));
        }
    }
}
